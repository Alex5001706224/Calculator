using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5._1
{


    public partial class Form1 : Form
    {
        double a = 0;
        double b = 0;
        double f = 0;
        bool c = false;
        string d;



        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "3";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "0";
            if (d == "/")
            {
                textBox1.Text = "Invalid Denominator Zero";


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "2";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (c == true)
            {
                textBox1.Text = "";
                c = false;
            }
            textBox1.Text += ".";
        }

        private void btPlus_Click(object sender, EventArgs e)
        {
            c = true;
            a = double.Parse(textBox1.Text);
            d = "+";

        }

        private void btMinus_Click(object sender, EventArgs e)
        {
            c = true;
            a = double.Parse(textBox1.Text);
            d = "-";
        }

        private void btMultiply_Click(object sender, EventArgs e)
        {
            c = true;
            //textBox1.Text += "*";
            a = double.Parse(textBox1.Text);
            d = "*";
        }

        private void btDivide_Click(object sender, EventArgs e)
        {
            c = true;
            //textBox1.Text += "/";
            a = double.Parse(textBox1.Text);
            d = "/";
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            Calculator sub = new Calculator();
            switch (d)
            {
                case "+":
                 
                    b = double.Parse(textBox1.Text);
                    f = sub.Add(a, b);
                    break;
                case "-":
                    b = double.Parse(textBox1.Text);
                    f = sub.Subtract(a, b);
                    break;
                case "*":
                    b = double.Parse(textBox1.Text);
                    f = sub.Multiply(a, b);
                    break;
                case "/":
                    b = double.Parse(textBox1.Text);
                    f = sub.Divide(a, b);
                    break;
            }
            textBox1.Text = f + "";
            c = true;
        }

        private void btAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
        class Calculator : ICalculator
        {
            public double Add(double a, double b) { return a + b; }
            public double Subtract(double a, double b) { return a - b; }
            public double Multiply(double a, double b) { return a * b; }
            public double Divide(double a, double b)
            {
                    return a / b;
                }
            }
        }

    }


