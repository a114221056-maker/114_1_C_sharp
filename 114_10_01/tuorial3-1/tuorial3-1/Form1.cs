namespace tuorial3_1
{
    public partial class Form1 : Form
    {
        private object dateOutputLabel;

        public object DayOfWeekTextBox { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private string GetMonth()
        {
            return month;
        }

        private void showDate_Click(object sender, EventArgs e, string month)
        {

            string dayOfWeek = dayOfWeekTextBox.Text;
            string month = monthTextBox.Text;
            string dayOfMonth= dayOfWeekTextBox.Text;
            string year = yearTextBox.Text;

            string output = $"中華民國{year}年{month}月{dayOfMonth}日星期{dayOfWeek}"



                dateOutputLabel.Text = output;
                
            








        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dayOfWeekTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearBotton_Click(object sender, EventArgs e)
        {
            dayOfWeekTextBox.Text = "";
            monthTextBox.Text = "";
            dayOfMonthTextBox.Text = "";
            yearTextBox.Text = "";
            dayOutputlabel.Text = "";
                
        }
    }
}
