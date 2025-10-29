namespace How_much_insurance
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.buildingpriceLabel = new System.Windows.Forms.Label();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.instranceamountLabel = new System.Windows.Forms.Label();
            this.calcuateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buildingpriceLabel
            // 
            this.buildingpriceLabel.AutoSize = true;
            this.buildingpriceLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.buildingpriceLabel.Location = new System.Drawing.Point(115, 48);
            this.buildingpriceLabel.Name = "buildingpriceLabel";
            this.buildingpriceLabel.Size = new System.Drawing.Size(273, 48);
            this.buildingpriceLabel.TabIndex = 0;
            this.buildingpriceLabel.Text = "建築物價錢:";
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.outputDescriptionLabel.Location = new System.Drawing.Point(163, 151);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(225, 48);
            this.outputDescriptionLabel.TabIndex = 1;
            this.outputDescriptionLabel.Text = "保險金額:";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(301, 261);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(215, 89);
            this.clearButton.TabIndex = 3;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(546, 261);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(215, 89);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(394, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(290, 65);
            this.textBox1.TabIndex = 5;
            // 
            // instranceamountLabel
            // 
            this.instranceamountLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.instranceamountLabel.Font = new System.Drawing.Font("新細明體", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.instranceamountLabel.Location = new System.Drawing.Point(394, 149);
            this.instranceamountLabel.Name = "instranceamountLabel";
            this.instranceamountLabel.Size = new System.Drawing.Size(290, 57);
            this.instranceamountLabel.TabIndex = 6;
            this.instranceamountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calcuateButton
            // 
            this.calcuateButton.Font = new System.Drawing.Font("新細明體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calcuateButton.Location = new System.Drawing.Point(52, 261);
            this.calcuateButton.Name = "calcuateButton";
            this.calcuateButton.Size = new System.Drawing.Size(215, 89);
            this.calcuateButton.TabIndex = 7;
            this.calcuateButton.Text = "計算";
            this.calcuateButton.UseVisualStyleBackColor = true;
            this.calcuateButton.Click += new System.EventHandler(this.calcuateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.calcuateButton);
            this.Controls.Add(this.instranceamountLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.buildingpriceLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buildingpriceLabel;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label instranceamountLabel;
        private System.Windows.Forms.Button calcuateButton;
    }
}

