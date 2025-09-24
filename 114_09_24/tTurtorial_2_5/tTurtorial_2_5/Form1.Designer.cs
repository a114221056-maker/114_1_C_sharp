namespace tTurtorial_2_5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            cardFacepictureBox = new PictureBox();
            cardBack = new PictureBox();
            showBackButton = new Button();
            showFaceButton = new Button();
            ((System.ComponentModel.ISupportInitialize)cardFacepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cardBack).BeginInit();
            SuspendLayout();
            // 
            // cardFacepictureBox
            // 
            cardFacepictureBox.Image = (Image)resources.GetObject("cardFacepictureBox.Image");
            cardFacepictureBox.Location = new Point(540, 27);
            cardFacepictureBox.Name = "cardFacepictureBox";
            cardFacepictureBox.Size = new Size(210, 306);
            cardFacepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            cardFacepictureBox.TabIndex = 0;
            cardFacepictureBox.TabStop = false;
            cardFacepictureBox.Visible = false;
            cardFacepictureBox.Click += cardFacepictureBox_Click;
            // 
            // cardBack
            // 
            cardBack.Image = (Image)resources.GetObject("cardBack.Image");
            cardBack.Location = new Point(79, 27);
            cardBack.Name = "cardBack";
            cardBack.Size = new Size(210, 306);
            cardBack.SizeMode = PictureBoxSizeMode.StretchImage;
            cardBack.TabIndex = 1;
            cardBack.TabStop = false;
            cardBack.Visible = false;
            cardBack.Click += cardBack_Click;
            // 
            // showBackButton
            // 
            showBackButton.Location = new Point(113, 371);
            showBackButton.Name = "showBackButton";
            showBackButton.Size = new Size(134, 46);
            showBackButton.TabIndex = 2;
            showBackButton.Text = "顯示背面";
            showBackButton.UseVisualStyleBackColor = true;
            showBackButton.Click += showBackButton_Click;
            // 
            // showFaceButton
            // 
            showFaceButton.Location = new Point(577, 371);
            showFaceButton.Name = "showFaceButton";
            showFaceButton.Size = new Size(134, 46);
            showFaceButton.TabIndex = 3;
            showFaceButton.Text = "顯示正面";
            showFaceButton.UseVisualStyleBackColor = true;
            showFaceButton.Click += showFaceButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(showFaceButton);
            Controls.Add(showBackButton);
            Controls.Add(cardBack);
            Controls.Add(cardFacepictureBox);
            Name = "Form1";
            Text = "翻轉撲克牌";
            ((System.ComponentModel.ISupportInitialize)cardFacepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)cardBack).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox cardFacepictureBox;
        private PictureBox cardBack;
        private Button showBackButton;
        private Button showFaceButton;
    }
}
