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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
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
                labelMembers.Hide();
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
                        if(i!=0)
                            countY += 1;
                        x = 600;
                    }
                    else
                    {
                        x = 0;
                    }
                    y =  581 * countY;
                    pc.Location = new Point(x, y);
                    panelPersonalCards.Controls.Add(pc);

                }
            }
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
            

         

        }
    }
}
