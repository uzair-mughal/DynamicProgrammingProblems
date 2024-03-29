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
    public partial class Main_Panel : Form
    {
        private string selected_file;
        private readonly Random rand = new Random();
        public Main_Panel()
        {
            InitializeComponent();
        }
        public Main_Panel(string temp)
        {
            create_Files_ABC();
            InitializeComponent();
        }

        private void quit_button_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            CC obj = new CC(selected_file);
            this.Hide();
            obj.Show();
        }

        private void Fill_ComboBox()
        {

            for (int i = 0; i < 10; i++)
            {
                string fileName = "ABC_";
                files_comboBox.Items.Add(fileName + (i + 1).ToString() + ".txt");
            }
            for (int i = 0; i < 10; i++)
            {
                string fileName = "DEGI_";
                files_comboBox.Items.Add(fileName + (i + 1).ToString() + ".txt");
            }
            for (int i = 0; i < 10; i++)
            {
                string fileName = "FH_";
                files_comboBox.Items.Add(fileName + (i + 1).ToString() + ".txt");
            }
            for (int i = 0; i < 10; i++)
            {
                string fileName = "J_";
                files_comboBox.Items.Add(fileName + (i + 1).ToString() + ".txt");
            }
        }

        private void create_Files_ABC()
        {
            string name1 = "UZAIR";
            string name2 = "MUZAMMIL";
            string seq1 = "";
            string seq2 = "";

            //For 'A' , 'B' and 'C'
            for(int i = 0; i < 10; i++)
            {
                string fileName = "ABC_";

                int len = rand.Next(30, 101);

                for(int j = 0; j < len; j++)
                {
                    seq1 += name1[rand.Next(0, name1.Length)];
                }
                for (int j = 0; j < len; j++)
                {
                    seq2 += name2[rand.Next(0, name2.Length)];
                }


                using (StreamWriter writer = File.CreateText(fileName + (i+1).ToString() + ".txt"))
                {
                    writer.WriteLine(seq1 + "\n" + seq2);
                }
                seq1 = string.Empty;
                seq2 = string.Empty;
            }


            seq1 = string.Empty;

            //For 'D' , 'E' , 'G' and 'I'
            for (int i = 0; i < 10; i++)
            {
                string fileName = "DEGI_";

                int num = rand.Next(0, 101);

                for (int j = 0; j < num; j++)
                {
                    seq1 += rand.Next(30, 101)+",";
                }
                using (StreamWriter writer = File.CreateText(fileName + (i + 1).ToString() + ".txt"))
                {
                    writer.WriteLine(seq1);
                }
                seq1 = string.Empty; 
            }

            seq1 = string.Empty;
            seq2 = string.Empty;

            //For 'F' and 'H'
            for (int i = 0; i < 10; i++)
            {
                string fileName = "FH_";

                int num = rand.Next(10, 101);

                for (int j = 0; j < num; j++)
                {
                    seq1 += rand.Next(1, 101) + ",";
                }
                for (int j = 0; j < num; j++)
                {
                    seq2 += rand.Next(1, 101) + ",";
                }

                using (StreamWriter writer = File.CreateText(fileName + (i + 1).ToString() + ".txt"))
                {
                    writer.WriteLine(seq1);
                    writer.WriteLine(seq2);
                }
                seq1 = string.Empty;
                seq2 = string.Empty;
            }

            string name = "uzair";
            string random = "abcdefghijklmnopqrstuvwxyz";
            seq1 = string.Empty;
            //For 'J'
            for(int i = 0; i < 10; i++)
            {
                string fileName = "J_";
                
                for(int j = 0; j < 100; j++)
                {
                    int len = rand.Next(1, 4);

                    for (int k = 0; k < len; k++)
                    {
                        int ind= rand.Next(0, 26);
                        seq1 += random[ind];
                    }
                    seq1 += "\n";
                }
                using (StreamWriter writer = File.CreateText(fileName + (i + 1).ToString() + ".txt"))
                {
                    writer.WriteLine(name);
                    writer.WriteLine(seq1);
                }
                seq1 = string.Empty;

            }




        }

        private void Main_Panel_Load(object sender, EventArgs e)
        {
            Fill_ComboBox();
            disable_buttons();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LCS obj = new LCS(selected_file);
            obj.Show();
            this.Hide();
            
        }

        private void disable_buttons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;
        }

        private void Update_Buttons()
        {
            if(selected_file[0] == 'A')
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
            }
            if (selected_file[0] == 'D')
            {
                button4.Enabled = true;
                button5.Enabled = true;
                button7.Enabled = true;
                button9.Enabled = true;
            }
            if (selected_file[0] == 'F')
            {
                button6.Enabled = true;
                button8.Enabled = true;
            }
            if (selected_file[0] == 'J')
            {
                button10.Enabled = true;
            }
        }

        private void files_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selected_file = files_comboBox.Text;
            disable_buttons();
            Update_Buttons();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SCS obj = new SCS(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TLD obj = new TLD(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LIS obj = new LIS(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MCM obj = new MCM(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PP obj = new PP(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            KS obj = new KS(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            KS obj = new KS(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RC obj = new RC(selected_file);
            obj.Show();
            this.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            WB obj = new WB(selected_file);
            obj.Show();
            this.Hide();
        }
    }
}
