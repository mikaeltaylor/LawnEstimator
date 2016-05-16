namespace LawnEstimator
{
    partial class LawnEstimatorForm
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
            this.output = new System.Windows.Forms.ListBox();
            this.lawnLengthInput = new System.Windows.Forms.TextBox();
            this.lawnWidthInput = new System.Windows.Forms.TextBox();
            this.lawnBaseLabel = new System.Windows.Forms.Label();
            this.lawnWidthLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.FormattingEnabled = true;
            this.output.Location = new System.Drawing.Point(12, 153);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(260, 95);
            this.output.TabIndex = 0;
            // 
            // lawnLengthInput
            // 
            this.lawnLengthInput.Location = new System.Drawing.Point(118, 29);
            this.lawnLengthInput.Name = "lawnLengthInput";
            this.lawnLengthInput.Size = new System.Drawing.Size(100, 20);
            this.lawnLengthInput.TabIndex = 1;
            this.lawnLengthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lawnLengthInput_KeyPress);
            // 
            // lawnWidthInput
            // 
            this.lawnWidthInput.Location = new System.Drawing.Point(118, 56);
            this.lawnWidthInput.Name = "lawnWidthInput";
            this.lawnWidthInput.Size = new System.Drawing.Size(100, 20);
            this.lawnWidthInput.TabIndex = 2;
            this.lawnWidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lawnWidthInput_KeyPress);
            // 
            // lawnBaseLabel
            // 
            this.lawnBaseLabel.AutoSize = true;
            this.lawnBaseLabel.Location = new System.Drawing.Point(5, 32);
            this.lawnBaseLabel.Name = "lawnBaseLabel";
            this.lawnBaseLabel.Size = new System.Drawing.Size(104, 13);
            this.lawnBaseLabel.TabIndex = 3;
            this.lawnBaseLabel.Text = "Lawn Length in feet:";
            // 
            // lawnWidthLabel
            // 
            this.lawnWidthLabel.AutoSize = true;
            this.lawnWidthLabel.Location = new System.Drawing.Point(13, 59);
            this.lawnWidthLabel.Name = "lawnWidthLabel";
            this.lawnWidthLabel.Size = new System.Drawing.Size(99, 13);
            this.lawnWidthLabel.TabIndex = 4;
            this.lawnWidthLabel.Text = "Lawn Width in feet:";
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(101, 124);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 5;
            this.submitButton.Text = "SUBMIT";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // LawnEstimatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.lawnWidthLabel);
            this.Controls.Add(this.lawnBaseLabel);
            this.Controls.Add(this.lawnWidthInput);
            this.Controls.Add(this.lawnLengthInput);
            this.Controls.Add(this.output);
            this.Name = "LawnEstimatorForm";
            this.Text = "Lawn Estimator v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox output;
        private System.Windows.Forms.TextBox lawnLengthInput;
        private System.Windows.Forms.TextBox lawnWidthInput;
        private System.Windows.Forms.Label lawnBaseLabel;
        private System.Windows.Forms.Label lawnWidthLabel;
        private System.Windows.Forms.Button submitButton;
    }
}

