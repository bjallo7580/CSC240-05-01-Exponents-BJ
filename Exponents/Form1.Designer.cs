namespace Exponents
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
            this.UxInputTextBox = new System.Windows.Forms.TextBox();
            this.UxInputLabel = new System.Windows.Forms.Label();
            this.xOutputLabel = new System.Windows.Forms.Label();
            this.UxGoButton = new System.Windows.Forms.Button();
            this.UxResetButton = new System.Windows.Forms.Button();
            this.UxOutputLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // UxInputTextBox
            // 
            this.UxInputTextBox.Location = new System.Drawing.Point(123, 55);
            this.UxInputTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UxInputTextBox.Name = "UxInputTextBox";
            this.UxInputTextBox.Size = new System.Drawing.Size(132, 22);
            this.UxInputTextBox.TabIndex = 0;
            // 
            // UxInputLabel
            // 
            this.UxInputLabel.AutoSize = true;
            this.UxInputLabel.Location = new System.Drawing.Point(123, 33);
            this.UxInputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UxInputLabel.Name = "UxInputLabel";
            this.UxInputLabel.Size = new System.Drawing.Size(103, 16);
            this.UxInputLabel.TabIndex = 3;
            this.UxInputLabel.Text = "Enter an integer:";
            // 
            // xOutputLabel
            // 
            this.xOutputLabel.AutoSize = true;
            this.xOutputLabel.Location = new System.Drawing.Point(136, 223);
            this.xOutputLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.xOutputLabel.Name = "xOutputLabel";
            this.xOutputLabel.Size = new System.Drawing.Size(0, 16);
            this.xOutputLabel.TabIndex = 4;
            this.xOutputLabel.Visible = false;
            // 
            // UxGoButton
            // 
            this.UxGoButton.Location = new System.Drawing.Point(140, 118);
            this.UxGoButton.Margin = new System.Windows.Forms.Padding(4);
            this.UxGoButton.Name = "UxGoButton";
            this.UxGoButton.Size = new System.Drawing.Size(100, 82);
            this.UxGoButton.TabIndex = 6;
            this.UxGoButton.Text = "Go!";
            this.UxGoButton.UseVisualStyleBackColor = true;
            this.UxGoButton.Click += new System.EventHandler(this.xGoButton_Click);
            // 
            // UxResetButton
            // 
            this.UxResetButton.Location = new System.Drawing.Point(140, 261);
            this.UxResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.UxResetButton.Name = "UxResetButton";
            this.UxResetButton.Size = new System.Drawing.Size(100, 28);
            this.UxResetButton.TabIndex = 7;
            this.UxResetButton.Text = "Reset";
            this.UxResetButton.UseVisualStyleBackColor = true;
            this.UxResetButton.Click += new System.EventHandler(this.xResetButton_Click);
            // 
            // UxOutputLabel
            // 
            this.UxOutputLabel.AutoSize = true;
            this.UxOutputLabel.Location = new System.Drawing.Point(176, 222);
            this.UxOutputLabel.Name = "UxOutputLabel";
            this.UxOutputLabel.Size = new System.Drawing.Size(0, 16);
            this.UxOutputLabel.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 322);
            this.Controls.Add(this.UxOutputLabel);
            this.Controls.Add(this.UxResetButton);
            this.Controls.Add(this.UxGoButton);
            this.Controls.Add(this.xOutputLabel);
            this.Controls.Add(this.UxInputLabel);
            this.Controls.Add(this.UxInputTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Exponents Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UxInputTextBox;
        private System.Windows.Forms.Label UxInputLabel;
        private System.Windows.Forms.Label xOutputLabel;
        private System.Windows.Forms.Button UxGoButton;
        private System.Windows.Forms.Button UxResetButton;
        private System.Windows.Forms.Label UxOutputLabel;
    }
}

