namespace AccessDB_Test
{
    partial class ComboBoxWithText
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
            this.labelUpperText = new System.Windows.Forms.Label();
            this.labelSeparator = new System.Windows.Forms.Label();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // labelUpperText
            // 
            this.labelUpperText.AutoSize = true;
            this.labelUpperText.Location = new System.Drawing.Point(280, 6);
            this.labelUpperText.Name = "labelUpperText";
            this.labelUpperText.Size = new System.Drawing.Size(72, 17);
            this.labelUpperText.TabIndex = 11;
            this.labelUpperText.Text = "upperText";
            // 
            // labelSeparator
            // 
            this.labelSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSeparator.Location = new System.Drawing.Point(17, 53);
            this.labelSeparator.Name = "labelSeparator";
            this.labelSeparator.Size = new System.Drawing.Size(335, 2);
            this.labelSeparator.TabIndex = 7;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(17, 26);
            this.comboBox.Name = "comboBox";
            this.comboBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox.Size = new System.Drawing.Size(335, 24);
            this.comboBox.TabIndex = 12;
            this.comboBox.Enter += new System.EventHandler(this.textBox_GotFocus);
            this.comboBox.Leave += new System.EventHandler(this.textBox_LostFocus);
            // 
            // ComboBoxWithText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.labelUpperText);
            this.Controls.Add(this.labelSeparator);
            this.Name = "ComboBoxWithText";
            this.Size = new System.Drawing.Size(368, 70);
            this.Load += new System.EventHandler(this.ComboBoxWithText_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUpperText;
        private System.Windows.Forms.Label labelSeparator;
        private System.Windows.Forms.ComboBox comboBox;
    }
}
