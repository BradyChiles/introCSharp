namespace BradyChilesUnit9
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
            this.lblPleaseEnter = new System.Windows.Forms.Label();
            this.lblEnterYear = new System.Windows.Forms.Label();
            this.lblEnterMake = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnAccelerate = new System.Windows.Forms.Button();
            this.btnBrake = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPleaseEnter
            // 
            this.lblPleaseEnter.AutoSize = true;
            this.lblPleaseEnter.Location = new System.Drawing.Point(81, 66);
            this.lblPleaseEnter.Name = "lblPleaseEnter";
            this.lblPleaseEnter.Size = new System.Drawing.Size(93, 17);
            this.lblPleaseEnter.TabIndex = 0;
            this.lblPleaseEnter.Text = "Please Enter:";
            // 
            // lblEnterYear
            // 
            this.lblEnterYear.AutoSize = true;
            this.lblEnterYear.Location = new System.Drawing.Point(90, 102);
            this.lblEnterYear.Name = "lblEnterYear";
            this.lblEnterYear.Size = new System.Drawing.Size(42, 17);
            this.lblEnterYear.TabIndex = 1;
            this.lblEnterYear.Text = "Year:";
            // 
            // lblEnterMake
            // 
            this.lblEnterMake.AutoSize = true;
            this.lblEnterMake.Location = new System.Drawing.Point(90, 137);
            this.lblEnterMake.Name = "lblEnterMake";
            this.lblEnterMake.Size = new System.Drawing.Size(46, 17);
            this.lblEnterMake.TabIndex = 2;
            this.lblEnterMake.Text = "Make:";
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(179, 102);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(179, 137);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 22);
            this.txtMake.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(81, 201);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(42, 17);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Year:";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(81, 231);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(46, 17);
            this.lblMake.TabIndex = 8;
            this.lblMake.Text = "Make:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(81, 260);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(104, 17);
            this.lblSpeed.TabIndex = 9;
            this.lblSpeed.Text = "Current Speed:";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(317, 86);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(90, 88);
            this.btnCreate.TabIndex = 10;
            this.btnCreate.Text = "&Create Car";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnAccelerate
            // 
            this.btnAccelerate.Location = new System.Drawing.Point(248, 201);
            this.btnAccelerate.Name = "btnAccelerate";
            this.btnAccelerate.Size = new System.Drawing.Size(99, 76);
            this.btnAccelerate.TabIndex = 11;
            this.btnAccelerate.Text = "&Accelerate";
            this.btnAccelerate.UseVisualStyleBackColor = true;
            this.btnAccelerate.Click += new System.EventHandler(this.btnAccelerate_Click);
            // 
            // btnBrake
            // 
            this.btnBrake.Location = new System.Drawing.Point(353, 201);
            this.btnBrake.Name = "btnBrake";
            this.btnBrake.Size = new System.Drawing.Size(97, 76);
            this.btnBrake.TabIndex = 12;
            this.btnBrake.Text = "&Brake";
            this.btnBrake.UseVisualStyleBackColor = true;
            this.btnBrake.Click += new System.EventHandler(this.btnBrake_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(300, 283);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 47);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCreate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(485, 342);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBrake);
            this.Controls.Add(this.btnAccelerate);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblMake);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtMake);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblEnterMake);
            this.Controls.Add(this.lblEnterYear);
            this.Controls.Add(this.lblPleaseEnter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPleaseEnter;
        private System.Windows.Forms.Label lblEnterYear;
        private System.Windows.Forms.Label lblEnterMake;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnAccelerate;
        private System.Windows.Forms.Button btnBrake;
        private System.Windows.Forms.Button btnExit;
    }
}

