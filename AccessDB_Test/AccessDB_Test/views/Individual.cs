﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDB_Test.views
{
    public partial class Individual : Form
    {
        public Individual()
        {
            InitializeComponent();
        }

        private void Individual_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Size size = Screen.PrimaryScreen.Bounds.Size;
            this.MinimumSize = size;
            this.MaximumSize = size;
        }
    }
}
