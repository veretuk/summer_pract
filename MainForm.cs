using System;
using System.Windows.Forms;

namespace Drob_practise
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            operations_box.SelectedIndex = 0;
        }

        public void Input_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (chisl1_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return; 
                }
                if (e.KeyChar == ',' && (chisl1_text.Text.Length == 0 || chisl1_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void chisl2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (chisl2_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == ',' && (chisl2_text.Text.Length == 0 || chisl2_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void Calculate_Click(object sender, EventArgs e)
        {
            index3_text.Text = "";
            result_chisl_text.Text = "";
            result_znam_text.Text = "";
            if (chisl1_text.Text==""||chisl2_text.Text==""|| znam2_text.Text == ""|| znam1_text.Text == "")
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int ch1 = Convert.ToInt32(chisl1_text.Text), ch2 = Convert.ToInt32(chisl2_text.Text), ch3=0;
            int zn1 = Convert.ToInt32(znam1_text.Text), zn2 = Convert.ToInt32(znam2_text.Text), zn3=0;
            if (index1_text.Text == "")
            {
                index1_text.Text = "0";
            }
            if (index2_text.Text == "")
            {
                index2_text.Text = "0";
            }
            int indx1 = Convert.ToInt32(index1_text.Text);
            int indx2 = Convert.ToInt32(index2_text.Text);
            ch1 = zn1 * indx1 + ch1;
            ch2 = zn2 * indx2 + ch2;
            switch (operations_box.SelectedIndex)
            {
                case 0:
                    zn3 = zn1 * zn2;
                    ch3 = ch1 * zn2 + ch2 * zn1;
                    break;
                case 1:
                    zn3 = zn1 * zn2;
                    ch3 = ch1 * zn2 - ch2 * zn1;
                    break;
                case 2:
                    ch3 = ch1 * ch2;
                    zn3 = zn1 * zn2;
                    break;
                case 3:
                    ch3 = ch1 * zn2;
                    zn3 = ch2 * zn1;
                    break;
            }

            int div = GCD(ch3, zn3);
            int a, b;
            a = ch3 / div; //chisl
            b = zn3 / div; //znam
            if (a>b)
            {
                index3_text.Text = (a / b).ToString();
                a = a - (a / b) * b;
            }
            result_chisl_text.Text = a.ToString();
            result_znam_text.Text = b.ToString();
        }

        int GCD(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;
            if (a == b) return a;
            if (a == 1 || b == 1) return 1;
            if ((a % 2 == 0) && (b % 2 == 0)) return 2 * GCD(a / 2, b / 2);
            if ((a % 2 == 0) && (b % 2 != 0)) return GCD(a / 2, b);
            if ((a % 2 != 0) && (b % 2 == 0)) return GCD(a, b / 2);
            return GCD(b, (int)Math.Abs(a - b));
        }

        public void Button_reset(object sender, EventArgs e)
        {
            chisl1_text.Text = "";
            chisl2_text.Text = "";
            znam2_text.Text = "";
            znam1_text.Text = "";
            index3_text.Text = "";
            index2_text.Text = "";
            index1_text.Text = "";
            result_chisl_text.Text = "";
            result_znam_text.Text = "";
        }

        public void znam1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (znam1_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == ',' && (znam1_text.Text.Length == 0 || znam1_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void znam2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (znam2_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == ',' && (znam2_text.Text.Length == 0 || znam2_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void index1_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (index1_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == ',' && (index1_text.Text.Length == 0 || index1_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }
            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void index2_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || e.KeyChar == '-' || e.KeyChar == 8 || e.KeyChar == ',') //разрешение ввода только этих символов
            {
                if (index2_text.Text.Length > 0 && e.KeyChar == '-') //запрет на ввод + или - не в начале 
                {
                    e.Handled = true;
                    return;
                }
                if (e.KeyChar == ',' && (index2_text.Text.Length == 0 || index2_text.Text.LastIndexOf(',') != -1)) //если запятая вводится в начало или она уже есть - запретить
                {
                    e.Handled = true;
                    return;
                }

            }
            else
                e.Handled = true; //иначе - запретить
        }

        public void Author_button_Click(object sender, EventArgs e)
        {
            Author form1 = new Author();
            form1.ShowDialog();
        }

        public void Button_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
