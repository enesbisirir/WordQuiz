namespace WordQuiz
{
    partial class FrmGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblVerticalSplitter = new System.Windows.Forms.Label();
            this.LblUnits = new System.Windows.Forms.Label();
            this.ClbUnits = new System.Windows.Forms.CheckedListBox();
            this.BtnStartGame = new System.Windows.Forms.Button();
            this.LblEnglishOutput = new System.Windows.Forms.Label();
            this.TbSpanishInput = new System.Windows.Forms.TextBox();
            this.BtnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblVerticalSplitter
            // 
            this.LblVerticalSplitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblVerticalSplitter.Location = new System.Drawing.Point(687, -2);
            this.LblVerticalSplitter.Name = "LblVerticalSplitter";
            this.LblVerticalSplitter.Size = new System.Drawing.Size(2, 314);
            this.LblVerticalSplitter.TabIndex = 0;
            // 
            // LblUnits
            // 
            this.LblUnits.AutoSize = true;
            this.LblUnits.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblUnits.Location = new System.Drawing.Point(695, 9);
            this.LblUnits.Name = "LblUnits";
            this.LblUnits.Size = new System.Drawing.Size(59, 23);
            this.LblUnits.TabIndex = 1;
            this.LblUnits.Text = "Units";
            // 
            // ClbUnits
            // 
            this.ClbUnits.FormattingEnabled = true;
            this.ClbUnits.Location = new System.Drawing.Point(699, 44);
            this.ClbUnits.Name = "ClbUnits";
            this.ClbUnits.Size = new System.Drawing.Size(237, 191);
            this.ClbUnits.TabIndex = 2;
            // 
            // BtnStartGame
            // 
            this.BtnStartGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnStartGame.Location = new System.Drawing.Point(746, 258);
            this.BtnStartGame.Name = "BtnStartGame";
            this.BtnStartGame.Size = new System.Drawing.Size(146, 35);
            this.BtnStartGame.TabIndex = 3;
            this.BtnStartGame.Text = "Start Game";
            this.BtnStartGame.UseVisualStyleBackColor = true;
            this.BtnStartGame.Click += new System.EventHandler(this.BtnStartGame_Click);
            // 
            // LblEnglishOutput
            // 
            this.LblEnglishOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.LblEnglishOutput.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblEnglishOutput.Location = new System.Drawing.Point(86, 24);
            this.LblEnglishOutput.Name = "LblEnglishOutput";
            this.LblEnglishOutput.Size = new System.Drawing.Size(514, 42);
            this.LblEnglishOutput.TabIndex = 1;
            this.LblEnglishOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TbSpanishInput
            // 
            this.TbSpanishInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TbSpanishInput.Location = new System.Drawing.Point(161, 98);
            this.TbSpanishInput.Name = "TbSpanishInput";
            this.TbSpanishInput.Size = new System.Drawing.Size(339, 32);
            this.TbSpanishInput.TabIndex = 4;
            // 
            // BtnCheck
            // 
            this.BtnCheck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnCheck.Location = new System.Drawing.Point(267, 162);
            this.BtnCheck.Name = "BtnCheck";
            this.BtnCheck.Size = new System.Drawing.Size(146, 35);
            this.BtnCheck.TabIndex = 3;
            this.BtnCheck.Text = "Check";
            this.BtnCheck.UseVisualStyleBackColor = true;
            this.BtnCheck.Click += new System.EventHandler(this.BtnCheck_Click);
            // 
            // FrmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 305);
            this.Controls.Add(this.TbSpanishInput);
            this.Controls.Add(this.BtnCheck);
            this.Controls.Add(this.BtnStartGame);
            this.Controls.Add(this.ClbUnits);
            this.Controls.Add(this.LblEnglishOutput);
            this.Controls.Add(this.LblUnits);
            this.Controls.Add(this.LblVerticalSplitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGame";
            this.Text = "WordQuiz";
            this.Load += new System.EventHandler(this.FrmGame_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblVerticalSplitter;
        private System.Windows.Forms.Label LblUnits;
        private System.Windows.Forms.CheckedListBox ClbUnits;
        private System.Windows.Forms.Button BtnStartGame;
        private System.Windows.Forms.Label LblEnglishOutput;
        private System.Windows.Forms.TextBox TbSpanishInput;
        private System.Windows.Forms.Button BtnCheck;
    }
}

