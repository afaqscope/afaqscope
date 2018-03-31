using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace AccessDB_Test
{
    public partial class PersonalCard : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public PersonalCard()
        {
            InitializeComponent();
        }

        private void PersonalCard_Load(object sender, EventArgs e)
        {
            labelGainer.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelMainTaker.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            labelSubTaker.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void pictureBoxRightHand_Click(object sender, EventArgs e)
        {
            Point ptLowerLeft = new Point(Width - 4 * pictureBoxRightHand.Width, Height - 2*pictureBoxRightHand.Height);
            ptLowerLeft = this.PointToScreen(ptLowerLeft);
            contextMenuStripRightHand.Show(ptLowerLeft);
        }

        private void pictureBoxLeftHand_Click(object sender, EventArgs e)
        {
            Point ptLowerLeft = new Point(Width - 8 * pictureBoxLeftHand.Width, Height - 2 * pictureBoxLeftHand.Height);
            ptLowerLeft = this.PointToScreen(ptLowerLeft);
            contextMenuStripLeftHand.Show(ptLowerLeft);
        }

        private void contextMenuStripRightHand_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ClickedItem", e.ClickedItem);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "ItemClicked Event");
        }

        private void contextMenuStripLeftHand_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();
            messageBoxCS.AppendFormat("{0} = {1}", "ClickedItem", e.ClickedItem);
            messageBoxCS.AppendLine();
            MessageBox.Show(messageBoxCS.ToString(), "ItemClicked Event");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("open edit page");
        }

    }
}
