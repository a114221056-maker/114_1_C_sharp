namespace tutorial2_4
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
            label1 = new Label();
            countryLabel = new Label();
            finlandPictureBox = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(229, 74);
            label1.Name = "label1";
            label1.Size = new Size(370, 41);
            label1.TabIndex = 0;
            label1.Text = "點選國旗會出現國家名稱";
            // 
            // countryLabel
            // 
            countryLabel.BorderStyle = BorderStyle.Fixed3D;
            countryLabel.Font = new System.Drawing.Font("Microsoft JhengHei", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            countryLabel.Location = new Point(188, 302);
            countryLabel.Name = "countryLabel";
            countryLabel.Size = new Size(489, 85);
            countryLabel.TabIndex = 1;
            countryLabel.TextAlign = ContentAlignment.MiddleCenter;
            countryLabel.Click += countryLabel_Click;
            // 
            // finlandPictureBox
            // 
            finlandPictureBox.Image = (Image)resources.GetObject("finlandPictureBox.Image");
            finlandPictureBox.Location = new Point(38, 141);
            finlandPictureBox.Name = "finlandPictureBox";
            finlandPictureBox.Size = new Size(211, 138);
            finlandPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            finlandPictureBox.TabIndex = 2;
            finlandPictureBox.TabStop = false;
            finlandPictureBox.Click += finlandPictureBox_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(299, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 138);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(557, 141);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(211, 138);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(finlandPictureBox);
            Controls.Add(countryLabel);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)finlandPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label countryLabel;
        private PictureBox finlandPictureBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
