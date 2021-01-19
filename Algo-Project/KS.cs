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
    public partial class KS : Form
    {
        private string filename;
        private string str1;
        private string str2;
        private int[] weights;
        private int[] vlaues;
        int[,] Result;
        private int W = 179;
        private int left;
        private int right;
        public KS(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            this.Hide();
            obj.Show();
        }
        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];
            str2 = lines[1];

            string[] temp1 = str1.Split(',');
            string[] temp2 = str2.Split(',');

            weights = new int[temp1.Length - 1];
            vlaues = new int[temp2.Length - 1];

            int i = 0;
            str1 = string.Empty;
            str2 = string.Empty;

            foreach (string obj in temp1)
            {
                if (obj == "")
                    break;
                weights[i] = Convert.ToInt32(obj);
                str1 += obj + " ";
                i++;
            }

            i = 0;
            foreach (string obj in temp2)
            {
                if (obj == "")
                    break;
                vlaues[i] = Convert.ToInt32(obj);
                str2 += obj + " ";
                i++;
            }
        }
        private void Algo()
        {
            int n = vlaues.Length;

            Result = new int[n + 1, W + 1];

            for (int i = 0; i <= n; i++)
            {
                for (int w = 0; w <= W; w++)
                {
                    if (i == 0 || w == 0)
                        Result[i, w] = 0;


                    else if (weights[i - 1] <= w)
                        Result[i, w] = Math.Max(vlaues[i - 1] + Result[i - 1, w - weights[i - 1]], Result[i - 1, w]);
                    else
                        Result[i, w] = Result[i - 1, w];
                }
            }          
            str1_textBox.Text = str1;
            str2_textBox.Text = str2;
            ans_textBox.Text = Result[n, W].ToString();
        }

        private void KS_Load(object sender, EventArgs e)
        {
            value_label.Visible = false; 
            weight_label.Visible = false;
            ReadFile();
            Algo();
        }
        private void Load_String()
        {
            string[] temp1 = str1.Split(' ');
            string[] temp2 = str2.Split(' ');

            int L1 = temp2.Length-1;
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

            int L2 = temp1.Length-1;
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

            int L3 = W;
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

            int n = vlaues.Length;

            for (int i = 0; i <= n; i++)
            {
                for (int j = 0; j <= W; j++)
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

        private void value_label_Click(object sender, EventArgs e)
        {

        }
    }
}
