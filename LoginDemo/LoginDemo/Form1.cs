using System;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // 計劃（詳細偽程式）:
        // 1. 讀取使用者輸入的帳號與密碼 (account = textBoxAccount.Text.Trim(), password = textBoxPassword.Text)
        // 2. 比對帳號與密碼是否等於範例帳密 (user / pass)
        // 3. 若比對成功，設定 labelResult.Text 為 "正確"
        // 4. 若帳號正確但密碼錯誤，設定 labelResult.Text 為 "錯誤"
        // 5. 若帳號錯誤，設定 labelResult.Text 為 "帳號錯誤"
        // 6. 使用者每次修改帳號時清除先前結果 (labelResult.Text = string.Empty)

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text.Trim();
            string password = textBoxPassword.Text;

            const string expectedAccount = "user";
            const string expectedPassword = "pass";

            // 若帳號正確，檢查密碼；若帳號錯誤則顯示「帳號錯誤」
            if (account == expectedAccount)
            {
                if (password == expectedPassword)
                {
                    labelResult.Text = "正確";
                }
                else
                {
                    labelResult.Text = "錯誤";
                }
            }
            else
            {
                labelResult.Text = "帳號錯誤";
            }
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            // 使用者修改帳號時清除先前結果
            labelResult.Text = string.Empty;
        }
    }
}
