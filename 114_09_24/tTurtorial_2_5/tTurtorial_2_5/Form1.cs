namespace tTurtorial_2_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cardBack_Click(object sender, EventArgs e)
        {

        }

        private void showBackButton_Click(object sender, EventArgs e)
        {
            cardBack.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cardBack.Visible = false;
            cardFacepictureBox.Visible = false;
        }

        private void cardFacepictureBox_Click(object sender, EventArgs e)
        {

            cardFacepictureBox.Visible = true;
        }

        private void showFaceButton_Click(object sender, EventArgs e)
        {
            cardFacepictureBox.Visible = true;
        }
    }
}
