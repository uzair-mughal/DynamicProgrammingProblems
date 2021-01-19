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
    public partial class MCM : Form
    {
        private string parent_str;
        private string filename;
        private string str1;
        private int left;
        private int right;
        public int[] dims;
        public int[,] lookup;
        public int[,] dense;

        public MCM(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];

            string[] temp = str1.Split(',');

            dims = new int[temp.Length - 1];

            int i = 0;
            str1 = string.Empty;
            str1 = "";

            foreach (string obj in temp)
            {
                if (obj == "")
                    break;
                dims[i] = Convert.ToInt32(obj);
                str1 += obj + " ";
                i++;
            }
        }

        private void printParenthesis(int j, int i)
        {
            if (j == i)
            {
                parent_str += "A" + j.ToString() + " ";
                return;
            }
            else
            {
                parent_str += "( ";
                printParenthesis(dense[i, j] - 1, i);
                printParenthesis(j, dense[i, j]);
                parent_str += ") ";
            }
        }

        private void matrixChainOrder(int[] dims, int n) {

            for (int l = 2; l < n + 1; l++) 
            {
                for (int i = 0; i < n - l + 1; i++)
                {
                    int j = i + l - 1;

                    lookup[i, j] = Int32.MaxValue;

                    for (int k = i; k < j; k++)
                    {
                        int q = lookup[i, k] + lookup[k + 1, j] + (dims[i] * dims[k + 1] * dims[j + 1]);
                        if (q < lookup[i, j])
                        {
                            lookup[i, j] = q;

                            dense[i, j] = k + 1;
                        }
                    }
                }
            }
        }

        private void Algo()
        {

            // Matrix M[i] has dimension dims[i-1] x dims[i] for i = 1..n
            // input is 10 x 30 matrix, 30 x 5 matrix, 5 x 60 matrix
            int n = dims.Length - 1;
            //string dims_string = "";

            lookup = new int[n, n];
            dense = new int[n, n];
            parent_str = "";

            matrixChainOrder(dims, n);
            printParenthesis(n - 1, 0);

            str1_textBox.Text = str1;
            parenthesisTextBox.Text = parent_str;
            textBox1.Text = lookup[0, n-1].ToString();
        }

        private void Load_String()
        {
            int len = dims.Length;
            left = 60;
            right = 135;

            for (int i = 1; i < len; i++)
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

            left = 10;
            right = 173;
            for (int i = 1; i < len; i++)
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
                right = right + 38;
            }
        }

        private void Load_Table_Cost()
        {

            left = 60;
            right = 173;

            for (int i = 0; i < dims.Length - 1; i++)
            {
                for (int j = 0; j < dims.Length - 1; j++)
                {

                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    textBox1.Text = lookup[i, j].ToString();
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.ReadOnly = true;
                    left = left + 50;

                }

                right = right + 38;
                left = 60;
            }

            left = 10;
            back_button.Location = new Point(left, right);
        }

        private void Load_Table_Dense()
        {

            left = 60;
            right = 173;

            for (int i = 0; i < dims.Length - 1; i++)
            {
                for (int j = 0; j < dims.Length - 1; j++)
                {

                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    textBox1.Text = dense[i, j].ToString();
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.ReadOnly = true;
                    left = left + 50;

                }

                right = right + 38;
                left = 60;
            }

            left = 10;
            back_button.Location = new Point(left, right);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1094, 834);
            this.Location = new Point(400, 160);
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            Load_String();
            Load_Table_Cost();
        }

        private void MCM_Load(object sender, EventArgs e)
        {
            ReadFile();
            Algo();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1094, 834);
            this.Location = new Point(400, 160);
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            Load_String();
            Load_Table_Dense();
        }
    }
}
