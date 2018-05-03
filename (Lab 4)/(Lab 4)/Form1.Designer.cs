namespace _Lab_4_
{
    partial class admissionCalculator
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
            this.acceptedOutput = new System.Windows.Forms.Label();
            this.runningTotalLabel = new System.Windows.Forms.Label();
            this.gpaLabel = new System.Windows.Forms.Label();
            this.gpaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.testScoreTextBox = new System.Windows.Forms.TextBox();
            this.admissionButton = new System.Windows.Forms.Button();
            this.admissionStandingTextBox = new System.Windows.Forms.Label();
            this.admissionStandingLabel = new System.Windows.Forms.Label();
            this.rejectedOutput = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // acceptedOutput
            // 
            this.acceptedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.acceptedOutput.Location = new System.Drawing.Point(97, 19);
            this.acceptedOutput.Name = "acceptedOutput";
            this.acceptedOutput.Size = new System.Drawing.Size(40, 23);
            this.acceptedOutput.TabIndex = 8;
            // 
            // runningTotalLabel
            // 
            this.runningTotalLabel.AutoSize = true;
            this.runningTotalLabel.Location = new System.Drawing.Point(25, 20);
            this.runningTotalLabel.Name = "runningTotalLabel";
            this.runningTotalLabel.Size = new System.Drawing.Size(56, 13);
            this.runningTotalLabel.TabIndex = 9;
            this.runningTotalLabel.Text = "Accepted:";
            this.runningTotalLabel.Click += new System.EventHandler(this.runningTotalLabel_Click);
            // 
            // gpaLabel
            // 
            this.gpaLabel.AutoSize = true;
            this.gpaLabel.Location = new System.Drawing.Point(144, 74);
            this.gpaLabel.Name = "gpaLabel";
            this.gpaLabel.Size = new System.Drawing.Size(32, 13);
            this.gpaLabel.TabIndex = 10;
            this.gpaLabel.Text = "GPA:";
            // 
            // gpaTextBox
            // 
            this.gpaTextBox.Location = new System.Drawing.Point(205, 71);
            this.gpaTextBox.Name = "gpaTextBox";
            this.gpaTextBox.Size = new System.Drawing.Size(79, 20);
            this.gpaTextBox.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Test Score:";
            // 
            // testScoreTextBox
            // 
            this.testScoreTextBox.Location = new System.Drawing.Point(205, 117);
            this.testScoreTextBox.Name = "testScoreTextBox";
            this.testScoreTextBox.Size = new System.Drawing.Size(79, 20);
            this.testScoreTextBox.TabIndex = 13;
            // 
            // admissionButton
            // 
            this.admissionButton.Location = new System.Drawing.Point(175, 193);
            this.admissionButton.Name = "admissionButton";
            this.admissionButton.Size = new System.Drawing.Size(133, 23);
            this.admissionButton.TabIndex = 14;
            this.admissionButton.Text = "Determine Admissions";
            this.admissionButton.UseVisualStyleBackColor = true;
            this.admissionButton.Click += new System.EventHandler(this.admissionButton_Click);
            // 
            // admissionStandingTextBox
            // 
            this.admissionStandingTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.admissionStandingTextBox.Location = new System.Drawing.Point(205, 299);
            this.admissionStandingTextBox.Name = "admissionStandingTextBox";
            this.admissionStandingTextBox.Size = new System.Drawing.Size(77, 22);
            this.admissionStandingTextBox.TabIndex = 15;
            // 
            // admissionStandingLabel
            // 
            this.admissionStandingLabel.AutoSize = true;
            this.admissionStandingLabel.Location = new System.Drawing.Point(74, 300);
            this.admissionStandingLabel.Name = "admissionStandingLabel";
            this.admissionStandingLabel.Size = new System.Drawing.Size(102, 13);
            this.admissionStandingLabel.TabIndex = 16;
            this.admissionStandingLabel.Text = "Admission Standing:";
            // 
            // rejectedOutput
            // 
            this.rejectedOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rejectedOutput.Location = new System.Drawing.Point(345, 20);
            this.rejectedOutput.Name = "rejectedOutput";
            this.rejectedOutput.Size = new System.Drawing.Size(40, 23);
            this.rejectedOutput.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = ":Rejected";
            // 
            // admissionCalculator
            // 
            this.AcceptButton = this.admissionButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 409);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rejectedOutput);
            this.Controls.Add(this.admissionStandingLabel);
            this.Controls.Add(this.admissionStandingTextBox);
            this.Controls.Add(this.admissionButton);
            this.Controls.Add(this.testScoreTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpaTextBox);
            this.Controls.Add(this.gpaLabel);
            this.Controls.Add(this.runningTotalLabel);
            this.Controls.Add(this.acceptedOutput);
            this.Name = "admissionCalculator";
            this.Text = "Lab 4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acceptedOutput;
        private System.Windows.Forms.Label runningTotalLabel;
        private System.Windows.Forms.Label gpaLabel;
        private System.Windows.Forms.TextBox gpaTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox testScoreTextBox;
        private System.Windows.Forms.Button admissionButton;
        private System.Windows.Forms.Label admissionStandingTextBox;
        private System.Windows.Forms.Label admissionStandingLabel;
        private System.Windows.Forms.Label rejectedOutput;
        private System.Windows.Forms.Label label3;
    }
}

