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
    public partial class ComboBoxWithText : UserControl
    {
        String comboBoxText;
        public ComboBoxWithText()
        {
            InitializeComponent();
        }

        private void ComboBoxWithText_Load(object sender, EventArgs e)
        {
            comboBoxText = "initial text";
            comboBox.Text = comboBoxText;

            labelUpperText.Hide();

        }
        private void textBox_GotFocus(object sender, System.EventArgs e)
        {
            comboBox.Text = "";
            labelUpperText.Show();

        }
        private void textBox_LostFocus(object sender, System.EventArgs e)
        {
            if (comboBox.SelectedItem == null)
            {
                comboBox.Text = comboBoxText;
                labelUpperText.Hide();
            }


        }

        public void setUpperText(string s)
        {
            labelUpperText.Text = s;
        }

        public void setComboBoxText(string s)
        {
            comboBox.Text = s;
        }
    }
}
