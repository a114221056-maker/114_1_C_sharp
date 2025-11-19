using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Friend_File
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void writeNameButton_Click(object sender, EventArgs e)
        {
            try
            {
                // 顯示選擇對話方塊：使用者可選擇要寫出的朋友名字
                // 按鈕對應：Yes => "Tommy", No => "David", Cancel => 結束操作
                var result = MessageBox.Show(
                    "請選擇要寫出的朋友名字：\n\n是 = Tommy\n否 = David\n取消 = 取消動作",
                    "選擇朋友名字",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Question);

                string friendName;
                if (result == DialogResult.Yes)
                {
                    friendName = "Tommy";
                }
                else if (result == DialogResult.No)
                {
                    friendName = "David";
                }
                else
                {
                    // 使用者選擇取消，結束處理
                    return;
                }

                // 顯示在介面的輸入框，讓使用者立即看到結果
                this.nameTextBox.Text = friendName;

                // 產生檔案路徑：使用使用者的「我的文件」資料夾，檔名為 friend_name.txt
                string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                string filePath = Path.Combine(documentsPath, "friend_name.txt");

                // 將名字寫入檔案；使用 UTF8 編碼以正確儲存中文（若為英文亦適用）
                File.WriteAllText(filePath, friendName, Encoding.UTF8);

                // 通知使用者寫入成功並顯示檔案位置
                MessageBox.Show("已將朋友名字 \"" + friendName + "\" 寫入檔案：" + Environment.NewLine + filePath,
                                "寫入完成", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // 發生錯誤時顯示錯誤訊息以利除錯
                MessageBox.Show("發生錯誤: " + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
