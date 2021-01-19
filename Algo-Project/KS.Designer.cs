
namespace Algo_Project
{
    partial class KS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.back_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.disp_groupBox = new System.Windows.Forms.GroupBox();
            this.str2_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.str1_textBox = new System.Windows.Forms.TextBox();
            this.ans_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table_button = new System.Windows.Forms.Button();
            this.value_label = new System.Windows.Forms.Label();
            this.weight_label = new System.Windows.Forms.Label();
            this.disp_groupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // back_button
            // 
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back_button.Location = new System.Drawing.Point(12, 450);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 36);
            this.back_button.TabIndex = 11;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(287, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(496, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "0/1 Knapsack problem";
            // 
            // disp_groupBox
            // 
            this.disp_groupBox.Controls.Add(this.str2_textBox);
            this.disp_groupBox.Controls.Add(this.label3);
            this.disp_groupBox.Controls.Add(this.str1_textBox);
            this.disp_groupBox.Controls.Add(this.ans_textBox);
            this.disp_groupBox.Controls.Add(this.label4);
            this.disp_groupBox.Controls.Add(this.label2);
            this.disp_groupBox.Location = new System.Drawing.Point(12, 130);
            this.disp_groupBox.Name = "disp_groupBox";
            this.disp_groupBox.Size = new System.Drawing.Size(1035, 314);
            this.disp_groupBox.TabIndex = 12;
            this.disp_groupBox.TabStop = false;
            // 
            // str2_textBox
            // 
            this.str2_textBox.Location = new System.Drawing.Point(119, 140);
            this.str2_textBox.Multiline = true;
            this.str2_textBox.Name = "str2_textBox";
            this.str2_textBox.Size = new System.Drawing.Size(894, 74);
            this.str2_textBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Values:";
            // 
            // str1_textBox
            // 
            this.str1_textBox.Location = new System.Drawing.Point(119, 43);
            this.str1_textBox.Multiline = true;
            this.str1_textBox.Name = "str1_textBox";
            this.str1_textBox.Size = new System.Drawing.Size(894, 74);
            this.str1_textBox.TabIndex = 6;
            // 
            // ans_textBox
            // 
            this.ans_textBox.Location = new System.Drawing.Point(194, 245);
            this.ans_textBox.Name = "ans_textBox";
            this.ans_textBox.Size = new System.Drawing.Size(100, 32);
            this.ans_textBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Maximum Profit:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Weights:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 114);
            this.panel1.TabIndex = 10;
            // 
            // table_button
            // 
            this.table_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.table_button.Location = new System.Drawing.Point(908, 450);
            this.table_button.Name = "table_button";
            this.table_button.Size = new System.Drawing.Size(141, 36);
            this.table_button.TabIndex = 13;
            this.table_button.Text = "Show Table";
            this.table_button.UseVisualStyleBackColor = true;
            this.table_button.Click += new System.EventHandler(this.table_button_Click);
            // 
            // value_label
            // 
            this.value_label.AutoSize = true;
            this.value_label.Location = new System.Drawing.Point(68, 174);
            this.value_label.Name = "value_label";
            this.value_label.Size = new System.Drawing.Size(25, 23);
            this.value_label.TabIndex = 9;
            this.value_label.Text = "V";
            this.value_label.Click += new System.EventHandler(this.value_label_Click);
            // 
            // weight_label
            // 
            this.weight_label.AutoSize = true;
            this.weight_label.Location = new System.Drawing.Point(112, 174);
            this.weight_label.Name = "weight_label";
            this.weight_label.Size = new System.Drawing.Size(27, 23);
            this.weight_label.TabIndex = 10;
            this.weight_label.Text = "W";
            // 
            // KS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 503);
            this.Controls.Add(this.weight_label);
            this.Controls.Add(this.back_button);
            this.Controls.Add(this.value_label);
            this.Controls.Add(this.disp_groupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.table_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "KS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KS";
            this.Load += new System.EventHandler(this.KS_Load);
            this.disp_groupBox.ResumeLayout(false);
            this.disp_groupBox.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox disp_groupBox;
        private System.Windows.Forms.TextBox str1_textBox;
        private System.Windows.Forms.TextBox ans_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button table_button;
        private System.Windows.Forms.TextBox str2_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label weight_label;
        private System.Windows.Forms.Label value_label;
    }
}