using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()

        {

            InitializeComponent();
        }
        private void AddNumeral(int num)
        {
            string s = num.ToString();
            if (textBox1.Text == "0" || clear == true)
            {
                clear = false;
                textBox1.Text = s;
            }
            else
            {
                textBox1.Text += s;
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        bool clear;
        int num;
        enum operations { add, sub, mult, div }
        operations operation;



        private void buttonEquals_Click(object sender, EventArgs e)
        {
            clear = true;
            int num2 = int.Parse(textBox1.Text);
            switch (operation)
            {
                case operations.add:
                    {
                        int result = num + num2;
                        textBox1.Text = result.ToString();
                        break;
                    }

                case operations.sub:
                    {
                        int result = num - num2;
                        textBox1.Text = result.ToString();
                        break;
                    }
                case operations.mult:
                    {
                        int result = num * num2;
                        textBox1.Text = result.ToString();
                        break;
                    }

                case operations.div:
                    {
                        float result = (float)num / num2;
                        textBox1.Text = result.ToString();
                        break;
                    }
                default:
                    MessageBox.Show("Error-no such operation!");
                    break;

            }
        }




        private void buttonPlus_Click(object sender, EventArgs e)
        {
            clear = true;
            num = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = operations.add;


        }

        private void buttonSub_Click_1(object sender, EventArgs e)
        {
            clear = true;
            num = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = operations.sub;

        }

        private void buttonDiv_Click_1(object sender, EventArgs e)
        {
            clear = true;
            num = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = operations.div;
        }

        private void buttonMult_Click_1(object sender, EventArgs e)
        {
            clear = true;
            num = int.Parse(textBox1.Text);
            textBox1.Text = "";
            operation = operations.mult;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";


        }

        private void buttonPoint_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-" + textBox1.Text;

        }

        private void buttonPerc_Click(object sender, EventArgs e)
        {
            textBox1.Text = "%";
        }
    }

}