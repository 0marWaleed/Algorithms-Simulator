using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace Tabs_Algo
{
    public partial class UC_linear : UserControl
    {
        int ind = 0, n;
        private int[] arr;
        public UC_linear()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            n = Int32.Parse(selected);
            arr = new int[n];
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int check;
                bool number = int.TryParse(textBox_insert.Text, out check);
                if (!number)
                {
                    MessageBox.Show("Invalid Input!", "Error!", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning);
                }
                else
                {
                    if (ind >= n)
                    {
                        MessageBox.Show("Maximum Array Size Reached!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                    }
                    else
                    {
                        arr[ind] = Int32.Parse(textBox_insert.Text);
                        List<Label> customLabels = new List<Label>();
                        Label label = new Label();
                        label.Parent = flowLayoutPanel1;
                        label.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
                        label.Margin = new Padding(1);
                        label.Tag = "dynamic";
                        label.Name = "label" + ind;
                        label.Anchor = AnchorStyles.None;
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Text = arr[ind] + "";
                        label.AutoSize = true;

                        customLabels.Add(label);
                        flowLayoutPanel1.Controls.Add(label);
                        ind++;
                        textBox_insert.Clear();
                        textBox_insert.Focus();
                    }
                }
            }
        }

        private void UC_linear_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < n; i++)
                {
                    flowLayoutPanel1.Controls["label" + i.ToString()].ForeColor = Color.Black;
                }
                int search;
                short counter = 0;
                bool flag = false;
                search = Int32.Parse(textBox_search.Text);
                for (int i = 0; i < ind; i++)
                {
                    counter++;
                    flowLayoutPanel1.Controls["label" + i.ToString()].ForeColor = Color.Red;
                    flowLayoutPanel1.Controls["label" + i.ToString()].Update();
                    
                    if (search == arr[i])
                    {
                        flowLayoutPanel1.Controls["label" + i.ToString()].ForeColor = Color.Green;
                        flag = true;
                        break;
                    }
                    Thread.Sleep(800);
                }
                if (flag)
                {
                    MessageBox.Show("Element Found Successfully!" + "\n" + "Index is: " + (counter - 1) + "\n" + "No. of steps: " + counter + "\n" + "Time taken: " + counter + "s", "Successful Search!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Element Not Found!","Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Array.Clear(arr, 0, arr.Length);
            for (int i=0; i<arr.Length; i++)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Label label && label.Tag != null && label.Tag.ToString() == "dynamic")
                    {
                        flowLayoutPanel1.Controls.Remove(label); // Remove from flowLayoutPanel1
                        label.Dispose(); // Dispose of the label
                    }
                }
            }
            
            comboBox1.Text = string.Empty;
            textBox_search.Clear();
            textBox_insert.Clear();
            ind = 0;
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
