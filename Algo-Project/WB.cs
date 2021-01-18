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
    public partial class WB : Form
    {
        private string filename;
        private string name;
        private List<string> dict;
        private int[] lookup;
        public WB(string temp)
        {
            filename = temp;
            InitializeComponent();
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
            name = lines[0];
            dict = new List<string>();
            string temp = string.Empty;

            for (int i = 1; i < lines.Length; i++)
            {
                dict.Add(lines[i]);
                temp += lines[i]+"\r\n";
            }

            str1_textBox.Text = temp;
            str2_textBox.Text = name;
        }
        private bool Algo(string str,int[] lookup)
        {
            int n = str.Length;
            if (n == 0)
                return true;

            if (lookup[n] == -1)
            {
                lookup[n] = 0;

                for (int i = 1; i <= n; i++)
                {
                    string prefix = str.Substring(0, i);

                    if (dict.Contains(prefix) && Algo(str.Substring(i), lookup))
                    {
                        lookup[n] = 1;
                        return true;
                    }
                }
            }
            return lookup[n] == 1;
        }

        private void WB_Load(object sender, EventArgs e)
        {
            ReadFile();
            lookup = new int[name.Length + 1];
            lookup = Enumerable.Repeat(-1, name.Length + 1).ToArray();
            if (Algo(name,lookup))
                ans_textBox.Text = "Input can be segmented";
            else
                ans_textBox.Text = "Input can't be segmented";
        }
    }
}
