namespace WordQuiz
{
    partial class Main
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
            this.lblVerticalSplitter = new System.Windows.Forms.Label();
            this.lblUnits = new System.Windows.Forms.Label();
            this.clbUnits = new System.Windows.Forms.CheckedListBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.lblEnglishOutput = new System.Windows.Forms.Label();
            this.tbSpanishInput = new System.Windows.Forms.TextBox();
            this.btnCheck = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVerticalSplitter
            // 
            this.lblVerticalSplitter.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblVerticalSplitter.Location = new System.Drawing.Point(687, -2);
            this.lblVerticalSplitter.Name = "lblVerticalSplitter";
            this.lblVerticalSplitter.Size = new System.Drawing.Size(2, 314);
            this.lblVerticalSplitter.TabIndex = 0;
            // 
            // lblUnits
            // 
            this.lblUnits.AutoSize = true;
            this.lblUnits.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUnits.Location = new System.Drawing.Point(695, 9);
            this.lblUnits.Name = "lblUnits";
            this.lblUnits.Size = new System.Drawing.Size(59, 23);
            this.lblUnits.TabIndex = 1;
            this.lblUnits.Text = "Units";
            // 
            // clbUnits
            // 
            this.clbUnits.FormattingEnabled = true;
            this.clbUnits.Location = new System.Drawing.Point(699, 44);
            this.clbUnits.Name = "clbUnits";
            this.clbUnits.Size = new System.Drawing.Size(237, 191);
            this.clbUnits.TabIndex = 2;
            // 
            // btnStartGame
            // 
            this.btnStartGame.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartGame.Location = new System.Drawing.Point(746, 258);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(146, 35);
            this.btnStartGame.TabIndex = 3;
            this.btnStartGame.Text = "Start Game";
            this.btnStartGame.UseVisualStyleBackColor = true;
            // 
            // lblEnglishOutput
            // 
            this.lblEnglishOutput.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblEnglishOutput.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblEnglishOutput.Location = new System.Drawing.Point(86, 24);
            this.lblEnglishOutput.Name = "lblEnglishOutput";
            this.lblEnglishOutput.Size = new System.Drawing.Size(514, 42);
            this.lblEnglishOutput.TabIndex = 1;
            this.lblEnglishOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEnglishOutput.Visible = false;
            // 
            // tbSpanishInput
            // 
            this.tbSpanishInput.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbSpanishInput.Location = new System.Drawing.Point(161, 98);
            this.tbSpanishInput.Name = "tbSpanishInput";
            this.tbSpanishInput.Size = new System.Drawing.Size(339, 32);
            this.tbSpanishInput.TabIndex = 4;
            this.tbSpanishInput.Visible = false;
            // 
            // btnCheck
            // 
            this.btnCheck.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCheck.Location = new System.Drawing.Point(267, 162);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(146, 35);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Visible = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 305);
            this.Controls.Add(this.tbSpanishInput);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.clbUnits);
            this.Controls.Add(this.lblEnglishOutput);
            this.Controls.Add(this.lblUnits);
            this.Controls.Add(this.lblVerticalSplitter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Main";
            this.Text = "WordQuiz";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVerticalSplitter;
        private System.Windows.Forms.Label lblUnits;
        private System.Windows.Forms.CheckedListBox clbUnits;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.Label lblEnglishOutput;
        private System.Windows.Forms.TextBox tbSpanishInput;
        private System.Windows.Forms.Button btnCheck;
    }
}

