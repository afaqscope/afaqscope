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
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Size size = Screen.PrimaryScreen.Bounds.Size;
            this.MinimumSize = size;
            this.MaximumSize = size;
            header2.setHeader("الأسرة");

            textBoxName.setUpperText("الإسم", "الإسم");

            comboBoxResidencyStatus.setText("حالة الإقامة", "حالة الإقامة");

            comboBoxZone.setText("المنطقة", "المنطقة");
            textBoxLocation.setUpperText("الموقع", "الموقع");
            textBoxAdress.setUpperText("العنوان", "العنوان");

            comboBoxRelationship.setText("الحالة الإجتماعية", "الحالة الإجتماعية");
            comboBoxIsHosting.setText("استضافة أشخاص مهجرين", "استضافة أشخاص مهجرين");

            comboBoxMigrationStatus.setText("وضع التهجير", "وضع التهجير");
            comboBoxReturnStatus.setText("وضع العودة", "وضع العودة");
            comboBoxShelter.setText("وضع المأوى", "وضع المأوى");
            comboBoxIncoming.setText("مصادر الدخل", "مصادر الدخل");

            comboBoxOriginalZone.setText("المحافظة الأصل", "المحافظة الأصل");
            comboBoxPartner.setText("الشريك", "الشريك");




        }
    }
}
