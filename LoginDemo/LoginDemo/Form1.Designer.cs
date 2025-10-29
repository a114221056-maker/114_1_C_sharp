namespace LoginDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxAccount;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Label labelResult;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelAccount = new Label();
            labelPassword = new Label();
            textBoxAccount = new TextBox();
            textBoxPassword = new TextBox();
            buttonCheck = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Font = new Font("Segoe UI", 22F);
            labelAccount.Location = new Point(40, 40);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new Size(163, 60);
            labelAccount.TabIndex = 0;
            labelAccount.Text = "帳號：";
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Segoe UI", 22F);
            labelPassword.Location = new Point(40, 110);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(163, 60);
            labelPassword.TabIndex = 1;
            labelPassword.Text = "密碼：";
            // 
            // textBoxAccount
            // 
            textBoxAccount.Font = new Font("Segoe UI", 22F);
            textBoxAccount.Location = new Point(160, 36);
            textBoxAccount.Name = "textBoxAccount";
            textBoxAccount.Size = new Size(420, 66);
            textBoxAccount.TabIndex = 2;
            textBoxAccount.TextChanged += textBoxAccount_TextChanged;
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Segoe UI", 22F);
            textBoxPassword.Location = new Point(160, 106);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(420, 66);
            textBoxPassword.TabIndex = 3;
            textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonCheck
            // 
            buttonCheck.Font = new Font("Segoe UI", 22F);
            buttonCheck.Location = new Point(254, 195);
            buttonCheck.Name = "buttonCheck";
            buttonCheck.Size = new Size(140, 60);
            buttonCheck.TabIndex = 4;
            buttonCheck.Text = "檢查";
            buttonCheck.UseVisualStyleBackColor = true;
            buttonCheck.Click += buttonCheck_Click;
            // 
            // labelResult
            // 
            labelResult.BorderStyle = BorderStyle.Fixed3D;
            labelResult.Font = new Font("Segoe UI", 22F);
            labelResult.Location = new Point(40, 273);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(579, 151);
            labelResult.TabIndex = 5;
            labelResult.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(690, 449);
            Controls.Add(labelResult);
            Controls.Add(buttonCheck);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxAccount);
            Controls.Add(labelPassword);
            Controls.Add(labelAccount);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
