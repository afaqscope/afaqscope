using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessDB_Test
{
    public partial class TextBoxWithLable : UserControl
    {
        public TextBoxWithLable()
        {
            InitializeComponent();
        }

        private void textBox_GotFocus(object sender, System.EventArgs e)
        {
           
            labelLowerText.Hide();
            labelStar.Hide();
            labelUpperText.Show();

        }
        private void textBox_LostFocus(object sender, System.EventArgs e)
        {
            if (textBox.TextLength == 0)
            {
                labelLowerText.Show();
                labelStar.Show();
                labelUpperText.Hide();
            }
           

        }

        private void TextBoxWithLable_Load(object sender, EventArgs e)
        {
            labelLowerText.Show();
            labelStar.Show();
            labelUpperText.Hide();
        }

        public void setUpperText(string s)
        {
            labelUpperText.Text = s;
        }
        public void setLowerText(string s)
        {
            labelLowerText.Text = s;
        }
    }
}
