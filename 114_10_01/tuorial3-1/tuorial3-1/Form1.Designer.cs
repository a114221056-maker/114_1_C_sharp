namespace tuorial3_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            dayOfWeekTextBox = new TextBox();
            monthTextBox = new TextBox();
            dayOfMonthTextBox = new TextBox();
            yearTextBox = new TextBox();
            dayOutputlabel = new Label();
            showDate = new Button();
            clearBotton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            label1.Location = new Point(103, 43);
            label1.Name = "label1";
            label1.Size = new Size(90, 41);
            label1.TabIndex = 0;
            label1.Text = "星期:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 175);
            label2.Name = "label2";
            label2.Size = new Size(0, 23);
            label2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 279);
            label3.Name = "label3";
            label3.Size = new Size(0, 23);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 373);
            label4.Name = "label4";
            label4.Size = new Size(0, 23);
            label4.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            label5.Location = new Point(135, 251);
            label5.Name = "label5";
            label5.Size = new Size(58, 41);
            label5.TabIndex = 4;
            label5.Text = "年:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            label6.Location = new Point(135, 185);
            label6.Name = "label6";
            label6.Size = new Size(58, 41);
            label6.TabIndex = 5;
            label6.Text = "日:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Bold);
            label7.Location = new Point(135, 118);
            label7.Name = "label7";
            label7.Size = new Size(58, 41);
            label7.TabIndex = 6;
            label7.Text = "月:";
            // 
            // dayOfWeekTextBox
            // 
            dayOfWeekTextBox.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            dayOfWeekTextBox.Location = new Point(214, 44);
            dayOfWeekTextBox.Name = "dayOfWeekTextBox";
            dayOfWeekTextBox.Size = new Size(347, 43);
            dayOfWeekTextBox.TabIndex = 7;
            dayOfWeekTextBox.TextChanged += dayOfWeekTextBox_TextChanged;
            // 
            // monthTextBox
            // 
            monthTextBox.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            monthTextBox.Location = new Point(214, 118);
            monthTextBox.Name = "monthTextBox";
            monthTextBox.Size = new Size(347, 43);
            monthTextBox.TabIndex = 8;
            // 
            // dayOfMonthTextBox
            // 
            dayOfMonthTextBox.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            dayOfMonthTextBox.Location = new Point(214, 185);
            dayOfMonthTextBox.Name = "dayOfMonthTextBox";
            dayOfMonthTextBox.Size = new Size(347, 43);
            dayOfMonthTextBox.TabIndex = 9;
            // 
            // yearTextBox
            // 
            yearTextBox.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 136);
            yearTextBox.Location = new Point(214, 252);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.Size = new Size(347, 43);
            yearTextBox.TabIndex = 10;
            // 
            // dayOutputlabel
            // 
            dayOutputlabel.BorderStyle = BorderStyle.Fixed3D;
            dayOutputlabel.Location = new Point(78, 309);
            dayOutputlabel.Name = "dayOutputlabel";
            dayOutputlabel.Size = new Size(630, 69);
            dayOutputlabel.TabIndex = 11;
            dayOutputlabel.TextAlign = ContentAlignment.MiddleCenter;
            dayOutputlabel.Click += label8_Click;
            // 
            // showDate
            // 
            showDate.Location = new Point(78, 393);
            showDate.Name = "showDate";
            showDate.Size = new Size(135, 45);
            showDate.TabIndex = 12;
            showDate.Text = "顯示日期";
            showDate.UseVisualStyleBackColor = true;
            showDate.Click += showDate_Click;
            // 
            // clearBotton
            // 
            clearBotton.Location = new Point(298, 393);
            clearBotton.Name = "clearBotton";
            clearBotton.Size = new Size(135, 45);
            clearBotton.TabIndex = 13;
            clearBotton.Text = "清除";
            clearBotton.UseVisualStyleBackColor = true;
            clearBotton.Click += clearBotton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(509, 393);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(135, 45);
            exitButton.TabIndex = 14;
            exitButton.Text = "離開";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exitButton);
            Controls.Add(clearBotton);
            Controls.Add(showDate);
            Controls.Add(dayOutputlabel);
            Controls.Add(yearTextBox);
            Controls.Add(dayOfMonthTextBox);
            Controls.Add(monthTextBox);
            Controls.Add(dayOfWeekTextBox);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox dayOfWeekTextBox;
        private TextBox monthTextBox;
        private TextBox dayOfMonthTextBox;
        private TextBox yearTextBox;
        private Label dayOutputlabel;
        private Button showDate;
        private Button clearBotton;
        private Button exitButton;
    }
}
