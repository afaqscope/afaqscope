﻿using System;
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
    }
    
}
