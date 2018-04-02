namespace AccessDB_Test
{
    partial class TextBoxWithLable
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelSeparator = new System.Windows.Forms.Label();
            this.textBox = new System.Windows.Forms.TextBox();
            this.labelStar = new System.Windows.Forms.Label();
            this.labelLowerText = new System.Windows.Forms.Label();
            this.labelUpperText = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelSeparator
            // 
            this.labelSeparator.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(7, 62);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(335, 2);
            this.labelSeparator.TabIndex = 2;
            // 
            // textBox
            // 
            this.textBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Location = new System.Drawing.Point(7, 44);
            this.textBox.Name = "textBox";
            this.textBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox.Size = new System.Drawing.Size(335, 15);
            this.textBox.TabIndex = 3;
            this.textBox.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.textBox.Leave += new System.EventHandler(this.textBox_LostFocus);
            // 
            // labelStar
            // 
            this.labelStar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStar.AutoSize = true;
            this.labelStar.ForeColor = System.Drawing.Color.Red;
            this.labelStar.Location = new System.Drawing.Point(302, 42);
            this.labelStar.Name = "labelStar";
            this.labelStar.Size = new System.Drawing.Size(13, 17);
            this.labelStar.TabIndex = 5;
            this.labelStar.Text = "*";
            // 
            // labelLowerText
            // 
            this.labelLowerText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLowerText.AutoSize = true;
            this.labelLowerText.Location = new System.Drawing.Point(312, 42);
            this.labelLowerText.Name = "labelLowerText";
            this.labelLowerText.Size = new System.Drawing.Size(30, 17);
            this.labelLowerText.TabIndex = 4;
            this.labelLowerText.Text = "text";
            // 
            // labelUpperText
            // 
            this.labelUpperText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUpperText.AutoSize = true;
            this.labelUpperText.Location = new System.Drawing.Point(270, 24);
            this.labelUpperText.Name = "labelUpperText";
            this.labelUpperText.Size = new System.Drawing.Size(72, 17);
            this.labelUpperText.TabIndex = 6;
            this.labelUpperText.Text = "upperText";
            // 
            // TextBoxWithLable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.labelUpperText);
            this.Controls.Add(this.labelStar);
            this.Controls.Add(this.labelLowerText);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.labelSeparator);
            this.Name = "TextBoxWithLable";
            this.Size = new System.Drawing.Size(345, 70);
            this.Load += new System.EventHandler(this.TextBoxWithLable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Label labelStar;
        private System.Windows.Forms.Label labelLowerText;
        private System.Windows.Forms.Label labelUpperText;
    }
}
