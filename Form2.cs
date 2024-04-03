using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        double a;
        double b;
        double c;
        private void button1_Click(object sender, EventArgs e)
        {
            a = double.Parse(textBox1.Text);    
            b = double.Parse(textBox2.Text);    
            c = double.Parse(textBox3.Text);
            double delta = Math.Pow(b, 2) - 4 * a * c;

            if (delta < 0)
            {
                textBox4.Text ="A equação não possui raízes reais.";
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);
                textBox4.Text = "A equação possui uma raiz real: x = " + x;
            }
            else if(delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                textBox4.Text = "A equação possui duas raízes reais: x1 = " + x1 + " e x2 = " + x2;
            }
            else
            {
                textBox4.Text = "Deu ruim";
            }
        }
    }
}