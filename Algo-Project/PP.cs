﻿using System;
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
    public partial class PP : Form
    {
        private string filename;
        private string str1;
        private int[] arr;
        private bool [,] T;
        private int left;
        private int right;
        private int sum = 0;
        private int n;

        public PP(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];

            string[] temp = str1.Split(',');


            arr = new int[temp.Length];

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
        private bool subsetSum(int[] arr, int n, int sum)
        {
            T = new bool [n + 1,sum +1];

            for (int j = 1; j <= sum; j++)
                T[0,j] = false;

            for (int i = 0; i <= n; i++)
                T[i,0] = true;

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= sum; j++)
                {
                    if (arr[i - 1] > j)
                        T[i,j] = T[i - 1,j];
                    else
                        T[i,j] = T[i - 1,j] || T[i - 1,j - arr[i - 1]];
                }
            }

            return T[n,sum];
        }
        private void Algo()
        {
            n = arr.Length;
            
            for (int i = 0; i < n; i++)
                sum += arr[i];

            if((sum % 2 == 0) && subsetSum(arr, n, sum / 2))
            {
                ans_textBox.Text = "Yes!, Subsets are available";
            }
            else if(sum % 2 != 0)
            {
                table_button.Enabled = false;
                ans_textBox.Text = "No!, Subsets are not available (ODD SUM)";
            }
            else
            {
                ans_textBox.Text = "No!, Subsets are not available";
            }

            str1_textBox.Text = str1;
        }


        private void PP_Load(object sender, EventArgs e)
        {
            ReadFile();
            Algo();
        }

        private void Load_String()
        {
            int L2 = sum / 2;
            left = 60;
            right = 135;
            for (int i = 0; i <= L2; i++)
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


            int L1 = arr.Length;

            string brack = "";

            left = 10;
            right = 211;
            for (int i = 0; i < L1-1; i++)
            {
                TextBox textBox1 = new TextBox();
                this.Controls.Add(textBox1);
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Location = new System.Drawing.Point(left, right);
                textBox1.Name = "textBox1";
                textBox1.Size = new System.Drawing.Size(44, 32);
                textBox1.TabIndex = 3;
                brack += arr[i].ToString();
                textBox1.Text =  brack;
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;
                right = right + 38;
                brack += ",";
            }

        }

        private void Load_Table()
        {

            left = 60;
            right = 173;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= sum/2; j++)
                {
                    TextBox textBox1 = new TextBox();
                    this.Controls.Add(textBox1);
                    textBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
                    textBox1.ForeColor = System.Drawing.SystemColors.Info;
                    textBox1.Location = new System.Drawing.Point(left, right);
                    textBox1.Name = "textBox1";
                    textBox1.Size = new System.Drawing.Size(44, 32);
                    textBox1.TabIndex = 3;
                    if (T[i, j] == true)
                        textBox1.Text = "T";
                    else
                        textBox1.Text = "F";

                    
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
            this.Location = new Point(400,160);
            this.AutoScroll = true;
            disp_groupBox.Visible = false;
            table_button.Visible = false;
            Load_String();
            Load_Table();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            obj.Show();
            this.Hide();
        }

        private void ans_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
