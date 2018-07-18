namespace WindowsFormsApp2
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
            this.deptLabel = new System.Windows.Forms.Label();
            this.contLabel = new System.Windows.Forms.Label();
            this.deptTextBox = new System.Windows.Forms.TextBox();
            this.ContTextBox = new System.Windows.Forms.TextBox();
            this.OkayButton = new System.Windows.Forms.Button();
            this.doneButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // deptLabel
            // 
            this.deptLabel.AutoSize = true;
            this.deptLabel.Location = new System.Drawing.Point(20, 28);
            this.deptLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.deptLabel.Name = "deptLabel";
            this.deptLabel.Size = new System.Drawing.Size(333, 46);
            this.deptLabel.TabIndex = 0;
            this.deptLabel.Text = "Enter Department";
            // 
            // contLabel
            // 
            this.contLabel.AutoSize = true;
            this.contLabel.Location = new System.Drawing.Point(20, 89);
            this.contLabel.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.contLabel.Name = "contLabel";
            this.contLabel.Size = new System.Drawing.Size(342, 46);
            this.contLabel.TabIndex = 1;
            this.contLabel.Text = "Enter Contribution";
            // 
            // deptTextBox
            // 
            this.deptTextBox.Location = new System.Drawing.Point(368, 28);
            this.deptTextBox.Name = "deptTextBox";
            this.deptTextBox.Size = new System.Drawing.Size(155, 53);
            this.deptTextBox.TabIndex = 2;
            // 
            // ContTextBox
            // 
            this.ContTextBox.Location = new System.Drawing.Point(368, 89);
            this.ContTextBox.Name = "ContTextBox";
            this.ContTextBox.Size = new System.Drawing.Size(155, 53);
            this.ContTextBox.TabIndex = 3;
            // 
            // OkayButton
            // 
            this.OkayButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.OkayButton.Location = new System.Drawing.Point(77, 210);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(155, 59);
            this.OkayButton.TabIndex = 4;
            this.OkayButton.Text = "Okay";
            this.OkayButton.UseVisualStyleBackColor = true;
            this.OkayButton.Click += new System.EventHandler(this.OkayButton_Click);
            // 
            // doneButton
            // 
            this.doneButton.BackColor = System.Drawing.Color.Red;
            this.doneButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.doneButton.ForeColor = System.Drawing.Color.Black;
            this.doneButton.Location = new System.Drawing.Point(310, 210);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(173, 59);
            this.doneButton.TabIndex = 5;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = false;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.outputLabel.Location = new System.Drawing.Point(270, 329);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 18);
            this.outputLabel.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(23F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(581, 443);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.doneButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.ContTextBox);
            this.Controls.Add(this.deptTextBox);
            this.Controls.Add(this.contLabel);
            this.Controls.Add(this.deptLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label deptLabel;
        private System.Windows.Forms.Label contLabel;
        private System.Windows.Forms.TextBox deptTextBox;
        private System.Windows.Forms.TextBox ContTextBox;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Label outputLabel;
    }
}

