using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabs_Algo
{
    public partial class UC_binary : UserControl
    {
        int ind = 0, n;
        private int[] arr;
        public UC_binary()
        {
            InitializeComponent();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = comboBox1.SelectedItem.ToString();
            n = Int32.Parse(selected);
            arr = new int[n];
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_insert_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_insert_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void button_clear_Click(object sender, EventArgs e)
        {

        }

        private void textBox_insert_TextChanged_1(object sender, EventArgs e)
        {

        }
        private void textBox_insert_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int counting = 0;
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
                        label.Anchor = (AnchorStyles.None);
                        label.TextAlign = ContentAlignment.MiddleCenter;
                        label.Text = arr[ind] + "";
                        label.AutoSize = true;
                        customLabels.Add(label);
                        flowLayoutPanel1.Controls.Add(label);
                        ind++;
                        counting = ind;
                        textBox_insert.Clear();
                        textBox_insert.Focus();



                        if (counting == n)
                        {
                            for (int j = 0; j < arr.Length - 1; j++)
                            {
                                for (int i = 0; i < arr.Length - 1; i++)
                                {
                                    int swap = 0;
                                    if (arr[i] > arr[i + 1])
                                    {
                                        swap = arr[i + 1];
                                        arr[i + 1] = arr[i];
                                        arr[i] = swap;
                                    }
                                }
                            }
                            for (int a = 0; a < n; a++)
                            {
                                List<Label> customLabels2 = new List<Label>();
                                Label label2 = new Label();
                                label2.Parent = flowLayoutPanel_sorted;
                                label2.Font = new Font("Century Gothic", 12F, FontStyle.Bold);
                                label2.Margin = new Padding(1);
                                label2.Tag = "dynamic";
                                label2.Name = "label2" + a;
                                label2.Anchor = (AnchorStyles.None);
                                label2.TextAlign = ContentAlignment.MiddleCenter;
                                label2.Text = arr[a] + "";
                                label2.AutoSize = true;
                                customLabels2.Add(label2);
                                flowLayoutPanel_sorted.Controls.Add(label2);
                                counting = 0;
                            }

                        }

                    }
                }
            }
        }
        private void button_clear_Click_1(object sender, EventArgs e)
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
            textBox_search.Clear();
            textBox_insert.Clear();
            ind = 0;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox_search_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                for (int i = 0; i < n; i++)
                {
                    flowLayoutPanel_sorted.Controls["label2" + i.ToString()].ForeColor = Color.Black;
                }
                int low, mid, high;
                low = 0;
                high = n;
                mid = low + (high - low) / 2;
                int search;
                short counter = 0;
                bool flag = false;
                search = Int32.Parse(textBox_search.Text);
                flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].ForeColor = Color.Red;
                flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].Update();
                Thread.Sleep(400);
                for (int i = 0; i < n; i++)
                {
                    if (arr[mid] == search)
                    {
                        flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].ForeColor = Color.Green;
                        counter++;
                        flag = true;
                        break;
                    }
                    else if (arr[mid] < search)
                    {
                        counter++;
                        low = mid + 1;
                        mid = low + (high - low) / 2;
                        if(mid == n)
                        {
                            mid = n - 1;
                        }
                        flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].ForeColor = Color.Red;
                        flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].Update();
                        Thread.Sleep(400);
                    }
                    else if (arr[mid] > search)
                    {
                        counter++;
                        high = mid - 1;
                        mid = low + (high - low) / 2;
                        flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].ForeColor = Color.Red;
                        flowLayoutPanel_sorted.Controls["label2" + mid.ToString()].Update();
                        Thread.Sleep(400);
                    }
                }
                
                if (flag)
                {
                    MessageBox.Show("Element Found Successfully!" + "\n" + "Index is: " + mid + "\n" + "No. of steps: " + counter + "\n" + "Time taken: " + counter + "s", "Successful Search!",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Element Not Found!","Search Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void flowLayoutPanel_sorted_Paint(object sender, PaintEventArgs e)
        {

        }

       
    }
}
