using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        double n1 ;
        double n2 ;
        string o = "";
        string p = "";
        string op = "";
        double a;
        double b;
        double c;
        private void button1_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "0";
                textBox1.Text= o;
            }
            else
            {
                p += "0";
                textBox1.Text = o+op + p;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "1";
                textBox1.Text = o;
            }
            else
            {
                p += "1";
                textBox1.Text =o + op + p;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "2";
                textBox1.Text = o;
            }
            else
            {
                p += "2";
                textBox1.Text =o + op + p;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "3";
                textBox1.Text = o;
            }
            else
            {
                p += "3";
                textBox1.Text =o + op + p;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "4";
                textBox1.Text = o;
            }
            else
            {
                p += "4";
                textBox1.Text =o + op + p;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "5";
                textBox1.Text = o;
            }
            else
            {
                p += "5";
                textBox1.Text =o + op + p;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "6";
                textBox1.Text = o;
            }
            else
            {
                p += "6";
                textBox1.Text = o + op + p;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "7";
                textBox1.Text = o;
            }
            else
            {
                p += "7";
                textBox1.Text = o + op + p;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "8";
                textBox1.Text = o;
            }
            else
            {
                p += "8";
                textBox1.Text = o + op + p;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (op == "")
            {
                o += "9";
                textBox1.Text = o;
            }
            else
            {
                p += "9";
                textBox1.Text = o + op + p;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
             op = "+";
            textBox1.Text+= op;
        }

        private void button12_Click(object sender, EventArgs e)
        {
             op = "-";
            textBox1.Text += op;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            op = "*";
            textBox1.Text += op;
        }

        private void button14_Click(object sender, EventArgs e)
        {
             op = "/";
            textBox1.Text += op;
        }

        private void button15_Click(object sender, EventArgs e)
        {
             op = "%";
            textBox1.Text += op;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double n3 = n1 + n2 ;
                string n4 = n3.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "-")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double n3 = n1 - n2;
                string n4 = n3.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "*" || op == "x")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double n3 = n1 * n2  ;
                string n4 = n3.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "/")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double n3 = n1 / n2;
                string n4 = n3.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "%")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double n3 = n1 % n2  ;
                string n4 = n3.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "raiz")
            {
                n1 = double.Parse(o);
                double raizQuadrada = Math.Sqrt(n1);
                string n4 = raizQuadrada.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == "^")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double delta = Math.Pow(n1, n2);
                string n4 = delta.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == " √ ")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double raizCubica = Math.Pow(n1, 1.0 / n2);
                string n4 = raizCubica.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else if (op == " %de ")
            {
                n1 = double.Parse(o);
                n2 = double.Parse(p);
                double resultado = n1 * (n2 / 100);
                string n4 = resultado.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            }
            else
            {
                textBox1.Text = "algo deu errado";
            }
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            n1 = 0;
            n2 = 0;
            o = "";
            p = "";
            op = "";
            textBox1.Text = "";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            op = "raiz";
            textBox1.Text += op;
             n1 = double.Parse(o);
                double raizQuadrada = Math.Sqrt(n1);
                string n4 = raizQuadrada.ToString();
                textBox1.Text = n4;
                n1 = 0;
                n2 = 0;
                o = "";
                p = "";
                op = "";
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            n1 = double.Parse(o);
            double delta = Math.Pow(n1, 2);
            string n4 = delta.ToString();
            textBox1.Text = n4;
            n1 = 0;
            n2 = 0;
            o = "";
            p = "";
            op = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            op = "^";
            textBox1.Text += op;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form2 novoForm = new Form2();
            novoForm.Show();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            op = " √ ";
            textBox1.Text += op;
            
        }

        private void button26_Click(object sender, EventArgs e)
        {
            op = " %de ";
            textBox1.Text += op;
        }
    }
}