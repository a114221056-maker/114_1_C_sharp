using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // 用於文字替換（繁體中文翻譯替換）

namespace Time_Zone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // 以下會將所有元件（包含表單本身與其子控制項）的字型大小統一設為 18pt，
            // 並嘗試將控制項的 Text 屬性轉換為「繁體中文」。
            // - 字型只改變大小（保留原本的字型家族與樣式）；不會變更其他屬性。
            // - 對於已知的常見英文字串（如 OK、Exit、Name 等）會做字詞級的替換。
            // - 若控制項名稱含有慣用詞（如 ok、exit）會以該名稱優先決定顯示文字。
            // - 遞迴處理所有子控制項（GroupBox、Panel 等皆會處理）。
            // 若需要更精準的翻譯對應，請提供控制項清單或在設計檔中直接修改 Text 屬性。
            ApplyTraditionalChineseTextAndFont(this);
        }

        /// <summary>
        /// 遞迴將指定控制項與其子控制項的 Font 大小設定為 18，並將 Text 屬性轉為繁體中文。
        /// 詳細註解（繁體中文）：
        /// - 目的：在程式執行時統一 UI 文字為繁體中文並放大字型（18pt）。
        /// - 安全性：不會移除或變更控制項其他屬性（位置、尺寸、事件等皆保留）。
        /// - 翻譯策略：
        ///   1. 依 control.Name 做關鍵字比對（例如名稱包含 "ok"、"exit" 等） -> 直接套用對應中文。
        ///   2. 若名稱沒有匹配，但 control.Text 有內容，則對該 Text 進行詞彙替換，
        ///      使用內建的簡單詞典做全詞（word boundary）替換（非完整機器翻譯）。
        ///   3. 此方法為簡易自動化處理；若需人工逐一校稿或更精準翻譯，請在設計檔修改 Text。
        /// </summary>
        /// <param name="parent">要處理的父控制項（一般以 this 傳入）</param>
        private void ApplyTraditionalChineseTextAndFont(Control parent)
        {
            // 簡單詞典：英文關鍵字 -> 繁體中文
            var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase)
            {
                {"ok", "確定"},
                {"confirm", "確定"},
                {"cancel", "取消"},
                {"exit", "離開"},
                {"close", "離開"},
                {"submit", "送出"},
                {"search", "搜尋"},
                {"name", "名稱"},
                {"address", "地址"},
                {"time", "時間"},
                {"zone", "時區"},
                {"result", "結果"},
                {"hello", "您好"},
                {"status", "狀態"},
                {"save", "儲存"},
                {"load", "載入"},
                {"clear", "清除"},
                {"back", "返回"}
            };

            // 設定控制項的字型大小為 18，並嘗試替換文字為繁體中文
            void ProcessControl(Control ctrl)
            {
                if (ctrl == null) return;

                // 保留現有字型家族與樣式，只修改大小為 18
                try
                {
                    ctrl.Font = new Font(ctrl.Font.FontFamily, 18f, ctrl.Font.Style);
                }
                catch
                {
                    // 若設定 Font 發生例外（極少情況），則忽略以避免中斷程式執行
                }

                // 先依控制項名稱推斷指定文字
                string name = ctrl.Name ?? string.Empty;
                string loweredName = name.ToLowerInvariant();

                bool nameMatched = false;
                if (!string.IsNullOrWhiteSpace(name))
                {
                    foreach (var kv in dict)
                    {
                        if (loweredName.Contains(kv.Key.ToLowerInvariant()))
                        {
                            // 若名稱包含關鍵字，則以此為優先翻譯結果
                            ctrl.Text = kv.Value;
                            nameMatched = true;
                            break;
                        }
                    }
                }

                // 若名稱未匹配，且控制項已有文字，則嘗試以詞典進行詞級替換
                if (!nameMatched && !string.IsNullOrWhiteSpace(ctrl.Text))
                {
                    string newText = ctrl.Text;
                    foreach (var kv in dict)
                    {
                        // 只替換全詞（利用 Regex 邊界）
                        try
                        {
                            newText = Regex.Replace(newText,
                                @"\b" + Regex.Escape(kv.Key) + @"\b",
                                kv.Value,
                                RegexOptions.IgnoreCase);
                        }
                        catch
                        {
                            // 若 Regex 發生例外，忽略該詞替換，繼續處理其他詞
                        }
                    }

                    // 若替換後與原文字不同，才設回控制項
                    if (!string.Equals(newText, ctrl.Text, StringComparison.Ordinal))
                    {
                        ctrl.Text = newText;
                    }
                }

                // 特別處理 Form（表單標題）— 若為表單，且 Text 為預設或空白，設定成「時區」描述
                if (ctrl is Form form)
                {
                    if (string.IsNullOrWhiteSpace(form.Text))
                    {
                        form.Text = "時區";
                    }
                    else
                    {
                        // 若表單標題包含常見英文，可嘗試替換（上面的詞典已處理）
                        // 若你想要更具體的表單標題，請直接指定 form.Text = "你的標題";
                    }
                }

                // 遞迴處理子控制項（例如 GroupBox、Panel、TabPage 等）
                foreach (Control child in ctrl.Controls)
                {
                    ProcessControl(child);
                }

                // 若控制項是 ToolStrip 類型，ToolStrip 的 Items 不屬於 Control.Controls，需要另外處理
                if (ctrl is ToolStrip ts)
                {
                    foreach (ToolStripItem item in ts.Items)
                    {
                        // ToolStripItem 沒有 Font 屬性可直接設定在所有版本上，但大多數支援 Font
                        try
                        {
                            item.Font = new Font(item.Font?.FontFamily ?? SystemFonts.DefaultFont.FontFamily, 18f, item.Font?.Style ?? FontStyle.Regular);
                        }
                        catch
                        {
                        }

                        if (!string.IsNullOrWhiteSpace(item.Name))
                        {
                            foreach (var kv in dict)
                            {
                                if (item.Name.IndexOf(kv.Key, StringComparison.OrdinalIgnoreCase) >= 0)
                                {
                                    item.Text = kv.Value;
                                    break;
                                }
                            }
                        }

                        if (!string.IsNullOrWhiteSpace(item.Text))
                        {
                            string newText = item.Text;
                            foreach (var kv in dict)
                            {
                                try
                                {
                                    newText = Regex.Replace(newText,
                                        @"\b" + Regex.Escape(kv.Key) + @"\b",
                                        kv.Value,
                                        RegexOptions.IgnoreCase);
                                }
                                catch
                                {
                                }
                            }
                            if (!string.Equals(newText, item.Text, StringComparison.Ordinal))
                            {
                                item.Text = newText;
                            }
                        }
                    }
                }
            }

            // 從父控制項開始處理（通常 parent 為 this）
            ProcessControl(parent);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            // 按下「確定」按鈕的事件處理函式（目前未實作具體功能）。
            // 詳細註解：
            // - 這裡保留事件簽章（與設計檔綁定），若需要在使用者按下確定後執行某些動作，
            //   請在此加入對應邏輯，例如驗證輸入、儲存設定或關閉視窗等。
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單（按下「離開」按鈕時執行）。
            // 詳細註解：
            // - this.Close() 會觸發表單的 Closing/Closed 事件，若需在關閉前提示使用者或
            //   防止關閉（例如有未儲存資料），請在 Form 的 FormClosing 事件中處理。
            this.Close();
        }
    }
}
