using System;
using System.Windows.Forms;

namespace CheckBoxDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // 在程式啟動時掛上 checkBox1 的事件處理器
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
        }
                
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
        }

        // 當 checkBox1 被勾選時，分開顯示每一種披薩口味（各自一個訊息視窗）
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                var flavors = new (string English, string TraditionalChinese)[]
                {
                    ("Hawaiian", "夏威夷"),
                    ("Takoyaki", "章魚燒"),
                    ("Italian Ham", "義式火腿"),
                    ("Seafood Mix", "綜合海鮮"),
                };

                foreach (var f in flavors)
                {
                    MessageBox.Show($"{f.English}：{f.TraditionalChinese}", "披薩口味",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
