namespace Card_identifier_application
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
            cardeightPictureBox = new PictureBox();
            cardtwoPictureBox = new PictureBox();
            cardkPictureBox = new PictureBox();
            cardaPictureBox = new PictureBox();
            cardjokerPictureBox = new PictureBox();
            exitButton = new Button();
            shownnameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)cardeightPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardtwoPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardkPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardaPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardjokerPictureBox).BeginInit();
            SuspendLayout();
            // 
            // cardeightPictureBox
            // 
            cardeightPictureBox.Image = Properties.Resources._8_Diamonds;
            cardeightPictureBox.Location = new Point(64, 12);
            cardeightPictureBox.Name = "cardeightPictureBox";
            cardeightPictureBox.Size = new Size(231, 380);
            cardeightPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardeightPictureBox.TabIndex = 0;
            cardeightPictureBox.TabStop = false;
            cardeightPictureBox.Click += cardeightPictureBox_Click;
            // 
            // cardtwoPictureBox
            // 
            cardtwoPictureBox.Image = Properties.Resources._2_Clubs;
            cardtwoPictureBox.Location = new Point(335, 12);
            cardtwoPictureBox.Name = "cardtwoPictureBox";
            cardtwoPictureBox.Size = new Size(203, 380);
            cardtwoPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardtwoPictureBox.TabIndex = 1;
            cardtwoPictureBox.TabStop = false;
            cardtwoPictureBox.Click += cardtwoPictureBox_Click;
            // 
            // cardkPictureBox
            // 
            cardkPictureBox.Image = Properties.Resources.King_Spades1;
            cardkPictureBox.Location = new Point(608, 12);
            cardkPictureBox.Name = "cardkPictureBox";
            cardkPictureBox.Size = new Size(215, 380);
            cardkPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardkPictureBox.TabIndex = 2;
            cardkPictureBox.TabStop = false;
            cardkPictureBox.Click += cardkPictureBox_Click;
            // 
            // cardaPictureBox
            // 
            cardaPictureBox.Image = Properties.Resources.Ace_Spades;
            cardaPictureBox.Location = new Point(866, 12);
            cardaPictureBox.Name = "cardaPictureBox";
            cardaPictureBox.Size = new Size(211, 380);
            cardaPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardaPictureBox.TabIndex = 3;
            cardaPictureBox.TabStop = false;
            cardaPictureBox.Click += cardaPictureBox_Click;
            // 
            // cardjokerPictureBox
            // 
            cardjokerPictureBox.Image = Properties.Resources.Joker_Black;
            cardjokerPictureBox.Location = new Point(1117, 12);
            cardjokerPictureBox.Name = "cardjokerPictureBox";
            cardjokerPictureBox.Size = new Size(227, 380);
            cardjokerPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            cardjokerPictureBox.TabIndex = 4;
            cardjokerPictureBox.TabStop = false;
            cardjokerPictureBox.Click += cardjokerPictureBox_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Microsoft JhengHei UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 136);
            exitButton.Location = new Point(338, 554);
            exitButton.Margin = new Padding(5, 5, 5, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(717, 113);
            exitButton.TabIndex = 5;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // shownnameLabel
            // 
            shownnameLabel.BorderStyle = BorderStyle.Fixed3D;
            shownnameLabel.Font = new Font("Microsoft JhengHei UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            shownnameLabel.Location = new Point(468, 428);
            shownnameLabel.Margin = new Padding(5, 0, 5, 0);
            shownnameLabel.Name = "shownnameLabel";
            shownnameLabel.Size = new Size(453, 64);
            shownnameLabel.TabIndex = 6;
            shownnameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1391, 719);
            Controls.Add(shownnameLabel);
            Controls.Add(exitButton);
            Controls.Add(cardjokerPictureBox);
            Controls.Add(cardaPictureBox);
            Controls.Add(cardkPictureBox);
            Controls.Add(cardtwoPictureBox);
            Controls.Add(cardeightPictureBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)cardeightPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardtwoPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardkPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardaPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardjokerPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardeightPictureBox;
        private PictureBox cardtwoPictureBox;
        private PictureBox cardkPictureBox;
        private PictureBox cardaPictureBox;
        private PictureBox cardjokerPictureBox;
        private Button exitButton;
        private Label shownnameLabel;
    }
}
