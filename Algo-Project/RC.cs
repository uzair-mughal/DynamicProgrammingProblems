using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Algo_Project
{
    public partial class RC : Form
    {
        private string filename;
        private string str1;
        private string str2;
        private int[] lenghts;
        private int[] prices;
        int[,] Result;
        private int RL = 15;
        private int left;
        private int right;
        public RC(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];
            str2 = lines[1];

            string[] temp1 = str1.Split(',');
            string[] temp2 = str2.Split(',');

            lenghts = new int[temp1.Length - 1];
            prices = new int[temp2.Length - 1];

            int i = 0;
            str1 = string.Empty;
            str2 = string.Empty;

            foreach (string obj in temp1)
            {
                if (obj == "")
                    break;
                lenghts[i] = Convert.ToInt32(obj);
                str1 += obj + " ";
                i++;
            }

            for (i = 1; i < lenghts.Length; i++)
            {
                lenghts[i - 1] = i;
            }

            i = 0;
            foreach (string obj in temp2)
            {
                if (obj == "")
                    break;
                prices[i] = Convert.ToInt32(obj);
                str2 += obj + " ";
                i++;
            }
        }
        private void Algo()
        {
            int n = lenghts.Length;
            int[] find_max = new int[2];

            Result = new int[n, RL + 1];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= RL; j++)
                {
                    if (j == 0)
                    {
                        Result[i, j] = 0;
                        continue;
                    }
                    if (i == 0)
                    {
                        Result[i, j] = Result[i, j - lenghts[i]] + prices[i];
                    }
                    else
                    {
                        if (lenghts[i] > j)
                        {
                            Result[i, j] = Result[i - 1, j];
                        }
                        else
                        {
                            find_max[0] = Result[i, j - lenghts[i]] + prices[i];
                            find_max[1] = Result[i - 1, j];
                            Result[i, j] = find_max.Max();
                        }
                    }
                }
            }
            str1_textBox.Text = str1;
            str2_textBox.Text = str2;
            ans_textBox.Text = Result[n-1, RL].ToString();
        }

        private void RC_Load(object sender, EventArgs e)
        {
            value_label.Visible = false;
            weight_label.Visible = false;
            ReadFile();
            Algo();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            this.Hide();
            obj.Show();
        }
        private void Load_String()
        {
            string[] temp1 = str1.Split(' ');
            string[] temp2 = str2.Split(' ');

            int L1 = temp2.Length - 1;
            left = 60;
            right = 211;

            for (int i = 0; i < L1; i++)
            {
                TextBox textBox1 = new TextBox();
                this.Controls.Add(textBox1);
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Location = new System.Drawing.Point(left, right);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(44, 32);
                textBox1.TabIndex = 3;
                textBox1.Text = temp2[i].ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                right = right + 38;
            }

            int L2 = temp1.Length - 1;
            left = 110;
            right = 211;
            for (int i = 0; i < L2; i++)
            {
                TextBox textBox1 = new TextBox();
                this.Controls.Add(textBox1);
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Location = new System.Drawing.Point(left, right);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(44, 32);
                textBox1.TabIndex = 3;
                textBox1.Text = temp1[i].ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                right = right + 38;
            }

            int L3 = RL;
            left = 170;
            right = 135;
            for (int i = 0; i <= L3; i++)
            {
                TextBox textBox1 = new TextBox();
                this.Controls.Add(textBox1);
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Location = new System.Drawing.Point(left, right);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(44, 32);
                textBox1.TabIndex = 3;
                textBox1.Text = i.ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                left = left + 50;
            }
        }

        private void Load_Table()
        {

            left = 170;
            right = 173;

            int n = prices.Length;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= RL; j++)
                {

                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    textBox1.Text = Result[i, j].ToString();
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.ReadOnly = true;
                    left = left + 50;

                }

                right = right + 38;
                left = 170;
            }

            left = 60;
            back_button.Location = new Point(left, right);
        }
        private void table_button_Click(object sender, EventArgs e)
        {
            value_label.Visible = true;
            weight_label.Visible = true;
            this.Size = new Size(1094, 834);
            this.Location = new Point(400, 160);
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            table_button.Visible = false;
            Load_String();
            Load_Table();
        }
    }
}
