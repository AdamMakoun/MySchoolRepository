using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }
        bool left, right, up , down = false;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
 
            if (e.KeyCode == Keys.D)
            {
                right = true;
                down = false;
                left = false;
                up = false;
            }
            if(e.KeyCode == Keys.W)
            {
                right = false;
                down = false;
                left = false;
                up = true;
            }

            if (e.KeyCode == Keys.S)
            {
                right = false;
                down = true;
                left = false;
                up = false;
            }

            if (e.KeyCode == Keys.A)
            {
                right = false;
                down = false;
                left = true;
                up = false;
            }    
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(right == true)
            {
                panel1.Left += 10; //Way easier solution for moving the panel

                //panel1.Location = new Point(panel1.Location.X + 10, panel1.Location.Y);

                
                if (panel1.Location.X> this.Size.Width)
                {
                    panel1.Location = new Point(0, panel1.Location.Y);
                    
                }
            }
            if(left == true)
            {
                panel1.Left -= 10;

                //panel1.Location = new Point(panel1.Location.X - 10, panel1.Location.Y);
                
                if (panel1.Location.X < 0)
                {
                    panel1.Location = new Point(this.Width - 70, panel1.Location.Y);
                }
            }

            if(up == true)
            {
                panel1.Top -= 10;

                //panel1.Location = new Point(panel1.Location.X, panel1.Location.Y - 10);
                if (panel1.Location.Y < 0)
                {
                    panel1.Location = new Point(panel1.Location.X, this.Height - 90);
                }
            }

            if(down == true)
            {
                panel1.Top += 10;

                //panel1.Location = new Point(panel1.Location.X, panel1.Location.Y + 10);
                if (panel1.Location.Y + 80 > this.Size.Height)
                {
                    panel1.Location = new Point(panel1.Location.X, 0);
                }
            }
        }
    }
}
