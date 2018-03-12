namespace BradyChilesUnit6
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
            this.lblNumDays = new System.Windows.Forms.Label();
            this.lblMedCharges = new System.Windows.Forms.Label();
            this.lblSurgery = new System.Windows.Forms.Label();
            this.lblLab = new System.Windows.Forms.Label();
            this.lblPhysRehab = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtLab = new System.Windows.Forms.TextBox();
            this.txtMed = new System.Windows.Forms.TextBox();
            this.txtSurgery = new System.Windows.Forms.TextBox();
            this.txtRehab = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblStay = new System.Windows.Forms.Label();
            this.lblMisc = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNumDays
            // 
            this.lblNumDays.AutoSize = true;
            this.lblNumDays.Location = new System.Drawing.Point(51, 38);
            this.lblNumDays.Name = "lblNumDays";
            this.lblNumDays.Size = new System.Drawing.Size(112, 17);
            this.lblNumDays.TabIndex = 0;
            this.lblNumDays.Text = "Number of days:";
            // 
            // lblMedCharges
            // 
            this.lblMedCharges.AutoSize = true;
            this.lblMedCharges.Location = new System.Drawing.Point(51, 70);
            this.lblMedCharges.Name = "lblMedCharges";
            this.lblMedCharges.Size = new System.Drawing.Size(135, 17);
            this.lblMedCharges.TabIndex = 1;
            this.lblMedCharges.Text = "Medication charges:";
            // 
            // lblSurgery
            // 
            this.lblSurgery.AutoSize = true;
            this.lblSurgery.Location = new System.Drawing.Point(51, 104);
            this.lblSurgery.Name = "lblSurgery";
            this.lblSurgery.Size = new System.Drawing.Size(118, 17);
            this.lblSurgery.TabIndex = 2;
            this.lblSurgery.Text = "Surgical charges:";
            // 
            // lblLab
            // 
            this.lblLab.AutoSize = true;
            this.lblLab.Location = new System.Drawing.Point(51, 138);
            this.lblLab.Name = "lblLab";
            this.lblLab.Size = new System.Drawing.Size(67, 17);
            this.lblLab.TabIndex = 3;
            this.lblLab.Text = "Lab fees:";
            // 
            // lblPhysRehab
            // 
            this.lblPhysRehab.AutoSize = true;
            this.lblPhysRehab.Location = new System.Drawing.Point(51, 172);
            this.lblPhysRehab.Name = "lblPhysRehab";
            this.lblPhysRehab.Size = new System.Drawing.Size(160, 17);
            this.lblPhysRehab.TabIndex = 4;
            this.lblPhysRehab.Text = "Physical rehab charges:";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(213, 38);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(100, 22);
            this.txtDays.TabIndex = 5;
            // 
            // txtLab
            // 
            this.txtLab.Location = new System.Drawing.Point(213, 138);
            this.txtLab.Name = "txtLab";
            this.txtLab.Size = new System.Drawing.Size(100, 22);
            this.txtLab.TabIndex = 6;
            // 
            // txtMed
            // 
            this.txtMed.Location = new System.Drawing.Point(213, 70);
            this.txtMed.Name = "txtMed";
            this.txtMed.Size = new System.Drawing.Size(100, 22);
            this.txtMed.TabIndex = 7;
            // 
            // txtSurgery
            // 
            this.txtSurgery.Location = new System.Drawing.Point(213, 104);
            this.txtSurgery.Name = "txtSurgery";
            this.txtSurgery.Size = new System.Drawing.Size(100, 22);
            this.txtSurgery.TabIndex = 8;
            // 
            // txtRehab
            // 
            this.txtRehab.Location = new System.Drawing.Point(213, 172);
            this.txtRehab.Name = "txtRehab";
            this.txtRehab.Size = new System.Drawing.Size(100, 22);
            this.txtRehab.TabIndex = 9;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(220, 309);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 59);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(92, 274);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(44, 17);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(12, 309);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(94, 59);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblStay
            // 
            this.lblStay.AutoSize = true;
            this.lblStay.Location = new System.Drawing.Point(92, 209);
            this.lblStay.Name = "lblStay";
            this.lblStay.Size = new System.Drawing.Size(40, 17);
            this.lblStay.TabIndex = 16;
            this.lblStay.Text = "Stay:";
            // 
            // lblMisc
            // 
            this.lblMisc.AutoSize = true;
            this.lblMisc.Location = new System.Drawing.Point(92, 240);
            this.lblMisc.Name = "lblMisc";
            this.lblMisc.Size = new System.Drawing.Size(40, 17);
            this.lblMisc.TabIndex = 17;
            this.lblMisc.Text = "Misc:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(117, 309);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(94, 59);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(326, 391);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblMisc);
            this.Controls.Add(this.lblStay);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtRehab);
            this.Controls.Add(this.txtSurgery);
            this.Controls.Add(this.txtMed);
            this.Controls.Add(this.txtLab);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblPhysRehab);
            this.Controls.Add(this.lblLab);
            this.Controls.Add(this.lblSurgery);
            this.Controls.Add(this.lblMedCharges);
            this.Controls.Add(this.lblNumDays);
            this.Name = "Form1";
            this.Text = "Medical Charges";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumDays;
        private System.Windows.Forms.Label lblMedCharges;
        private System.Windows.Forms.Label lblSurgery;
        private System.Windows.Forms.Label lblLab;
        private System.Windows.Forms.Label lblPhysRehab;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtLab;
        private System.Windows.Forms.TextBox txtMed;
        private System.Windows.Forms.TextBox txtSurgery;
        private System.Windows.Forms.TextBox txtRehab;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblStay;
        private System.Windows.Forms.Label lblMisc;
        private System.Windows.Forms.Button btnClear;
    }
}

