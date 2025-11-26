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
            // 取得並檢查輸入
            string name = nameTextBox.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("請輸入名字。", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                nameTextBox.Focus();
                return;
            }

            // 檔案路徑：我的文件\FriendFile\friends.txt
            string folder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "FriendFile");
            try
            {
                Directory.CreateDirectory(folder);
                string filePath = Path.Combine(folder, "friends.txt");

                // 每筆一行，包含時間與名字，使用 UTF-8 編碼
                string line = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss}\t{name}{Environment.NewLine}";
                File.AppendAllText(filePath, line, Encoding.UTF8);

                MessageBox.Show($"已儲存: {name}\n檔案位置: {filePath}", "完成", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // 清除輸入以便下次輸入
                nameTextBox.Clear();
                nameTextBox.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"儲存失敗：{ex.Message}", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
    