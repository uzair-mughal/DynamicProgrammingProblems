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
        public int[] cost;
        public int[] dense;

        public MCM(string temp)
        {
            filename = temp;
            InitializeComponent();
        }

        private void ReadFile()
        {
            string[] lines = File.ReadAllLines(filename);
            str1 = lines[0];
            str2 = lines[1];
        }

        private void Algo()
        {

        }
    }
}