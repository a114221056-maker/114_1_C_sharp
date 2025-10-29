namespace Heads_or_Tails
{
    partial class exitButton
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
            headPictureBox = new PictureBox();
            tailPictureBox = new PictureBox();
            showheadsButton = new Button();
            showtailButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)headPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tailPictureBox).BeginInit();
            SuspendLayout();
            // 
            // headPictureBox
            // 
            headPictureBox.ErrorImage = Properties.Resources.Heads1;
            headPictureBox.Image = Properties.Resources.Heads1;
            headPictureBox.InitialImage = Properties.Resources.Heads1;
            headPictureBox.Location = new Point(162, 11);
            headPictureBox.Margin = new Padding(2);
            headPictureBox.Name = "headPictureBox";
            headPictureBox.Size = new Size(235, 228);
            headPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            headPictureBox.TabIndex = 0;
            headPictureBox.TabStop = false;
            // 
            // tailPictureBox
            // 
            tailPictureBox.ErrorImage = Properties.Resources.Heads1;
            tailPictureBox.Image = Properties.Resources.Tails1;
            tailPictureBox.InitialImage = Properties.Resources.Heads1;
            tailPictureBox.Location = new Point(481, 11);
            tailPictureBox.Margin = new Padding(2);
            tailPictureBox.Name = "tailPictureBox";
            tailPictureBox.Size = new Size(235, 228);
            tailPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            tailPictureBox.TabIndex = 1;
            tailPictureBox.TabStop = false;
            tailPictureBox.Click += tailPictureBox_Click;
            // 
            // showheadsButton
            // 
            showheadsButton.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showheadsButton.Location = new Point(50, 284);
            showheadsButton.Name = "showheadsButton";
            showheadsButton.Size = new Size(253, 129);
            showheadsButton.TabIndex = 2;
            showheadsButton.Text = "Show Heads";
            showheadsButton.UseVisualStyleBackColor = true;
            showheadsButton.Click += showheadsButton_Click;
            // 
            // showtailButton
            // 
            showtailButton.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            showtailButton.Location = new Point(331, 284);
            showtailButton.Name = "showtailButton";
            showtailButton.Size = new Size(253, 129);
            showtailButton.TabIndex = 3;
            showtailButton.Text = "Show Tails";
            showtailButton.UseVisualStyleBackColor = true;
            showtailButton.Click += showtailButton_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft JhengHei UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 136);
            button1.Location = new Point(616, 284);
            button1.Name = "button1";
            button1.Size = new Size(253, 129);
            button1.TabIndex = 4;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // exitButton
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1099, 674);
            Controls.Add(button1);
            Controls.Add(showtailButton);
            Controls.Add(showheadsButton);
            Controls.Add(tailPictureBox);
            Controls.Add(headPictureBox);
            Name = "exitButton";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)headPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tailPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox headPictureBox;
        private PictureBox tailPictureBox;
        private Button showheadsButton;
        private Button showtailButton;
        private Button button1;
    }
}
