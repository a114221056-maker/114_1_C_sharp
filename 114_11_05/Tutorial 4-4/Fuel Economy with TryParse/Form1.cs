using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy_with_TryParse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kms; 
            double liters;
            double fuelEconomy;

            if (double.TryParse(milesTextBox.Text, out kms))
            {
                // 成功將 milesTextBox 的內容解析為數值並存入 kms 變數（公里數）
                // 其他計算邏輯尚未實作
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
