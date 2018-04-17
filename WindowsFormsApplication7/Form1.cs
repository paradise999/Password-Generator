using System;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
        const int m = 9;
        int v, t, r, l, q;
        double p, s;
        char c;
        char[] pass2;
        char[] mass = { '!', '”', '#', '$', '%', '&', '’', '(', ')', '*' };
        bool f1 = false, f2 = false, f3 = false, f4 = false, f5 = false, f6 = false;
        string alf = "", pass = "", iden;


        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pass2 = new char[m];
            textBox9.Text = "";
            iden = textBox8.Text;
            if (iden.Length == 0)
                MessageBox.Show("Введите идентификатор");
            else
            {
                q = iden.Length % 5;
                string a = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";

                for (int i = 0; i < 1 + q; i++)
                {
                    r = rand.Next(0, mass.Length);
                    pass2[i] = mass[r];
                }
                for (int i = 1 + q; i < m - 1; i++)
                {
                    r = rand.Next(0, a.Length);
                    pass2[i] = a[r];
                }
                string str = "" + rand.Next(0, 9);
                pass2[8] = str[0];
                for (int i = 0; i < pass2.Length; i++)
                {
                    textBox9.Text += pass2[i];
                }

            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
            {
                e.Handled = true;                
            }            
            if (e.KeyChar == '.')
                    e.KeyChar = ',';
            if (e.KeyChar == ',')
                e.Handled = false;

        }

        Random rand = new Random();

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (f1)
                f1 = false;
            else
                f1 = true;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if(f2)
                f2 = false;
            else
                f2 = true;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if(f3)
                f3 = false;
            else
                f3 = true;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(f4)
                f4 = false;
            else
                f4 = true;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if(f5)
                f5 = false;
            else
                f5 = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if(f6)
                f6 = false;
            else
                f6 = true;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            alf = "";
            pass = "";
            p = double.Parse(textBox1.Text);
            v = int.Parse(textBox2.Text);
            t = int.Parse(textBox3.Text);
            s = v * t / p;
            textBox4.Text = s.ToString();
            if (f1)
                alf += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            if (f2)
                alf += "abcdefghijklmnopqrstuvwxyz";
            if (f3)
                alf += "АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
            if (f4)
                alf += "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            if (f5)
                alf += "!”#$%&’()*";
            if (f6)
                alf += "0123456789";
            if (alf.Length == 0)
                MessageBox.Show("Выбирете символы");
            else
            {                
                textBox5.Text = alf.Length.ToString();
                l = (int)Math.Log(s, alf.Length) + 1;
                textBox6.Text = l.ToString();
                for (int i = 0; i < l; i++)
                {
                    r = rand.Next(0, alf.Length);
                    c = alf[r];
                    pass += c;
                }
                textBox7.Text = pass;
            }
        }
    }
}
