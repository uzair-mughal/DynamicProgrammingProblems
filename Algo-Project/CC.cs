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
    public partial class CC : Form
    {
        private string filename;
        private string str1;
        private int[] arr;
        private int[,] Result;
        private int Coins_Required = 179;
        private int left;
        private int right;
        public CC(string temp)
        {
            filename = temp;
            InitializeComponent();
        }
        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];

            string[] temp = str1.Split(',');


            arr = new int[temp.Length-1];

            int i = 0;
            str1 = string.Empty;
            str1 = "";

            foreach (string obj in temp)
            {
                if (obj == "")
                    break;
                arr[i] = Convert.ToInt32(obj);
                str1 += obj + " ";
                
                i++;
                
            }
        }
        private void Algo()
        {
            Array.Sort(arr);

            int[] find_MIN = new int[2];
            Result = new int[arr.Length, Coins_Required + 1];

            for (int i = 0; i <= Coins_Required; i++)
            {
                if (arr[0] == 1)
                {
                    Result[0, i] = i;
                }
                else
                {
                    if (i % arr[0] == 0)
                    {
                        Result[0, i] = i / arr[0];
                    }
                }
            }

            for (int i = 1; i < arr.Length; i++)
            {
                for (int j = 0; j <= Coins_Required; j++)
                {
                    if (j == 0)
                    {
                        Result[i, 0] = 0;
                        continue;
                    }
                    if (arr[i] > j)
                    {
                        Result[i, j] = Result[i - 1, j];
                    }
                    else
                    {
                        find_MIN[0] = Result[i - 1, j];
                        find_MIN[1] = 1 + Result[i, j - arr[i]];
                        Result[i, j] = find_MIN.Min();

                    }
                }
            }
            str1_textBox.Text = str1;
            ans_textBox.Text = Result[arr.Length-1, Coins_Required].ToString();
        }
        private void CoinChange_Load(object sender, EventArgs e)
        {
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
            int L1 = Coins_Required;
            left = 60;
            right = 135;

            for (int i = 0; i <= L1; i++)
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

            int L2 = arr.Length;
            left = 10;
            right = 173;
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
                textBox1.Text = arr[i].ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                right = right + 38;
            }

        }

        private void Load_Table()
        {

            left = 60;
            right = 173;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j <= Coins_Required; j++)
                {
                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    textBox1.Text = Result[i,j].ToString();
                    textBox1.TextAlign = HorizontalAlignment.Center;
                    textBox1.ReadOnly = true;
                    left = left + 50;
                }

                right = right + 38;
                left = 60;
            }

            left = 10;
            right = right + 38;
            back_button.Location = new Point(left, right);
        }
        private void table_button_Click(object sender, EventArgs e)
        {
            this.Size = new Size(1094, 834);
            this.Location = new Point(400, 160);
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            table_button.Visible = false;
            Load_String();
            Load_Table();
        }

        private void ans_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
