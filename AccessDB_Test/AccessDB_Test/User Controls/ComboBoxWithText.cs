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
            comboBox.ForeColor = Color.Gray;

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
                comboBox.ForeColor = Color.Gray;
                labelUpperText.Hide();
            }


        }

        public void setText(string u, string l)
        {
            labelUpperText.Text = u;
            setComboBoxText(l);
            comboBoxText = l;
        }

        public void setComboBoxText(string s)
        {
            comboBox.Text = s;
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox.ForeColor = Color.Black;
        }
    }
}
