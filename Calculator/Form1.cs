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

        private void button15_Click(object sender, EventArgs e)
        {
            string output = RPN.GetExpression(textBox1.Text); //Преобразовываем выражение в постфиксную запись
            double result = RPN.Counting(output); //Решаем полученное выражение
            textBox2.Text= result.ToString(); //Возвращаем результат
        }
    }
}
