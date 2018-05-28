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
               
        public Form1()
        {
            InitializeComponent();
        }

        
        private void button11_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
        }

        private void button14_Click(object sender, EventArgs e)
        {
          
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
           
        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button19_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button20_Click(object sender, EventArgs e)
        {
         
        }

        private void calculate(object sender, EventArgs e)
        {
            double result;
            double one = double.Parse(textBox1.Text);
            double two = double.Parse(textBox2.Text);
           

            switch (((Button)sender).Name)
            {
                case "Plus":
                     result = two + one;
                     break;
                case "Minus":
                    result = one - two;
                    break;
                case "Multiply":
                    result = one * two;
                    break;
                case "Divide":
                    result = one / two;
                    break;
                default:
                    throw new Exception("Unknown operation");

            }
            textBox1.Text = Convert.ToString(result);
        }

        private void caltrig (object sender, EventArgs e)
        {
            double gradus = Convert.ToDouble(textBox1.Text);
            double radian = gradus * Math.PI / 180;
            double z;
            switch (((Button)sender).Name)
            {
                case "Sin":
                z = Math.Sin(radian);
                break;
                case "Cos":
                    z = Math.Cos(radian);
                    break;
                case "Tg":
                    z = Math.Tan(radian);
                    break;
                case "Ctg":
                    z = Math.Tan(radian);
                    z = 1 / z;
                    break;
                default:
                    throw new Exception("Unknown operation");
            }

            textBox1.Text = Convert.ToString(z);
            
        }
    }
}
