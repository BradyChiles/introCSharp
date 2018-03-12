namespace BradyChilesUnit4
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
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.labelInput = new System.Windows.Forms.Label();
            this.grpboxResults = new System.Windows.Forms.GroupBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.lblMinutes = new System.Windows.Forms.Label();
            this.lblSeconds = new System.Windows.Forms.Label();
            this.lblDaysResults = new System.Windows.Forms.Label();
            this.lblHoursReults = new System.Windows.Forms.Label();
            this.lblMinutesResults = new System.Windows.Forms.Label();
            this.lblSecondsResults = new System.Windows.Forms.Label();
            this.grpboxResults.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(62, 355);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(97, 45);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(186, 355);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(97, 45);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clea&r";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(307, 355);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 45);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(186, 57);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(139, 22);
            this.txtInput.TabIndex = 3;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelInput
            // 
            this.labelInput.AutoSize = true;
            this.labelInput.Location = new System.Drawing.Point(59, 57);
            this.labelInput.Name = "labelInput";
            this.labelInput.Size = new System.Drawing.Size(105, 17);
            this.labelInput.TabIndex = 4;
            this.labelInput.Text = "Enter Seconds:";
            // 
            // grpboxResults
            // 
            this.grpboxResults.Controls.Add(this.lblSecondsResults);
            this.grpboxResults.Controls.Add(this.lblMinutesResults);
            this.grpboxResults.Controls.Add(this.lblHoursReults);
            this.grpboxResults.Controls.Add(this.lblDaysResults);
            this.grpboxResults.Controls.Add(this.lblSeconds);
            this.grpboxResults.Controls.Add(this.lblMinutes);
            this.grpboxResults.Controls.Add(this.lblHours);
            this.grpboxResults.Controls.Add(this.lblDays);
            this.grpboxResults.Location = new System.Drawing.Point(62, 108);
            this.grpboxResults.Name = "grpboxResults";
            this.grpboxResults.Size = new System.Drawing.Size(304, 184);
            this.grpboxResults.TabIndex = 5;
            this.grpboxResults.TabStop = false;
            this.grpboxResults.Text = "Results";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(20, 38);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(44, 17);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Days:";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Location = new System.Drawing.Point(20, 72);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(50, 17);
            this.lblHours.TabIndex = 1;
            this.lblHours.Text = "Hours:";
            // 
            // lblMinutes
            // 
            this.lblMinutes.AutoSize = true;
            this.lblMinutes.Location = new System.Drawing.Point(20, 107);
            this.lblMinutes.Name = "lblMinutes";
            this.lblMinutes.Size = new System.Drawing.Size(61, 17);
            this.lblMinutes.TabIndex = 2;
            this.lblMinutes.Text = "Minutes:";
            // 
            // lblSeconds
            // 
            this.lblSeconds.AutoSize = true;
            this.lblSeconds.Location = new System.Drawing.Point(20, 145);
            this.lblSeconds.Name = "lblSeconds";
            this.lblSeconds.Size = new System.Drawing.Size(67, 17);
            this.lblSeconds.TabIndex = 3;
            this.lblSeconds.Text = "Seconds:";
            // 
            // lblDaysResults
            // 
            this.lblDaysResults.AutoSize = true;
            this.lblDaysResults.Location = new System.Drawing.Point(199, 38);
            this.lblDaysResults.Name = "lblDaysResults";
            this.lblDaysResults.Size = new System.Drawing.Size(0, 17);
            this.lblDaysResults.TabIndex = 4;
            this.lblDaysResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblHoursReults
            // 
            this.lblHoursReults.AutoSize = true;
            this.lblHoursReults.Location = new System.Drawing.Point(199, 72);
            this.lblHoursReults.Name = "lblHoursReults";
            this.lblHoursReults.Size = new System.Drawing.Size(0, 17);
            this.lblHoursReults.TabIndex = 5;
            this.lblHoursReults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMinutesResults
            // 
            this.lblMinutesResults.AutoSize = true;
            this.lblMinutesResults.Location = new System.Drawing.Point(199, 107);
            this.lblMinutesResults.Name = "lblMinutesResults";
            this.lblMinutesResults.Size = new System.Drawing.Size(0, 17);
            this.lblMinutesResults.TabIndex = 6;
            this.lblMinutesResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSecondsResults
            // 
            this.lblSecondsResults.AutoSize = true;
            this.lblSecondsResults.Location = new System.Drawing.Point(199, 145);
            this.lblSecondsResults.Name = "lblSecondsResults";
            this.lblSecondsResults.Size = new System.Drawing.Size(0, 17);
            this.lblSecondsResults.TabIndex = 7;
            this.lblSecondsResults.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(477, 451);
            this.Controls.Add(this.grpboxResults);
            this.Controls.Add(this.labelInput);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpboxResults.ResumeLayout(false);
            this.grpboxResults.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label labelInput;
        private System.Windows.Forms.GroupBox grpboxResults;
        private System.Windows.Forms.Label lblSecondsResults;
        private System.Windows.Forms.Label lblMinutesResults;
        private System.Windows.Forms.Label lblHoursReults;
        private System.Windows.Forms.Label lblDaysResults;
        private System.Windows.Forms.Label lblSeconds;
        private System.Windows.Forms.Label lblMinutes;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.Label lblDays;
    }
}

