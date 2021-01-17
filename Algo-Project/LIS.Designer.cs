namespace Algo_Project
{
    partial class LIS
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.disp_groupBox = new System.Windows.Forms.GroupBox();
            this.str1_textBox = new System.Windows.Forms.TextBox();
            this.str2_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.back_button = new System.Windows.Forms.Button();
            this.ans_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.disp_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-4, -10);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1122, 120);
            this.panel1.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(243, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(663, 49);
            this.label1.TabIndex = 1;
            this.label1.Text = "Longest Increasing Subsequence";
            // 
            // disp_groupBox
            // 
            this.disp_groupBox.Controls.Add(this.ans_textBox);
            this.disp_groupBox.Controls.Add(this.label4);
            this.disp_groupBox.Controls.Add(this.str1_textBox);
            this.disp_groupBox.Controls.Add(this.str2_textBox);
            this.disp_groupBox.Controls.Add(this.label3);
            this.disp_groupBox.Controls.Add(this.label2);
            this.disp_groupBox.Location = new System.Drawing.Point(22, 119);
            this.disp_groupBox.Name = "disp_groupBox";
            this.disp_groupBox.Size = new System.Drawing.Size(1031, 602);
            this.disp_groupBox.TabIndex = 11;
            this.disp_groupBox.TabStop = false;
            // 
            // str1_textBox
            // 
            this.str1_textBox.Location = new System.Drawing.Point(186, 46);
            this.str1_textBox.Multiline = true;
            this.str1_textBox.Name = "str1_textBox";
            this.str1_textBox.Size = new System.Drawing.Size(827, 79);
            this.str1_textBox.TabIndex = 6;
            // 
            // str2_textBox
            // 
            this.str2_textBox.Location = new System.Drawing.Point(186, 146);
            this.str2_textBox.Multiline = true;
            this.str2_textBox.Name = "str2_textBox";
            this.str2_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.str2_textBox.Size = new System.Drawing.Size(827, 365);
            this.str2_textBox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "All Sequences:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sequence:";
            // 
            // back_button
            // 
            this.back_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.back_button.Location = new System.Drawing.Point(12, 739);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 36);
            this.back_button.TabIndex = 10;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // ans_textBox
            // 
            this.ans_textBox.Location = new System.Drawing.Point(186, 547);
            this.ans_textBox.Name = "ans_textBox";
            this.ans_textBox.Size = new System.Drawing.Size(150, 32);
            this.ans_textBox.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "LIS of Length:";
            // 
            // LIS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 787);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.disp_groupBox);
            this.Controls.Add(this.back_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LIS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIS";
            this.Load += new System.EventHandler(this.LIS_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.disp_groupBox.ResumeLayout(false);
            this.disp_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox disp_groupBox;
        private System.Windows.Forms.TextBox str1_textBox;
        private System.Windows.Forms.TextBox str2_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.TextBox ans_textBox;
        private System.Windows.Forms.Label label4;
    }
}