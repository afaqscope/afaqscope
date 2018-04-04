using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AccessDB_Test.User_Controls
{
    public partial class AddMember : UserControl
    {
        public AddMember()
        {
            InitializeComponent();
        }

        private void AddMember_Load(object sender, EventArgs e)
        {
            buttonOne.TabStop = false;
            buttonOne.FlatStyle = FlatStyle.Flat;
            buttonOne.FlatAppearance.BorderSize = 0;

            buttonMultiple.TabStop = false;
            buttonMultiple.FlatStyle = FlatStyle.Flat;
            buttonMultiple.FlatAppearance.BorderSize = 0;
        }
    }
}
