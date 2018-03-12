namespace BradyChilesUnit2
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnHeads = new System.Windows.Forms.Button();
            this.btnTails = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.picHeads = new System.Windows.Forms.PictureBox();
            this.picTails = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHeads
            // 
            this.btnHeads.Location = new System.Drawing.Point(106, 164);
            this.btnHeads.Name = "btnHeads";
            this.btnHeads.Size = new System.Drawing.Size(120, 54);
            this.btnHeads.TabIndex = 0;
            this.btnHeads.Text = "Show &Heads";
            this.btnHeads.UseVisualStyleBackColor = true;
            this.btnHeads.Click += new System.EventHandler(this.btnHeads_Click);
            // 
            // btnTails
            // 
            this.btnTails.Location = new System.Drawing.Point(254, 164);
            this.btnTails.Name = "btnTails";
            this.btnTails.Size = new System.Drawing.Size(120, 54);
            this.btnTails.TabIndex = 1;
            this.btnTails.Text = "Show &Tails";
            this.btnTails.UseVisualStyleBackColor = true;
            this.btnTails.Click += new System.EventHandler(this.btnTails_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(402, 164);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 54);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picHeads
            // 
            this.picHeads.Image = ((System.Drawing.Image)(resources.GetObject("picHeads.Image")));
            this.picHeads.InitialImage = ((System.Drawing.Image)(resources.GetObject("picHeads.InitialImage")));
            this.picHeads.Location = new System.Drawing.Point(170, 23);
            this.picHeads.Name = "picHeads";
            this.picHeads.Size = new System.Drawing.Size(120, 96);
            this.picHeads.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picHeads.TabIndex = 3;
            this.picHeads.TabStop = false;
            this.picHeads.Visible = false;
            // 
            // picTails
            // 
            this.picTails.Image = ((System.Drawing.Image)(resources.GetObject("picTails.Image")));
            this.picTails.InitialImage = ((System.Drawing.Image)(resources.GetObject("picTails.InitialImage")));
            this.picTails.Location = new System.Drawing.Point(334, 23);
            this.picTails.Name = "picTails";
            this.picTails.Size = new System.Drawing.Size(120, 96);
            this.picTails.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTails.TabIndex = 4;
            this.picTails.TabStop = false;
            this.picTails.Visible = false;
            // 
            // frmMain
            // 
            this.AcceptButton = this.btnHeads;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(606, 284);
            this.Controls.Add(this.picTails);
            this.Controls.Add(this.picHeads);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTails);
            this.Controls.Add(this.btnHeads);
            this.Name = "frmMain";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.picHeads)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTails)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHeads;
        private System.Windows.Forms.Button btnTails;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox picHeads;
        private System.Windows.Forms.PictureBox picTails;
    }
}

