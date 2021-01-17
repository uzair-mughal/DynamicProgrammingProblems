using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Algo_Project
{
    public partial class CC : Form
    {
        public CC()
        {
            InitializeComponent();
        }

        private void Algo()
        {
            string raw_text = "----------------Coin Change Problem-------------------\r\n";
            int[] Coins = new int[] { 1, 2, 3, 4 };
            int[] find_MIN = new int[2];
            int Coins_Required = 15;
            int[,] Result = new int[Coins.Length, Coins_Required + 1];

            for (int i = 0; i <= Coins_Required; i++)
            {
                if (Coins[0] == 1)
                {
                    Result[0, i] = i;
                }
                else
                {
                    if (i % Coins[0] == 0)
                    {
                        Result[0, i] = i / Coins[0];
                    }
                }
            }

            for (int i = 1; i < Coins.Length; i++)
            {
                for (int j = 0; j <= Coins_Required; j++)
                {
                    if (j == 0)
                    {
                        Result[i, 0] = 0;
                        continue;
                    }
                    if (Coins[i] > j)
                    {
                        Result[i, j] = Result[i - 1, j];
                    }
                    else
                    {
                        find_MIN[0] = Result[i - 1, j];
                        find_MIN[1] = 1 + Result[i, j - Coins[i]];
                        Result[i, j] = find_MIN.Min();

                    }
                }
            }
            //Output
            for (int i = 0; i < Coins.Length; i++)
            {

                for (int j = 0; j <= Coins_Required; j++)
                {
                    raw_text += Result[i, j].ToString()+" ";
                }
                raw_text += "\r\n";
            }
            console.Text = raw_text;
        }
        private void CoinChange_Load(object sender, EventArgs e)
        {
            Algo();
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            Main_Panel obj = new Main_Panel();
            this.Hide();
            obj.Show();
        }
    }
}
