using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        private double kmpl;

        public Form1()
        {
     InitializeComponent(); // 初始化表單元件
        }

        // 當使用者按下「計算 MPG」按鈕時執行
        private void calculateButton_Click(object sender, EventArgs e)
        {
            double kilometers; // 行駛的公里數
            double liters; // 使用的汽油公升數
            double miles; // 行駛的英里數

            kilometers = double.Parse(milesTextBox.Text);
            liters = double.Parse(gallonsTextBox.Text);

            kmpl = kilometers / liters;


            mpgLabel.Text = kmpl.ToString() + "公里/公升"; 
                
            
                
        }

        // 當使用者按下「離開」按鈕時執行
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
    }
}
