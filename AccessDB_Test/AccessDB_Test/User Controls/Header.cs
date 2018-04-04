using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AfaqScope.User_Controls
{
    public partial class Header : UserControl
    {
        public Header()
        {
            InitializeComponent();
        }
        public void setHeader(string s)
        {
            labelHeader.Text = s;
        }

        private void Header_Load(object sender, EventArgs e)
        {
            button2.TabStop = false;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
        }
    }
    
}
