using System;
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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            Size size = Screen.PrimaryScreen.Bounds.Size;
            this.MinimumSize = size;
            this.MaximumSize = size;

            header1.setHeader("أسرة");

            //this is the count of search results
            int numberOfPErsonalCards = 7;
            if (numberOfPErsonalCards == 0)
            {
                panelPersonalCards.Hide();
            }
            else
            {
                int cardHeight = 581;
                int panelNewHieght = (int)Math.Ceiling((double)numberOfPErsonalCards / 2);

                panelPersonalCards.Height = cardHeight * panelNewHieght + 50;

                PersonalCard pc;

                int countY = 0;
                for (int i = 0; i < numberOfPErsonalCards; i++)
                {

                    pc = new PersonalCard();
                    int x, y;
                    if (i % 2 == 0)
                    {
                        if (i != 0)
                            countY += 1;
                        x = 600;
                    }
                    else
                    {
                        x = 0;
                    }
                    y = 581 * countY;
                    pc.Location = new Point(x, y);
                    panelPersonalCards.Controls.Add(pc);

                }
            }
        }


        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pictureBox1_Click(this, new EventArgs());
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("searched!");
        }

        private void textBox1_GotFocus(object sender, System.EventArgs e)
        {

            textBox1.Text = "";

        }
        private void textBox1_LostFocus(object sender, System.EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                textBox1.Text = "البحث";
            }


        }
    }
}
