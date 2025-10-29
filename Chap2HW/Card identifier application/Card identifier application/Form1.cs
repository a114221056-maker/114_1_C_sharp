namespace Card_identifier_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void shownameLabel_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cardeightPictureBox_Click(object sender, EventArgs e)
        {
            shownnameLabel.Text = "Eight of Clubs";
        }

        private void cardtwoPictureBox_Click(object sender, EventArgs e)
        {
            shownnameLabel.Text = "Two of Clubs";
        }

        private void cardkPictureBox_Click(object sender, EventArgs e)
        {
            shownnameLabel.Text = "K of Clubs";
        }

        private void cardaPictureBox_Click(object sender, EventArgs e)
        {
            shownnameLabel.Text = "A of Clubs";
        }

        private void cardjokerPictureBox_Click(object sender, EventArgs e)
        {
            shownnameLabel.Text = "Joker of Clubs";
        }
    }
}
