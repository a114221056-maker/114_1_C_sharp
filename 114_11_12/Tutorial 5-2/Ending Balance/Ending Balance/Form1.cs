using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;               // 用於數值解析時指定文化（小數/千分位）
using Microsoft.VisualBasic;              // 使用 Interaction.InputBox 讓使用者逐月輸入變動金額

namespace Ending_Balance
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// 建構子：初始化表單元件。
        /// 註：介面字型與文字已在 Designer 中設定為繁體中文與 18pt。
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 計算按鈕事件處理：
        /// - 讀取「起始餘額」與「月份數量」兩個欄位。
        /// - 逐月詢問使用者輸入該月的變動金額（可正可負，留空視為 0）。
        /// - 每輸入一個月即更新明細 ListBox，最後顯示結餘於 endingBalanceLabel。
        /// 
        /// 這樣做可以滿足「前面設計的數值可利用和打字」的需求：
        /// 使用者既能輸入初值與月數，也能逐月以鍵盤輸入每月變動。
        /// </summary>
        private void calculateButton_Click(object sender, EventArgs e)
        {
            // 清除先前明細
            detailListBox.Items.Clear();
            endingBalanceLabel.Text = "";

            // 解析起始餘額（使用 decimal 更適合金錢運算）
            if (!decimal.TryParse(startingBalTextBox.Text.Trim(),
                                  NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                  CultureInfo.CurrentCulture,
                                  out decimal balance))
            {
                MessageBox.Show("請輸入有效的起始餘額（數字）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                startingBalTextBox.Focus();
                return;
            }

            // 解析月份數量
            if (!int.TryParse(monthsTextBox.Text.Trim(), out int months) || months <= 0)
            {
                MessageBox.Show("請輸入有效的月份數量（正整數）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                monthsTextBox.Focus();
                return;
            }

            // 逐月詢問變動金額，並且更新明細與結餘
            for (int i = 1; i <= months; i++)
            {
                string prompt = $"請輸入第 {i} 個月的變動金額（正數為存入，負數為提款）。\n\n※ 留空或按「取消」視為 0。";
                string title = $"第 {i} 個月變動金額";
                string input = Interaction.InputBox(prompt, title, "0");

                // 若使用者直接按取消或留空，InputBox 回傳為空字串，視為 0
                if (string.IsNullOrWhiteSpace(input))
                {
                    input = "0";
                }

                // 解析該月變動金額
                if (!decimal.TryParse(input.Trim(),
                                      NumberStyles.Number | NumberStyles.AllowCurrencySymbol,
                                      CultureInfo.CurrentCulture,
                                      out decimal change))
                {
                    // 若解析失敗，顯示錯誤並要求重新輸入該月
                    MessageBox.Show($"第 {i} 個月的輸入無效，請輸入數字（可包含小數與負號）。", "輸入錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    i--; // 讓迴圈在同一個月重試
                    continue;
                }

                // 更新結餘
                balance += change;

                // 將該月明細加入 ListBox（使用目前文化顯示貨幣格式）
                string line = $"第 {i} 個月：變動 {change.ToString("C2", CultureInfo.CurrentCulture)}，餘額 {balance.ToString("C2", CultureInfo.CurrentCulture)}";
                detailListBox.Items.Add(line);
            }

            // 顯示最終結餘
            endingBalanceLabel.Text = balance.ToString("C2", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// 清除按鈕的事件處理程序。
        /// 功能：
        /// - 清除起始餘額與月份數量的輸入欄位。
        /// - 清除顯示結餘的標籤與明細 ListBox。
        /// - 將焦點重設回起始餘額輸入框。
        /// </summary>
        private void clearButton_Click(object sender, EventArgs e)
        {
            // 清除 TextBox、顯示結餘的 Label 以及 ListBox 的項目。
            startingBalTextBox.Text = "";
            monthsTextBox.Text = "";
            endingBalanceLabel.Text = "";
            detailListBox.Items.Clear();

            // 將輸入焦點重設到起始餘額的輸入框，方便使用者繼續輸入。
            startingBalTextBox.Focus();
        }

        /// <summary>
        /// 離開按鈕的事件處理程序。
        /// 功能：關閉目前的表單視窗。
        /// </summary>
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }

        // 以下兩個事件保留，空實作以免設計工具產生錯誤。
        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void monthsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startingBalTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
