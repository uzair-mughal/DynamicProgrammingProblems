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
        private int[] coins;
        private int[] Result;
        private int Change_Reg = 179;
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


            coins = new int[temp.Length-1];

            int i = 0;
            str1 = string.Empty;
            str1 = "";

            foreach (string obj in temp)
            {
                if (obj == "")
                    break;
                coins[i] = Convert.ToInt32(obj);
                str1 += obj + " ";
                
                i++;
                
            }
        }
        private void Algo()
        {
            Array.Sort(coins);
            int n = coins.Length;
            Result = new int [Change_Reg + 1];
            Result[0] = 0;

            for (int i = 1; i <= Change_Reg; i++)
                Result[i] = int.MaxValue;

            for (int i = 1; i <= Change_Reg; i++)
            {

                for (int j = 0; j < n; j++)
                    if (coins[j] <= i)
                    {
                        int sub_res = Result[i - coins[j]];
                        if (sub_res != int.MaxValue &&
                            sub_res + 1 < Result[i])
                            Result[i] = sub_res + 1;
                    }
            }

            str1_textBox.Text = str1;
            ans_textBox.Text = Result[Change_Reg].ToString();
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
            int L1 = Change_Reg;
            left = 60;
            right = 135;

            Label change_label = new Label();
            this.Controls.Add(change_label);
            change_label.BackColor = System.Drawing.SystemColors.Control;
            change_label.ForeColor = System.Drawing.Color.Black;
            change_label.Location = new System.Drawing.Point(left, right);
            change_label.Name = "label";
            change_label.Size = new System.Drawing.Size(200, 32);
            change_label.TabIndex = 3;
            change_label.Text = "Change Required";

            left = 300;

            Label required_label = new Label();
            this.Controls.Add(required_label);
            required_label.BackColor = System.Drawing.SystemColors.Control;
            required_label.ForeColor = System.Drawing.Color.Black;
            required_label.Location = new System.Drawing.Point(left, right);
            required_label.Name = "label";
            required_label.Size = new System.Drawing.Size(200, 32);
            required_label.TabIndex = 3;
            required_label.Text = "Coins Required";

            for (int i = 0; i <= L1; i++)
            {
                left = 60;
                right += 38;

                TextBox textBox1 = new TextBox();
                this.Controls.Add(textBox1);
                textBox1.BackColor = System.Drawing.Color.White;
                textBox1.ForeColor = System.Drawing.Color.Black;
                textBox1.Location = new System.Drawing.Point(left, right);
                textBox1.Name = "textBox";
                textBox1.Size = new System.Drawing.Size(200, 32);
                textBox1.TabIndex = 3;
                textBox1.Text = i.ToString();
                textBox1.TextAlign = HorizontalAlignment.Center;
                textBox1.ReadOnly = true;

                left = 300;

                TextBox textBox2 = new TextBox();
                this.Controls.Add(textBox2);
                textBox2.BackColor = System.Drawing.Color.Black;
                textBox2.ForeColor = System.Drawing.Color.White;
                textBox2.Location = new System.Drawing.Point(left, right);
                textBox2.Name = "textBox";
                textBox2.Size = new System.Drawing.Size(200, 32);
                textBox2.TabIndex = 3;
                textBox2.Text = Result[i].ToString();
                textBox2.TextAlign = HorizontalAlignment.Center;
                textBox2.ReadOnly = true;
                
            }

            left = 60;
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

        }

        private void ans_textBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
