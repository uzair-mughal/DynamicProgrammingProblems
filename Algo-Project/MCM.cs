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
        private string filename;
        private string str1;
        private string str2;
        private int left;
        private int right;
        private int L1;
        private int L2;
        public int[] dims;
        public long[,] lookup;
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

            dims = new int[temp.Length];

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

        long MatrixChainMultiplication(int[] dims, int i, int j)
        {
            // base case: one matrix
            if (j <= i + 1)
                return 0;

            // stores minimum number of scalar multiplications (i.e., cost)
            // needed to compute the matrix M[i+1]...M[j] = M[i..j]
            long min = 100000000000;
            int k_min = 10000;

            // if sub-problem is seen for the first time, solve it and
            // store its result in a lookup table
            if (lookup[i, j] == 0)
            {
                // take the minimum over each possible position at which the
                // sequence of matrices can be split

                /*
                    (M[i+1]) x (M[i+2]..................M[j])
                    (M[i+1]M[i+2]) x (M[i+3.............M[j])
                    ...
                    ...
                    (M[i+1]M[i+2]............M[j-1]) x (M[j])
                */

                for (int k = i + 1; k <= j - 1; k++)
                {
                    // recur for M[i+1]..M[k] to get a i x k matrix
                    long cost = MatrixChainMultiplication(dims, i, k);

                    // recur for M[k+1]..M[j] to get a k x j matrix
                    cost += MatrixChainMultiplication(dims, k, j);

                    // cost to multiply two (i x k) and (k x j) matrix
                    cost += dims[i] * dims[k] * dims[j];

                    if (cost < min)
                        k_min = k;
                    min = cost;
                }
                lookup[i, j] = min;
                dense[i, j] = k_min;
            }

            // return min cost to multiply M[j+1]..M[j]
            return lookup[i, j];
        }

        private void Algo()
        {

            // Matrix M[i] has dimension dims[i-1] x dims[i] for i = 1..n
            // input is 10 x 30 matrix, 30 x 5 matrix, 5 x 60 matrix
            int n = dims.Length;

            long min_cost = MatrixChainMultiplication(dims, 0, n - 1);

        }

        private void Load_String()
        {
            int len = dims.Length;
            left = 60;
            right = 135;

            for (int i = 0; i < len; i++)
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

            left = 10;
            right = 173;
            for (int i = 0; i < len; i++)
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

        private void button2_Click(object sender, EventArgs e)
        {
            this.AutoScroll = true;
            Load_String();
            Load_Table();
        }

        private void MCM_Load(object sender, EventArgs e)
        {
            ReadFile();
            Algo();
        }
    }
}
