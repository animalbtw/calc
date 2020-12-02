using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcHardTry
{
    public partial class Form1 : Form
    {

        public string CurrentValue;
       
        public string Symbol;
        public bool ValueCath;

        public Form1()
        {
            ValueCath = false;
            InitializeComponent();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (ValueCath)
            {
                ValueCath = false;
                textBox1.Text = "0";
            }
            Button button = (Button)sender;
            if (textBox1.Text == "0")
            {
                textBox1.Text = button.Text;
            } else
            {
                textBox1.Text = textBox1.Text + button.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Symbol = button.Text;
            CurrentValue = textBox1.Text;
            ValueCath = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double FirstValue, SecondValue, Result;
            Result = 0;
            FirstValue = Convert.ToDouble(CurrentValue);
            SecondValue = Convert.ToDouble(textBox1.Text);
            
            switch (Symbol)
            {
                case "+":
                    Result = FirstValue + SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "-":
                    Result = FirstValue - SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "":
                    Result = FirstValue * SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
                case "/":
                    Result = FirstValue / SecondValue;
                    textBox1.Text = Result.ToString();
                    break;
            }

        }

        private void button7_Click(object sender, EventArgs e)
        {
            double Result, Value;
            Value = Convert.ToDouble(textBox1.Text);
            Result = Math.Pow(Value, 2);
            textBox1.Text = Result.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double Result, Value;
            Value = Convert.ToDouble(textBox1.Text);
            Result = Math.Sqrt(Value);
            textBox1.Text = Result.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double FirstValue, SecondValue, Result;
            Result = 0;
            FirstValue = Convert.ToDouble(textBox1.Text);
            SecondValue = Convert.ToDouble(CurrentValue);
            Result = System.Math.Round(FirstValue / SecondValue * 100);
            textBox1.Text = Result.ToString();
        }
    }
}
