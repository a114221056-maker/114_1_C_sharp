namespace Heads_or_Tails
{
    public partial class exitButton : Form
    {
        public exitButton()
        {
            InitializeComponent();
        }

        private void tailPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void showheadsButton_Click(object sender, EventArgs e)
        {
            tailPictureBox.Visible = false;
            headPictureBox.Visible = true;
        }

        private void showtailButton_Click(object sender, EventArgs e)
        {
            tailPictureBox.Visible = true;
            headPictureBox.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();    
        }
    }
}
