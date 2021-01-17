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
    public partial class LCS : Form
    {
        private string filename;
        private string str1;
        private string str2;
        private int left;
        private int right;
        private int L1;
        private int L2;
        private int[,] arr;

        public LCS(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            obj.Show();
            this.Hide();
        }

        private void  ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];
            str2 = lines[1];
        }

        private void Algo()
        {
            //str1 = "UZAIR";
            //str2 = "MUZAMMIL";
            L1 = str1.Length;
            L2 = str2.Length;

            arr = new int[L1+1, L2+1];

            for (int i = 1; i <= L1; i++)
            {
                for (int j = 1; j <= L2; j++)
                {
                    if (str1[i - 1] == str2[j - 1])
                        arr[i, j] = arr[i - 1, j - 1] + 1;

                    else
                        arr[i, j] = Math.Max(arr[i - 1, j], arr[i, j - 1]);
                }
            }

            str1_textBox.Text = str1;
            str2_textBox.Text = str2;
            ans_textBox.Text = arr[L1, L2].ToString();

        }
        private void Load_String()
        {
            int L1 = str1.Length;
            left = 110;
            right = 135;

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
                textBox1.Text = str1[i].ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                left = left + 50;
            }

            int L2 = str2.Length;
            left = 10;
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
                textBox1.Text = str2[i].ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                right = right + 38;
            }
        }

        private void Load_Table()
        {

            left = 60;
            right = 173;

            for (int i = 0; i <= L2; i++)
            {
                for (int j = 0; j <= L1; j++)
                {

                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    textBox1.Text = arr[j, i].ToString();
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

        private void LCS_Load(object sender, EventArgs e)
        {
            ReadFile();
            Algo();          
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            table_button.Visible = false;
            Load_String();
            Load_Table();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
