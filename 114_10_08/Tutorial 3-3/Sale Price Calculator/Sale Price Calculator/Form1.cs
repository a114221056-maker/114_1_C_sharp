using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sale_Price_Calculator
{
    public partial class Form1 : Form
    {
        // 建構子：初始化表單元件
        public Form1()
        {
            InitializeComponent();
        }

        // 當使用者點擊「計算特價」按鈕時觸發此事件
        // 預期在此方法中取得原價與折扣百分比，計算特價後顯示於畫面
        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal originalPrice;  
            decimal discountPercentage;
            decimal salePrice;

            originalPrice = decimal.Parse(originalPriceTextBox.Text);
            discountPercentage = decimal.Parse(discountPercentageTextBox.Text);
            salePrice = originalPrice * (1 - discountPercentage / 100.0m);

            salePriceLabel.Text = salePrice.ToString("C");

            // 尚未實作：可於此處撰寫計算特價的邏輯
        }

        // 當使用者點擊「離開」按鈕時觸發此事件
        // 關閉目前的表單
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }

        // 當使用者點擊顯示特價的 Label 時觸發此事件
        // 目前未實作任何功能
        private void salePriceLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
