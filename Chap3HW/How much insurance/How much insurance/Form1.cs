using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace How_much_insurance
{

    public partial class Form1 : Form
    {
        private object insuranceAmountLabel;

        // 刪除 private object insuranceAmountLabel;
        // 不需要重新宣告，直接使用設計器產生的 Label 控制項

        public Form1()
        {
            InitializeComponent();
        }

        private void outputDescriptionLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            instranceamountLabel.Text = "";

            textBox1.Focus();


        }

        private void insuranceaountLabel_Click(object sender, EventArgs e)
        {

        }


        private void calculateButton_Click(object sender, EventArgs e)
        {
            double buildingPrice, insuranceAmount;

        }

        private void calcuateButton_Click(object sender, EventArgs e)

        {
            double cost = 0;

            try
            {

                cost = double.Parse(textBox1.Text);

                // 計算保險金額為建築物價格的 80%
                cost = cost * 0.8;


                instranceamountLabel.Text = cost.ToString("n2");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "例外發生");
                textBox1.Focus();
            }
        }
    }
}







