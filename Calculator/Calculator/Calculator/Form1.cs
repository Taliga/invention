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
        public Form1()
        {
          
            InitializeComponent();
       


        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            double firstNumber = Convert.ToDouble(textBox1.Text);
            double secondNumber = Convert.ToDouble(textBox2.Text);
           
            Calculator calculator = TwoArgumentsFactory.CreateCalculator(((Button)sender).Name);
            double answerDigit = calculator.Calculate(firstNumber, secondNumber);



            textBox3.Text = answerDigit.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

     

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
}
