namespace Cookie_Calories
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.cookiequailtyLabel = new System.Windows.Forms.Label();
            this.burncaloriesLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.calculateButton.Location = new System.Drawing.Point(349, 591);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(255, 165);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.clearButton.Location = new System.Drawing.Point(639, 591);
            this.clearButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(255, 166);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("微軟正黑體", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.exitButton.Location = new System.Drawing.Point(966, 590);
            this.exitButton.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(255, 166);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // cookiequailtyLabel
            // 
            this.cookiequailtyLabel.AutoSize = true;
            this.cookiequailtyLabel.Font = new System.Drawing.Font("華康標楷體外字集", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.cookiequailtyLabel.Location = new System.Drawing.Point(385, 235);
            this.cookiequailtyLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.cookiequailtyLabel.Name = "cookiequailtyLabel";
            this.cookiequailtyLabel.Size = new System.Drawing.Size(263, 60);
            this.cookiequailtyLabel.TabIndex = 3;
            this.cookiequailtyLabel.Text = "餅乾數量:";
            // 
            // burncaloriesLabel
            // 
            this.burncaloriesLabel.AutoSize = true;
            this.burncaloriesLabel.Font = new System.Drawing.Font("華康標楷體外字集", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.burncaloriesLabel.Location = new System.Drawing.Point(341, 381);
            this.burncaloriesLabel.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.burncaloriesLabel.Name = "burncaloriesLabel";
            this.burncaloriesLabel.Size = new System.Drawing.Size(315, 60);
            this.burncaloriesLabel.TabIndex = 4;
            this.burncaloriesLabel.Text = "消耗卡路里:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("微軟正黑體", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(675, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(367, 71);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(675, 381);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(367, 71);
            this.label1.TabIndex = 6;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 44F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2195, 1256);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.burncaloriesLabel);
            this.Controls.Add(this.cookiequailtyLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Font = new System.Drawing.Font("華康標楷體外字集", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label cookiequailtyLabel;
        private System.Windows.Forms.Label burncaloriesLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

