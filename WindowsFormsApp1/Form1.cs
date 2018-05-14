using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
                float a, b;
                int count;
        double x,z;
                bool znak = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            textBox1.Text = textBox1.Text + 1;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + 0;
        }

        private void button11_Click(object sender, EventArgs e)
        {
           // textBox1.Text = textBox1.Text + '+';
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 1;
            label1.Text = a.ToString() + "+";
            znak = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
           // textBox1.Text = textBox1.Text + '-';
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 2;
            label1.Text = a.ToString() + "-";
            znak = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + '/';
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 4;
            label1.Text = a.ToString() + "/";
            znak = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //textBox1.Text = textBox1.Text + '*';
            a = float.Parse(textBox1.Text);
            textBox1.Clear();
            count = 3;
            label1.Text = a.ToString() + "*";
            znak = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //b = Convert.ToInt32(b, 2);
            //textBox1.Text = Convert.ToString(b, 10);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
          //  b = int.Parse(b);
            //textBox1.Text = Convert.ToString(a, 2);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            calculate();
            label1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            double gradus = Convert.ToDouble(textBox1.Text);
            double radian = gradus * Math.PI / 180;
            z = 0;
         
            z=Math.Sin(radian);
            textBox1.Text = Convert.ToString(z);
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            double gradus = Convert.ToDouble(textBox1.Text);
            double radian = gradus * Math.PI / 180;
            z = 0;
            z = Math.Cos(radian);
            textBox1.Text = Convert.ToString(z);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            double gradus = Convert.ToDouble(textBox1.Text);
            double radian = gradus * Math.PI / 180;
            z = 0;
            z = Math.Tan(radian);
            textBox1.Text = Convert.ToString(z);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            double gradus = Convert.ToDouble(textBox1.Text);
            double radian = gradus * Math.PI / 180;
            z = 0;
            z = Math.Tan(radian);
            z = 1 / z;
            textBox1.Text = Convert.ToString(z);
        }

        private void calculate()
        {
            switch (count)
            {
                case 1:
                    b = a + float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 2:
                    b = a - float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 3:
                    b = a * float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;
                case 4:
                    b = a / float.Parse(textBox1.Text);
                    textBox1.Text = b.ToString();
                    break;

                default:
                    break;
            }

        }
    }
}
