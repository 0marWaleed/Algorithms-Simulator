using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Tabs_Algo
{
    public partial class Form1 : Form
    {
        int x = 259, y = 178;
        public Form1()
        {
            InitializeComponent();
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            label_move.Visible = false;
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void btn_linear_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_binary_Click(object sender, EventArgs e)
        {

        }

        private void btn_bubble_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_selection_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            label_move.SetBounds(x, y, 1, 1);
            x++;
            if (this.WindowState == FormWindowState.Maximized)
            {
                if (x >= 1520)
                {
                    x = -307;
                }
            }
            else if (x >= 820)
            {
                x = -307;
            }
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            button_linear.BaseColor = Color.Tan;
            button_binary.BaseColor = Color.Tan;
            button_bubble.BaseColor = Color.Tan;
            button_selection.BaseColor = Color.Tan;
            panel_container.Controls.Clear();

        }

        private void button_linear_Click(object sender, EventArgs e)
        {
            button_linear.BaseColor = Color.OldLace;
            button_binary.BaseColor = Color.Tan;
            button_bubble.BaseColor = Color.Tan;
            button_selection.BaseColor = Color.Tan;
            UC_linear uc = new UC_linear();
            addUserControl(uc);
        }

        private void button_binary_Click(object sender, EventArgs e)
        {
            button_linear.BaseColor = Color.Tan;
            button_binary.BaseColor = Color.OldLace;
            button_bubble.BaseColor = Color.Tan;
            button_selection.BaseColor = Color.Tan;
            UC_binary uc = new UC_binary();
            addUserControl(uc);
        }

        private void button_bubble_Click(object sender, EventArgs e)
        {
            button_linear.BaseColor = Color.Tan;
            button_binary.BaseColor = Color.Tan;
            button_bubble.BaseColor = Color.OldLace;
            button_selection.BaseColor = Color.Tan;
            UC_bubble uc = new UC_bubble();
            addUserControl(uc);
        }

        private void button_selection_Click(object sender, EventArgs e)
        {
            button_linear.BaseColor = Color.Tan;
            button_binary.BaseColor = Color.Tan;
            button_bubble.BaseColor = Color.Tan;
            button_selection.BaseColor = Color.OldLace;
            UC_selection uc = new UC_selection();
            addUserControl(uc);
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
        }
    }
}
