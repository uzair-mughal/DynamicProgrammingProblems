namespace Algo_Project
{
    partial class MCM
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
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.back_button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.parenthesisTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.str1_textBox = new System.Windows.Forms.TextBox();
            this.disp_groupBox = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.disp_groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(835, 426);
            this.button3.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 36);
            this.button3.TabIndex = 5;
            this.button3.Text = "Show Dense Matrix";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(634, 426);
            this.button2.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 36);
            this.button2.TabIndex = 4;
            this.button2.Text = "Show Cost Matrix";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // back_button
            // 
            this.back_button.Location = new System.Drawing.Point(15, 426);
            this.back_button.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.back_button.Name = "back_button";
            this.back_button.Size = new System.Drawing.Size(141, 36);
            this.back_button.TabIndex = 3;
            this.back_button.Text = "Back";
            this.back_button.UseVisualStyleBackColor = true;
            this.back_button.Click += new System.EventHandler(this.back_button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1061, 115);
            this.panel1.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(246, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 49);
            this.label2.TabIndex = 1;
            this.label2.Text = "Matrix Chain Multiplication";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 131);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Parenthesis:";
            // 
            // parenthesisTextBox
            // 
            this.parenthesisTextBox.Location = new System.Drawing.Point(176, 128);
            this.parenthesisTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.parenthesisTextBox.Multiline = true;
            this.parenthesisTextBox.Name = "parenthesisTextBox";
            this.parenthesisTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.parenthesisTextBox.Size = new System.Drawing.Size(847, 102);
            this.parenthesisTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dimensions:";
            // 
            // str1_textBox
            // 
            this.str1_textBox.Location = new System.Drawing.Point(176, 45);
            this.str1_textBox.Multiline = true;
            this.str1_textBox.Name = "str1_textBox";
            this.str1_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.str1_textBox.Size = new System.Drawing.Size(847, 74);
            this.str1_textBox.TabIndex = 9;
            // 
            // disp_groupBox
            // 
            this.disp_groupBox.Controls.Add(this.textBox1);
            this.disp_groupBox.Controls.Add(this.label4);
            this.disp_groupBox.Controls.Add(this.str1_textBox);
            this.disp_groupBox.Controls.Add(this.label3);
            this.disp_groupBox.Controls.Add(this.parenthesisTextBox);
            this.disp_groupBox.Controls.Add(this.label1);
            this.disp_groupBox.Location = new System.Drawing.Point(12, 124);
            this.disp_groupBox.Name = "disp_groupBox";
            this.disp_groupBox.Size = new System.Drawing.Size(1037, 293);
            this.disp_groupBox.TabIndex = 9;
            this.disp_groupBox.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 242);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "Optimal Cost:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(176, 239);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(111, 32);
            this.textBox1.TabIndex = 11;
            // 
            // MCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 477);
            this.Controls.Add(this.disp_groupBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.back_button);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MCM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MCM";
            this.Load += new System.EventHandler(this.MCM_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.disp_groupBox.ResumeLayout(false);
            this.disp_groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button back_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parenthesisTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox str1_textBox;
        private System.Windows.Forms.GroupBox disp_groupBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
    }
}