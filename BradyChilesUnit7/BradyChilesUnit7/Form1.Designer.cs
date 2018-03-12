namespace BradyChilesUnit7
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
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTopLeft = new System.Windows.Forms.Label();
            this.lblTopMiddle = new System.Windows.Forms.Label();
            this.lblTopRight = new System.Windows.Forms.Label();
            this.lblMiddleLeft = new System.Windows.Forms.Label();
            this.lblMiddleMiddle = new System.Windows.Forms.Label();
            this.lblMiddleRight = new System.Windows.Forms.Label();
            this.lblBottomLeft = new System.Windows.Forms.Label();
            this.lblBottomMiddle = new System.Windows.Forms.Label();
            this.lblBottomRight = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNewGame
            // 
            this.btnNewGame.Location = new System.Drawing.Point(138, 519);
            this.btnNewGame.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(171, 66);
            this.btnNewGame.TabIndex = 0;
            this.btnNewGame.Text = "&New Game!";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(367, 519);
            this.btnExit.Margin = new System.Windows.Forms.Padding(5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 66);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTopLeft
            // 
            this.lblTopLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopLeft.Location = new System.Drawing.Point(115, 47);
            this.lblTopLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTopLeft.Name = "lblTopLeft";
            this.lblTopLeft.Size = new System.Drawing.Size(128, 113);
            this.lblTopLeft.TabIndex = 2;
            this.lblTopLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopMiddle
            // 
            this.lblTopMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopMiddle.Location = new System.Drawing.Point(276, 47);
            this.lblTopMiddle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTopMiddle.Name = "lblTopMiddle";
            this.lblTopMiddle.Size = new System.Drawing.Size(128, 113);
            this.lblTopMiddle.TabIndex = 3;
            this.lblTopMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTopRight
            // 
            this.lblTopRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTopRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopRight.Location = new System.Drawing.Point(441, 47);
            this.lblTopRight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTopRight.Name = "lblTopRight";
            this.lblTopRight.Size = new System.Drawing.Size(128, 113);
            this.lblTopRight.TabIndex = 4;
            this.lblTopRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiddleLeft
            // 
            this.lblMiddleLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiddleLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleLeft.Location = new System.Drawing.Point(115, 184);
            this.lblMiddleLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleLeft.Name = "lblMiddleLeft";
            this.lblMiddleLeft.Size = new System.Drawing.Size(128, 113);
            this.lblMiddleLeft.TabIndex = 5;
            this.lblMiddleLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiddleMiddle
            // 
            this.lblMiddleMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiddleMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleMiddle.Location = new System.Drawing.Point(276, 184);
            this.lblMiddleMiddle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleMiddle.Name = "lblMiddleMiddle";
            this.lblMiddleMiddle.Size = new System.Drawing.Size(128, 113);
            this.lblMiddleMiddle.TabIndex = 6;
            this.lblMiddleMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMiddleRight
            // 
            this.lblMiddleRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMiddleRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiddleRight.Location = new System.Drawing.Point(441, 184);
            this.lblMiddleRight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMiddleRight.Name = "lblMiddleRight";
            this.lblMiddleRight.Size = new System.Drawing.Size(128, 113);
            this.lblMiddleRight.TabIndex = 7;
            this.lblMiddleRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomLeft
            // 
            this.lblBottomLeft.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomLeft.Location = new System.Drawing.Point(115, 320);
            this.lblBottomLeft.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBottomLeft.Name = "lblBottomLeft";
            this.lblBottomLeft.Size = new System.Drawing.Size(128, 113);
            this.lblBottomLeft.TabIndex = 8;
            this.lblBottomLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomMiddle
            // 
            this.lblBottomMiddle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomMiddle.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomMiddle.Location = new System.Drawing.Point(276, 320);
            this.lblBottomMiddle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBottomMiddle.Name = "lblBottomMiddle";
            this.lblBottomMiddle.Size = new System.Drawing.Size(128, 113);
            this.lblBottomMiddle.TabIndex = 9;
            this.lblBottomMiddle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBottomRight
            // 
            this.lblBottomRight.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBottomRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottomRight.Location = new System.Drawing.Point(441, 320);
            this.lblBottomRight.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblBottomRight.Name = "lblBottomRight";
            this.lblBottomRight.Size = new System.Drawing.Size(128, 113);
            this.lblBottomRight.TabIndex = 10;
            this.lblBottomRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(222, 458);
            this.lblResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(244, 38);
            this.lblResult.TabIndex = 11;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnNewGame;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(666, 595);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblBottomRight);
            this.Controls.Add(this.lblBottomMiddle);
            this.Controls.Add(this.lblBottomLeft);
            this.Controls.Add(this.lblMiddleRight);
            this.Controls.Add(this.lblMiddleMiddle);
            this.Controls.Add(this.lblMiddleLeft);
            this.Controls.Add(this.lblTopRight);
            this.Controls.Add(this.lblTopMiddle);
            this.Controls.Add(this.lblTopLeft);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnNewGame);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form1";
            this.Text = "Tic-Tac-Toe";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTopLeft;
        private System.Windows.Forms.Label lblTopMiddle;
        private System.Windows.Forms.Label lblTopRight;
        private System.Windows.Forms.Label lblMiddleLeft;
        private System.Windows.Forms.Label lblMiddleMiddle;
        private System.Windows.Forms.Label lblMiddleRight;
        private System.Windows.Forms.Label lblBottomLeft;
        private System.Windows.Forms.Label lblBottomMiddle;
        private System.Windows.Forms.Label lblBottomRight;
        private System.Windows.Forms.Label lblResult;
    }
}

