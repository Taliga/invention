using System;
using System.Windows.Forms;
using Calculator.OneArgument;
using Calculator.TwoArguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(textBox1.Text);
                double secondNumber = Convert.ToDouble(textBox2.Text);

                ICalculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
                double answerDigit = calculator.Calculate(firstNumber, secondNumber);

                textBox3.Text = answerDigit.ToString();
            }
            catch (Exception exc)
            {
                textBox3.Text = exc.Message;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double firstNumber = Convert.ToDouble(textBox1.Text);

                IOoneCalculator calculator = OneArgumentFactory.CreateCalculator(((Button)sender).Name);
                double answerDigit = calculator.Calculate(firstNumber);

                textBox3.Text = answerDigit.ToString();
            }
            catch (Exception exc)
            {

                textBox3.Text = exc.Message;

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
