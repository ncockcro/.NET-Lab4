namespace Lab4
{
    partial class Lab4Form
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
            this.RollingButton = new System.Windows.Forms.Button();
            this.outputTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // RollingButton
            // 
            this.RollingButton.Location = new System.Drawing.Point(349, 138);
            this.RollingButton.Name = "RollingButton";
            this.RollingButton.Size = new System.Drawing.Size(185, 99);
            this.RollingButton.TabIndex = 0;
            this.RollingButton.Text = "Start Rolling";
            this.RollingButton.UseVisualStyleBackColor = true;
            this.RollingButton.Click += new System.EventHandler(this.RollingButton_Click);
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(249, 286);
            this.outputTextBox.Multiline = true;
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(360, 331);
            this.outputTextBox.TabIndex = 1;
            // 
            // Lab4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 723);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.RollingButton);
            this.Name = "Lab4Form";
            this.Text = "Lab4";
            this.Load += new System.EventHandler(this.Lab4Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button RollingButton;
        private System.Windows.Forms.TextBox outputTextBox;
    }
}

