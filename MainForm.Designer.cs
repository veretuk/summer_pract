namespace Drob_practise
{
    partial class MainForm
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
            this.chisl1_text = new System.Windows.Forms.TextBox();
            this.Button_Calculate = new System.Windows.Forms.Button();
            this.Button_res = new System.Windows.Forms.Button();
            this.znam1_text = new System.Windows.Forms.TextBox();
            this.chisl2_text = new System.Windows.Forms.TextBox();
            this.znam2_text = new System.Windows.Forms.TextBox();
            this.result_chisl_text = new System.Windows.Forms.TextBox();
            this.result_znam_text = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.index2_text = new System.Windows.Forms.TextBox();
            this.index1_text = new System.Windows.Forms.TextBox();
            this.operations_box = new System.Windows.Forms.ComboBox();
            this.index3_text = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Author_button = new System.Windows.Forms.Button();
            this.Button_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chisl1_text
            // 
            this.chisl1_text.Location = new System.Drawing.Point(49, 40);
            this.chisl1_text.Name = "chisl1_text";
            this.chisl1_text.Size = new System.Drawing.Size(83, 20);
            this.chisl1_text.TabIndex = 0;
            this.chisl1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Input_text_KeyPress);
            // 
            // Button_Calculate
            // 
            this.Button_Calculate.Location = new System.Drawing.Point(47, 130);
            this.Button_Calculate.Name = "Button_Calculate";
            this.Button_Calculate.Size = new System.Drawing.Size(155, 36);
            this.Button_Calculate.TabIndex = 1;
            this.Button_Calculate.Text = "Вычислить";
            this.Button_Calculate.UseVisualStyleBackColor = true;
            this.Button_Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // Button_res
            // 
            this.Button_res.Location = new System.Drawing.Point(323, 130);
            this.Button_res.Name = "Button_res";
            this.Button_res.Size = new System.Drawing.Size(155, 36);
            this.Button_res.TabIndex = 2;
            this.Button_res.Text = "Сбросить";
            this.Button_res.UseVisualStyleBackColor = true;
            this.Button_res.Click += new System.EventHandler(this.Button_reset);
            // 
            // znam1_text
            // 
            this.znam1_text.Location = new System.Drawing.Point(49, 79);
            this.znam1_text.Name = "znam1_text";
            this.znam1_text.Size = new System.Drawing.Size(83, 20);
            this.znam1_text.TabIndex = 3;
            this.znam1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.znam1_text_KeyPress);
            // 
            // chisl2_text
            // 
            this.chisl2_text.Location = new System.Drawing.Point(238, 40);
            this.chisl2_text.Name = "chisl2_text";
            this.chisl2_text.Size = new System.Drawing.Size(83, 20);
            this.chisl2_text.TabIndex = 5;
            this.chisl2_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chisl2_text_KeyPress);
            // 
            // znam2_text
            // 
            this.znam2_text.Location = new System.Drawing.Point(238, 79);
            this.znam2_text.Name = "znam2_text";
            this.znam2_text.Size = new System.Drawing.Size(83, 20);
            this.znam2_text.TabIndex = 6;
            this.znam2_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.znam2_text_KeyPress);
            // 
            // result_chisl_text
            // 
            this.result_chisl_text.Location = new System.Drawing.Point(395, 40);
            this.result_chisl_text.Name = "result_chisl_text";
            this.result_chisl_text.ReadOnly = true;
            this.result_chisl_text.Size = new System.Drawing.Size(83, 20);
            this.result_chisl_text.TabIndex = 7;
            // 
            // result_znam_text
            // 
            this.result_znam_text.Location = new System.Drawing.Point(395, 79);
            this.result_znam_text.Name = "result_znam_text";
            this.result_znam_text.ReadOnly = true;
            this.result_znam_text.Size = new System.Drawing.Size(83, 20);
            this.result_znam_text.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(332, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "------------------------------";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "------------------------------";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(390, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "------------------------------";
            // 
            // index2_text
            // 
            this.index2_text.Location = new System.Drawing.Point(204, 60);
            this.index2_text.Name = "index2_text";
            this.index2_text.Size = new System.Drawing.Size(28, 20);
            this.index2_text.TabIndex = 13;
            this.index2_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.index2_text_KeyPress);
            // 
            // index1_text
            // 
            this.index1_text.Location = new System.Drawing.Point(15, 60);
            this.index1_text.Name = "index1_text";
            this.index1_text.Size = new System.Drawing.Size(28, 20);
            this.index1_text.TabIndex = 14;
            this.index1_text.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.index1_text_KeyPress);
            // 
            // operations_box
            // 
            this.operations_box.FormattingEnabled = true;
            this.operations_box.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
            this.operations_box.Location = new System.Drawing.Point(149, 59);
            this.operations_box.Name = "operations_box";
            this.operations_box.Size = new System.Drawing.Size(43, 21);
            this.operations_box.TabIndex = 15;
            // 
            // index3_text
            // 
            this.index3_text.Location = new System.Drawing.Point(359, 60);
            this.index3_text.Name = "index3_text";
            this.index3_text.ReadOnly = true;
            this.index3_text.Size = new System.Drawing.Size(28, 20);
            this.index3_text.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Дробь 1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(256, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Дробь 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(413, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дробь 3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Операция";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Инд. 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(198, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Инд. 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 40);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(39, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Инд. 3";
            // 
            // Author_button
            // 
            this.Author_button.Location = new System.Drawing.Point(226, 162);
            this.Author_button.Name = "Author_button";
            this.Author_button.Size = new System.Drawing.Size(75, 23);
            this.Author_button.TabIndex = 24;
            this.Author_button.Text = "Об авторе";
            this.Author_button.UseVisualStyleBackColor = true;
            this.Author_button.Click += new System.EventHandler(this.Author_button_Click);
            // 
            // Button_exit
            // 
            this.Button_exit.Location = new System.Drawing.Point(226, 130);
            this.Button_exit.Name = "Button_exit";
            this.Button_exit.Size = new System.Drawing.Size(75, 23);
            this.Button_exit.TabIndex = 25;
            this.Button_exit.Text = "Выход";
            this.Button_exit.UseVisualStyleBackColor = true;
            this.Button_exit.Click += new System.EventHandler(this.Button_exit_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 197);
            this.Controls.Add(this.Button_exit);
            this.Controls.Add(this.Author_button);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.index3_text);
            this.Controls.Add(this.operations_box);
            this.Controls.Add(this.index1_text);
            this.Controls.Add(this.index2_text);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.result_znam_text);
            this.Controls.Add(this.result_chisl_text);
            this.Controls.Add(this.znam2_text);
            this.Controls.Add(this.chisl2_text);
            this.Controls.Add(this.znam1_text);
            this.Controls.Add(this.Button_res);
            this.Controls.Add(this.Button_Calculate);
            this.Controls.Add(this.chisl1_text);
            this.Name = "MainForm";
            this.Text = "Калькулятор дробей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox chisl1_text;
        public System.Windows.Forms.Button Button_Calculate;
        public System.Windows.Forms.Button Button_res;
        public System.Windows.Forms.TextBox znam1_text;
        public System.Windows.Forms.TextBox chisl2_text;
        public System.Windows.Forms.TextBox znam2_text;
        public System.Windows.Forms.TextBox result_chisl_text;
        public System.Windows.Forms.TextBox result_znam_text;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox index2_text;
        public System.Windows.Forms.TextBox index1_text;
        public System.Windows.Forms.ComboBox operations_box;
        public System.Windows.Forms.TextBox index3_text;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Button Author_button;
        public System.Windows.Forms.Button Button_exit;
    }
}

