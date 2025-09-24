namespace tutorial2_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countryLabel_Click(object sender, EventArgs e)
        {

        }

        private void finlandPictureBox_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "ªâÄõ";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "·ç¨å";
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            countryLabel.Text = "®¿«Â";
        }
    }
}
