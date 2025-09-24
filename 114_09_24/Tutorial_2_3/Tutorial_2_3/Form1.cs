using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tutorial_2_3
{
    public partial class Form1 : Form
    {
        private object translationLabel;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void germanybutton_Click(object sender, EventArgs e)
        {
            label7.Text = "Guten Morgen";
               
        }

        private void italianButton_Click(object sender, EventArgs e)
        {
            label7.Text = "Buongiorno";
        }

        private void label2_Click(object sender, EventArgs e)
        {
          
        }

        private void spanishButton_Click(object sender, EventArgs e)
        {
            label7.Text = "Buenos dfas";
        }
    }
}
