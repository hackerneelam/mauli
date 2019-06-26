using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathLibrary;
namespace Calculators
{
    delegate void ArithmaticOp(int num1, int num2);
    public partial class Form1 : Form
    {

        string fnoperatop="";

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Num1textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void operationcomboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fnoperatop = operationcomboBox1.SelectedItem.ToString();
        }

        private void num2textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(Num1textBox1.Text);
            int num2 = int.Parse(num2textBox2.Text);

            Class1 calc = new Class1();

            switch(fnoperatop)
            {
                case "+":
                    ArithmaticOp op1 = new ArithmaticOp(calc.Add);
                    op1(num1, num2);
                    break;

                case "-":
                    ArithmaticOp op2 = new ArithmaticOp(calc.Sub);
                    op2(num1, num2);
                    break;

                case "*":
                    ArithmaticOp op3 = new ArithmaticOp(calc.Mul);
                    op3(num1, num2);
                    break;

                case "/":
                    ArithmaticOp op4 = new ArithmaticOp(calc.Div);
                    op4(num1, num2);
                    break;

                   
            }
            int result = calc.Result;
            resultlabel1.Text = result.ToString();
        }
    }
}
