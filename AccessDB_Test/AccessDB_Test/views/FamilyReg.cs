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
            header2.setHeader("الأسرة");

            nameTextBoxWithLable1.setUpperText("الإسم");
            nameTextBoxWithLable1.setLowerText("الإسم");

            residencyStatusComboBoxWithText1.setUpperText("حالة الإقامة");
            residencyStatusComboBoxWithText1.setComboBoxText("");
        }
    }
}
