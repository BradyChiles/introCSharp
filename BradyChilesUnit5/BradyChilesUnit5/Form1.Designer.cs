namespace BradyChilesUnit5
{
    partial class Form1
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
            this.btnGuess = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGuess
            // 
            this.btnGuess.Location = new System.Drawing.Point(58, 116);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(64, 34);
            this.btnGuess.TabIndex = 0;
            this.btnGuess.Text = "&Guess!";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.Location = new System.Drawing.Point(55, 35);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(165, 37);
            this.lblGuess.TabIndex = 1;
            this.lblGuess.Tag = "G";
            this.lblGuess.Text = "Guess a number: 1-100";
            this.lblGuess.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtGuess
            // 
            this.txtGuess.Location = new System.Drawing.Point(83, 75);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(100, 22);
            this.txtGuess.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(156, 116);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(64, 34);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.Location = new System.Drawing.Point(12, 168);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(258, 42);
            this.lblResponse.TabIndex = 4;
            this.lblResponse.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnGuess;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnGuess);
            this.Name = "Form1";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuess;
        private System.Windows.Forms.Label lblGuess;
        private System.Windows.Forms.TextBox txtGuess;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblResponse;
    }
}

