namespace BirthDateString
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
            this.lblWeekDay = new System.Windows.Forms.Label();
            this.lblMonthName = new System.Windows.Forms.Label();
            this.lblMonthDay = new System.Windows.Forms.Label();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtWeekDay = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtMonthDay = new System.Windows.Forms.TextBox();
            this.txtMonthName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblWeekDay
            // 
            this.lblWeekDay.AutoSize = true;
            this.lblWeekDay.Location = new System.Drawing.Point(137, 113);
            this.lblWeekDay.Name = "lblWeekDay";
            this.lblWeekDay.Size = new System.Drawing.Size(169, 17);
            this.lblWeekDay.TabIndex = 5;
            this.lblWeekDay.Text = "Enter the day of the week";
            // 
            // lblMonthName
            // 
            this.lblMonthName.AutoSize = true;
            this.lblMonthName.Location = new System.Drawing.Point(118, 155);
            this.lblMonthName.Name = "lblMonthName";
            this.lblMonthName.Size = new System.Drawing.Size(188, 17);
            this.lblMonthName.TabIndex = 1;
            this.lblMonthName.Text = "Enter the name of the month";
            // 
            // lblMonthDay
            // 
            this.lblMonthDay.AutoSize = true;
            this.lblMonthDay.Location = new System.Drawing.Point(76, 200);
            this.lblMonthDay.Name = "lblMonthDay";
            this.lblMonthDay.Size = new System.Drawing.Size(230, 17);
            this.lblMonthDay.TabIndex = 3;
            this.lblMonthDay.Text = "Enter the numeric day of the month";
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(208, 241);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(98, 17);
            this.lblYear.TabIndex = 3;
            this.lblYear.Text = "Enter the year";
            // 
            // lblOutput
            // 
            this.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutput.Location = new System.Drawing.Point(90, 337);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(401, 34);
            this.lblOutput.TabIndex = 4;
            this.lblOutput.Text = "                                  ";
            // 
            // btnShow
            // 
            this.btnShow.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnShow.Location = new System.Drawing.Point(138, 423);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 29);
            this.btnShow.TabIndex = 5;
            this.btnShow.Text = "&Show Date";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(350, 423);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 29);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 423);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 29);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtWeekDay
            // 
            this.txtWeekDay.Location = new System.Drawing.Point(334, 113);
            this.txtWeekDay.Name = "txtWeekDay";
            this.txtWeekDay.Size = new System.Drawing.Size(157, 22);
            this.txtWeekDay.TabIndex = 0
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(334, 241);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(157, 22);
            this.txtYear.TabIndex = 3;
            // 
            // txtMonthDay
            // 
            this.txtMonthDay.Location = new System.Drawing.Point(334, 195);
            this.txtMonthDay.Name = "txtMonthDay";
            this.txtMonthDay.Size = new System.Drawing.Size(157, 22);
            this.txtMonthDay.TabIndex = 2;
            // 
            // txtMonthName
            // 
            this.txtMonthName.Location = new System.Drawing.Point(334, 152);
            this.txtMonthName.Name = "txtMonthName";
            this.txtMonthName.Size = new System.Drawing.Size(157, 22);
            this.txtMonthName.TabIndex = 1;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnShow;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(596, 511);
            this.Controls.Add(this.txtMonthName);
            this.Controls.Add(this.txtMonthDay);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtWeekDay);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.lblMonthDay);
            this.Controls.Add(this.lblMonthName);
            this.Controls.Add(this.lblWeekDay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWeekDay;
        private System.Windows.Forms.Label lblMonthName;
        private System.Windows.Forms.Label lblMonthDay;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtWeekDay;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtMonthDay;
        private System.Windows.Forms.TextBox txtMonthName;
    }
}

