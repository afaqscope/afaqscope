using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AccessDB_Test
{
    public partial class FamilyReg : Form
    {
        public FamilyReg()
        {
            InitializeComponent();
        }

        private void FamilyReg_Load(object sender, EventArgs e)
        {
            textBoxWithLable1.setUpperText("الإسم");
            textBoxWithLable1.setLowerText("الإسم");

            comboBoxWithText1.setUpperText("حالة الإقامة");
            comboBoxWithText1.setComboBoxText("");
        }
    }
}
