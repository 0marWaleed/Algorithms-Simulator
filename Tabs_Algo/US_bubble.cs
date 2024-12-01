using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabs_Algo
{
    public partial class UC_bubble : UserControl
    {
        int ind = 0, n;
        private int[] arr;
        public UC_bubble()
        {
            InitializeComponent();
        }

        private void UC_bubble_Load(object sender, EventArgs e)
        {

        }

        private void textBox_insert_KeyDown(object sender, KeyEventArgs e)
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

                        List<Label> customLabels2 = new List<Label>();
                        Label label2 = new Label();
                        label2.Parent = flowLayoutPanel_sorted;
                        label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
                        label2.Margin = new Padding(1);
                        label2.Tag = "dynamic";
                        label2.Name = "label2" + ind;
                        label2.Anchor = (AnchorStyles.None);
                        label2.TextAlign = ContentAlignment.MiddleCenter;
                        label2.Text = arr[ind] + "";
                        label2.AutoSize = true;
                        customLabels2.Add(label2);
                        flowLayoutPanel_sorted.Controls.Add(label2);

                        ind++;

                        textBox_insert.Clear();
                        textBox_insert.Focus();
                    }
                }
            }
        }

        private void button_sort_Click(object sender, EventArgs e)
        {
            bool flag = false;
            short counter = 0;
            int i, j;
            int temp = 0,newInd = 0;
            for (i = 0; i < n - 1; i++)
            {
                
                for (j = 0; j < n - i - 1; j++)
                {
                    newInd = j + 1;
                    flowLayoutPanel_sorted.Controls["label2" + newInd.ToString()].ForeColor = Color.Red;
                    flowLayoutPanel_sorted.Controls["label2" + newInd.ToString()].Update();
                    flowLayoutPanel_sorted.Controls["label2" + j.ToString()].ForeColor = Color.Red;
                    flowLayoutPanel_sorted.Controls["label2" + j.ToString()].Update();
                    Thread.Sleep(750);
                    counter++;
                    if (arr[j] > arr[j + 1])
                    {
                        flag = true;
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                        flowLayoutPanel_sorted.Controls["label2" + newInd.ToString()].Text = arr[j+1] + "";
                        flowLayoutPanel_sorted.Controls["label2" + j.ToString()].Text = arr[j] + "";

                        flowLayoutPanel_sorted.Controls["label2" + j.ToString()].ForeColor = Color.Green;
                        flowLayoutPanel_sorted.Controls["label2" + j.ToString()].Update();
                        flowLayoutPanel_sorted.Controls["label2" + newInd.ToString()].ForeColor = Color.Green;
                        flowLayoutPanel_sorted.Controls["label2" + newInd.ToString()].Update();
                        Thread.Sleep(400);
                        
                    }
                    for (int a = 0; a < n; a++)
                    {
                        flowLayoutPanel_sorted.Controls["label2" + a.ToString()].ForeColor = Color.Black;
                        flowLayoutPanel_sorted.Controls["label2" + a.ToString()].Update();
                        Thread.Sleep(100);
                    }
                }
                if (!flag)
                {
                    MessageBox.Show("Array is already sorted!", "Sorted Array Detected!", MessageBoxButtons.OK, MessageBoxIcon.Question);
                    break;
                }
            }
            if(flag)
            {
                MessageBox.Show("Array has been sorted successfully!" +"\n" + "No. of steps: " + counter + "\n" + "Time taken: " + counter + "s", "Successful Sort!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            Array.Clear(arr, 0, arr.Length);
            for (int i = 0; i < arr.Length; i++)
            {
                foreach (Control control in flowLayoutPanel1.Controls)
                {
                    if (control is Label label && label.Tag != null && label.Tag.ToString() == "dynamic")
                    {
                        flowLayoutPanel1.Controls.Remove(label); // Remove from flowLayoutPanel1
                        label.Dispose(); // Dispose of the label
                    }
                }
                foreach (Control control in flowLayoutPanel_sorted.Controls)
                {
                    if (control is Label label2 && label2.Tag != null && label2.Tag.ToString() == "dynamic")
                    {
                        flowLayoutPanel_sorted.Controls.Remove(label2); // Remove from flowLayoutPanel1
                        label2.Dispose(); // Dispose of the label
                    }
                }
            }

            comboBox1.Text = string.Empty;
            textBox_insert.Clear();
            ind = 0;
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
    }
}
