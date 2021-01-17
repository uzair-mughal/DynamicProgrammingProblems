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
    public partial class LIS : Form
    {
        private string filename;
        private string str1;
        private int[] arr;
        public LIS(string temp)
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
        private void Algo()
        {
            int n = arr.Length;
            int[] L = new int[n];
            int[,] subseq = new int[n,n];
            
            L[0] = 1;
            subseq[0, 0] = arr[0];

            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {

                    if (arr[j] < arr[i] && L[j] > L[i])
                    {
                        L[i] = L[j];
                        subseq[i,j] = arr[j];
                    }                        
                }
                L[i]++;
            }

            string temp = "";
            for(int i = 1; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (subseq[i, j] != 0)
                        temp += subseq[i, j].ToString() + " ";
                }
                if(L[i]>1)
                    temp += "\r\n";
            }

            int max = -1;

            for(int i = 0; i < n; i++)
            {
                if (max < L[i])
                    max = L[i];
            }
            max--;
            str1_textBox.Text = str1;
            str2_textBox.Text = temp;
            ans_textBox.Text = max.ToString();
        }

        private void LIS_Load(object sender, EventArgs e)
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
    }
}
