namespace RadioButtonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        // 計畫 (Pseudocode):
        // 1. 建立按鈕事件的實作，移除對不存在控制項的直接參照，避免 CS0103。
        // 2. 使用遞迴搜尋表單上所有 RadioButton，收集已勾選的項目，避免依賴特定名稱。
        // 3. 將第一個已勾選的當作 drink，第二個當作 sandwich（若有的話）。
        // 4. 組合 message 字串並顯示 MessageBox，這樣可消除未使用變數的警告 (CS0219)。
        // 5. 確保每個敘述都以分號結尾，修正 CS1002。

            private void button1_Click(object sender, EventArgs e)
        {
            string message = "點餐內容";
            string drink = "";
            string sandwich = "";

            var checkedButtons = new List<RadioButton>();

            // 遞迴搜尋所有子控制項，收集被勾選的 RadioButton
            void CollectCheckedRadioButtons(Control parent)
            {
                foreach (Control c in parent.Controls)
                {
                    if (c is RadioButton rb && rb.Checked)
                    {
                        checkedButtons.Add(rb);
                    }
                    if (c.HasChildren)
                    {
                        CollectCheckedRadioButtons(c);
                    }
                }
            }

            CollectCheckedRadioButtons(this);

            if (checkedButtons.Count > 0)
            {
                drink = checkedButtons[0].Text;
            }

            if (checkedButtons.Count > 1)
            {
                sandwich = checkedButtons[1].Text;
            }

            var parts = new List<string>();
            if (!string.IsNullOrEmpty(drink))
            {
                parts.Add("飲料： " + drink);
            }
            if (!string.IsNullOrEmpty(sandwich))
            {
                parts.Add("三明治： " + sandwich);
            }

            if (parts.Count == 0)
            {
                message += "\r\n尚未選擇任何項目";
            }
            else
            {
                message += "\r\n" + string.Join("\r\n", parts);
            }

            MessageBox.Show(message, "點餐");
        }

        }
    }
}
