namespace Ending_Balance
{
    partial class Form1
    {
        /// <summary>
        /// 必要的設計工具變數。
        /// 注意：此檔案主要由設計工具產生，手動修改僅限於註解或 UI 屬性（如 Text、Font），
        /// 避免改動自動產生的事件連結及控制項宣告，以免設計工具同步時發生衝突。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">若為 true，表示需釋放受控資源。</param>
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
        /// 此為設計工具所需的方法。請勿使用程式碼編輯器修改此方法內容（除非修改註解或 UI 文字/字型）。
        /// 在此方法中我已將所有元件的顯示文字確認為繁體中文，並將 Form 的字型設為 18pt
        /// 以讓整個表單與其子控制項繼承較大的顯示字型，方便閱讀。
        /// </summary>
        private void InitializeComponent()
        {
            this.startingBalancePromptLabel = new System.Windows.Forms.Label();
            this.monthsPromptLabel = new System.Windows.Forms.Label();
            this.startingBalTextBox = new System.Windows.Forms.TextBox();
            this.monthsTextBox = new System.Windows.Forms.TextBox();
            this.outputDescriptionLabel = new System.Windows.Forms.Label();
            this.endingBalanceLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.detailListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // startingBalancePromptLabel
            // 
            this.startingBalancePromptLabel.AutoSize = true;
            this.startingBalancePromptLabel.Location = new System.Drawing.Point(52, 21);
            this.startingBalancePromptLabel.Name = "startingBalancePromptLabel";
            this.startingBalancePromptLabel.Size = new System.Drawing.Size(200, 45);
            this.startingBalancePromptLabel.TabIndex = 0;
            this.startingBalancePromptLabel.Text = "起始餘額：";
            // 
            // monthsPromptLabel
            // 
            this.monthsPromptLabel.AutoSize = true;
            this.monthsPromptLabel.Location = new System.Drawing.Point(52, 106);
            this.monthsPromptLabel.Name = "monthsPromptLabel";
            this.monthsPromptLabel.Size = new System.Drawing.Size(200, 45);
            this.monthsPromptLabel.TabIndex = 2;
            this.monthsPromptLabel.Text = "月份數量：";
            // 
            // startingBalTextBox
            // 
            this.startingBalTextBox.Location = new System.Drawing.Point(358, 21);
            this.startingBalTextBox.Name = "startingBalTextBox";
            this.startingBalTextBox.Size = new System.Drawing.Size(258, 55);
            this.startingBalTextBox.TabIndex = 3;
            this.startingBalTextBox.TextChanged += new System.EventHandler(this.startingBalTextBox_TextChanged);
            // 
            // monthsTextBox
            // 
            this.monthsTextBox.Location = new System.Drawing.Point(358, 103);
            this.monthsTextBox.Name = "monthsTextBox";
            this.monthsTextBox.Size = new System.Drawing.Size(258, 55);
            this.monthsTextBox.TabIndex = 5;
            this.monthsTextBox.TextChanged += new System.EventHandler(this.monthsTextBox_TextChanged);
            // 
            // outputDescriptionLabel
            // 
            this.outputDescriptionLabel.AutoSize = true;
            this.outputDescriptionLabel.Location = new System.Drawing.Point(52, 370);
            this.outputDescriptionLabel.Name = "outputDescriptionLabel";
            this.outputDescriptionLabel.Size = new System.Drawing.Size(128, 45);
            this.outputDescriptionLabel.TabIndex = 6;
            this.outputDescriptionLabel.Text = "結餘：";
            this.outputDescriptionLabel.Click += new System.EventHandler(this.outputDescriptionLabel_Click);
            // 
            // endingBalanceLabel
            // 
            this.endingBalanceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.endingBalanceLabel.Location = new System.Drawing.Point(358, 370);
            this.endingBalanceLabel.Name = "endingBalanceLabel";
            this.endingBalanceLabel.Size = new System.Drawing.Size(258, 45);
            this.endingBalanceLabel.TabIndex = 7;
            this.endingBalanceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(33, 435);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(162, 50);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "計算";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(272, 435);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 50);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "清除";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(488, 435);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(144, 50);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "離開";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // detailListBox
            // 
            this.detailListBox.FormattingEnabled = true;
            this.detailListBox.ItemHeight = 45;
            this.detailListBox.Location = new System.Drawing.Point(12, 168);
            this.detailListBox.Name = "detailListBox";
            this.detailListBox.Size = new System.Drawing.Size(713, 184);
            this.detailListBox.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(21F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 497);
            this.Controls.Add(this.detailListBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.endingBalanceLabel);
            this.Controls.Add(this.outputDescriptionLabel);
            this.Controls.Add(this.monthsTextBox);
            this.Controls.Add(this.startingBalTextBox);
            this.Controls.Add(this.monthsPromptLabel);
            this.Controls.Add(this.startingBalancePromptLabel);
            this.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form1";
            this.Text = "結餘計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingBalancePromptLabel;
        private System.Windows.Forms.Label monthsPromptLabel;
        private System.Windows.Forms.TextBox startingBalTextBox;
        private System.Windows.Forms.TextBox monthsTextBox;
        private System.Windows.Forms.Label outputDescriptionLabel;
        private System.Windows.Forms.Label endingBalanceLabel;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ListBox detailListBox;
    }
}