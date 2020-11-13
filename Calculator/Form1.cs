using AnalaizerClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public RPN rpn = new RPN();
        public Form1()
        {
            InitializeComponent();
        }

        private void one_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void two_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void three_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void four_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void five_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void six_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void seven_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void eight_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void nine_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void zero_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "(";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += ")";
        }

        private void Result_Click_1(object sender, EventArgs e)
        {
            string output = RPN.GetExpression(textBox1.Text); //Преобразовываем выражение в постфиксную запись
            double result = RPN.Counting(output); //Решаем полученное выражение
            textBox2.Text = result.ToString(); //Возвращаем результ
        }

        private void division_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void multiplication_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void minus_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void plus_Click_1(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void deleteAll_Click_1(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

     

    
    }
}
