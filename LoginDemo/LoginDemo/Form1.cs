using System;
using System.Windows.Forms;

namespace LoginDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // �p���]�ԲӰ��{���^:
        // 1. Ū���ϥΪ̿�J���b���P�K�X (account = textBoxAccount.Text.Trim(), password = textBoxPassword.Text)
        // 2. ���b���P�K�X�O�_����d�ұb�K (user / pass)
        // 3. �Y��令�\�A�]�w labelResult.Text �� "���T"
        // 4. �Y�b�����T���K�X���~�A�]�w labelResult.Text �� "���~"
        // 5. �Y�b�����~�A�]�w labelResult.Text �� "�b�����~"
        // 6. �ϥΪ̨C���ק�b���ɲM�����e���G (labelResult.Text = string.Empty)

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string account = textBoxAccount.Text.Trim();
            string password = textBoxPassword.Text;

            const string expectedAccount = "user";
            const string expectedPassword = "pass";

            // �Y�b�����T�A�ˬd�K�X�F�Y�b�����~�h��ܡu�b�����~�v
            if (account == expectedAccount)
            {
                if (password == expectedPassword)
                {
                    labelResult.Text = "���T";
                }
                else
                {
                    labelResult.Text = "���~";
                }
            }
            else
            {
                labelResult.Text = "�b�����~";
            }
        }

        private void textBoxAccount_TextChanged(object sender, EventArgs e)
        {
            // �ϥΪ̭ק�b���ɲM�����e���G
            labelResult.Text = string.Empty;
        }
    }
}
