namespace AccessDB_Test.User_Controls
{
    partial class AddMember
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
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonMultiple = new System.Windows.Forms.Button();
            this.labelOne = new System.Windows.Forms.Label();
            this.labelMultiple = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOne
            // 
            this.buttonOne.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonOne.BackgroundImage = global::AccessDB_Test.Properties.Resources.add_friend_512;
            this.buttonOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonOne.Location = new System.Drawing.Point(243, 13);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(101, 90);
            this.buttonOne.TabIndex = 0;
            this.buttonOne.UseVisualStyleBackColor = true;
            // 
            // buttonMultiple
            // 
            this.buttonMultiple.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonMultiple.BackgroundImage = global::AccessDB_Test.Properties.Resources.add_friend_512;
            this.buttonMultiple.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMultiple.Location = new System.Drawing.Point(119, 13);
            this.buttonMultiple.Name = "buttonMultiple";
            this.buttonMultiple.Size = new System.Drawing.Size(101, 90);
            this.buttonMultiple.TabIndex = 1;
            this.buttonMultiple.UseVisualStyleBackColor = true;
            // 
            // labelOne
            // 
            this.labelOne.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelOne.Location = new System.Drawing.Point(243, 106);
            this.labelOne.Name = "labelOne";
            this.labelOne.Size = new System.Drawing.Size(101, 23);
            this.labelOne.TabIndex = 2;
            this.labelOne.Text = "إضافة فرد";
            this.labelOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMultiple
            // 
            this.labelMultiple.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelMultiple.Location = new System.Drawing.Point(109, 106);
            this.labelMultiple.Name = "labelMultiple";
            this.labelMultiple.Size = new System.Drawing.Size(128, 23);
            this.labelMultiple.TabIndex = 3;
            this.labelMultiple.Text = "إضافة أفراد غير معرفين";
            this.labelMultiple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.labelMultiple);
            this.Controls.Add(this.labelOne);
            this.Controls.Add(this.buttonMultiple);
            this.Controls.Add(this.buttonOne);
            this.Name = "AddMember";
            this.Size = new System.Drawing.Size(459, 166);
            this.Load += new System.EventHandler(this.AddMember_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonMultiple;
        private System.Windows.Forms.Label labelOne;
        private System.Windows.Forms.Label labelMultiple;
    }
}
