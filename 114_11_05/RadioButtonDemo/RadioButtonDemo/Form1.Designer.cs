namespace RadioButtonDemo
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
            coffeeradioButton = new RadioButton();
            progressBar1 = new ProgressBar();
            milktearadioButton2 = new RadioButton();
            redteaRADIObUTTON = new RadioButton();
            juiceradioButton4 = new RadioButton();
            tunasandradioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            jellysandradioButton = new RadioButton();
            groupBox1 = new GroupBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // coffeeradioButton
            // 
            coffeeradioButton.AutoSize = true;
            coffeeradioButton.Location = new Point(89, 79);
            coffeeradioButton.Name = "coffeeradioButton";
            coffeeradioButton.Size = new Size(71, 27);
            coffeeradioButton.TabIndex = 0;
            coffeeradioButton.TabStop = true;
            coffeeradioButton.Text = "咖啡";
            coffeeradioButton.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(89, 110);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(20, 10);
            progressBar1.TabIndex = 1;
            // 
            // milktearadioButton2
            // 
            milktearadioButton2.AutoSize = true;
            milktearadioButton2.Location = new Point(89, 141);
            milktearadioButton2.Name = "milktearadioButton2";
            milktearadioButton2.Size = new Size(71, 27);
            milktearadioButton2.TabIndex = 2;
            milktearadioButton2.TabStop = true;
            milktearadioButton2.Text = "奶茶";
            milktearadioButton2.UseVisualStyleBackColor = true;
            // 
            // redteaRADIObUTTON
            // 
            redteaRADIObUTTON.AutoSize = true;
            redteaRADIObUTTON.Location = new Point(89, 199);
            redteaRADIObUTTON.Name = "redteaRADIObUTTON";
            redteaRADIObUTTON.Size = new Size(71, 27);
            redteaRADIObUTTON.TabIndex = 3;
            redteaRADIObUTTON.TabStop = true;
            redteaRADIObUTTON.Text = "紅茶";
            redteaRADIObUTTON.UseVisualStyleBackColor = true;
            // 
            // juiceradioButton4
            // 
            juiceradioButton4.AutoSize = true;
            juiceradioButton4.Location = new Point(89, 260);
            juiceradioButton4.Name = "juiceradioButton4";
            juiceradioButton4.Size = new Size(71, 27);
            juiceradioButton4.TabIndex = 4;
            juiceradioButton4.TabStop = true;
            juiceradioButton4.Text = "果汁";
            juiceradioButton4.UseVisualStyleBackColor = true;
            // 
            // tunasandradioButton4
            // 
            tunasandradioButton4.AutoSize = true;
            tunasandradioButton4.Location = new Point(371, 112);
            tunasandradioButton4.Name = "tunasandradioButton4";
            tunasandradioButton4.Size = new Size(125, 27);
            tunasandradioButton4.TabIndex = 5;
            tunasandradioButton4.TabStop = true;
            tunasandradioButton4.Text = "鮪魚三明治";
            tunasandradioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(371, 180);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(125, 27);
            radioButton5.TabIndex = 6;
            radioButton5.TabStop = true;
            radioButton5.Text = "火腿三明治";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // jellysandradioButton
            // 
            jellysandradioButton.AutoSize = true;
            jellysandradioButton.Location = new Point(371, 247);
            jellysandradioButton.Name = "jellysandradioButton";
            jellysandradioButton.Size = new Size(125, 27);
            jellysandradioButton.TabIndex = 7;
            jellysandradioButton.TabStop = true;
            jellysandradioButton.Text = "果醬三明治";
            jellysandradioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(46, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(168, 373);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "飲料";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button1
            // 
            button1.Location = new Point(6, 316);
            button1.Name = "button1";
            button1.Size = new Size(162, 26);
            button1.TabIndex = 10;
            button1.Text = "送出訂單";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(342, 46);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(164, 373);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "三明治";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(0, 316);
            button2.Name = "button2";
            button2.Size = new Size(162, 26);
            button2.TabIndex = 11;
            button2.Text = "離開";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(jellysandradioButton);
            Controls.Add(radioButton5);
            Controls.Add(tunasandradioButton4);
            Controls.Add(juiceradioButton4);
            Controls.Add(redteaRADIObUTTON);
            Controls.Add(milktearadioButton2);
            Controls.Add(progressBar1);
            Controls.Add(coffeeradioButton);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton coffeeradioButton;
        private ProgressBar progressBar1;
        private RadioButton milktearadioButton2;
        private RadioButton redteaRADIObUTTON;
        private RadioButton juiceradioButton4;
        private RadioButton tunasandradioButton4;
        private RadioButton radioButton5;
        private RadioButton jellysandradioButton;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
    }
}
