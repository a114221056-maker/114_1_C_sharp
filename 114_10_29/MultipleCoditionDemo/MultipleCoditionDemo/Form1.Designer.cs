namespace MultipleCoditionDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.Button btnJudge;
        private System.Windows.Forms.Label lblGrade;

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
            lblScore = new Label();
            txtScore = new TextBox();
            btnJudge = new Button();
            lblGrade = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblScore
            // 
            lblScore.AutoSize = true;
            lblScore.Font = new Font("Segoe UI", 22F);
            lblScore.Location = new Point(12, 15);
            lblScore.Name = "lblScore";
            lblScore.Size = new Size(127, 60);
            lblScore.TabIndex = 0;
            lblScore.Text = "成績:";
            // 
            // txtScore
            // 
            txtScore.Font = new Font("Segoe UI", 22F);
            txtScore.Location = new Point(160, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(100, 66);
            txtScore.TabIndex = 1;
            // 
            // btnJudge
            // 
            btnJudge.Font = new Font("Segoe UI", 22F);
            btnJudge.Location = new Point(69, 256);
            btnJudge.Name = "btnJudge";
            btnJudge.Size = new Size(367, 73);
            btnJudge.TabIndex = 2;
            btnJudge.Text = "    ";
            btnJudge.UseVisualStyleBackColor = true;
            btnJudge.Click += btnJudge_Click;
            // 
            // lblGrade
            // 
            lblGrade.BorderStyle = BorderStyle.Fixed3D;
            lblGrade.Font = new Font("Segoe UI", 22F);
            lblGrade.Location = new Point(169, 114);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(309, 60);
            lblGrade.TabIndex = 3;
            lblGrade.TextAlign = ContentAlignment.MiddleCenter;
            lblGrade.Click += lblGrade_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F);
            label1.Location = new Point(25, 114);
            label1.Name = "label1";
            label1.Size = new Size(127, 60);
            label1.TabIndex = 4;
            label1.Text = "成績:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblGrade);
            Controls.Add(btnJudge);
            Controls.Add(txtScore);
            Controls.Add(lblScore);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}
