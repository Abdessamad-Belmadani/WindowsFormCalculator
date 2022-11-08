using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//calculator

namespace CalcuLator
{
    public partial class Form1 : Form
    {
        private string op;
        private string op1;
        private string ans;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Btn0.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "0";
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "8";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn1_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "1";
        }

        private void Btn2_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "2";
        }

        private void Btn3_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "3";
        }

        private void Btn4_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "4";
        }

        private void Btn5_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "5" ;
        }

        private void Btn6_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "6";
        }

        private void Btn7_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "7";
        }

        private void Btn9_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "9";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void OpPlus_Click(object sender, EventArgs e)
        {
            this.op = "+";
            this.op1 = LblCalc.Text;
        }

        private void OpEgal_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(this.op1);
            int num2 = int.Parse(LblCalc.Text);

            switch (this.op)
            {
                case "+":
                   LblCalc.Text = (num1 + num2).ToString();
                    this.ans = LblCalc.Text;
                   break;
                case "-":
                    LblCalc.Text = (num1 - num2).ToString();
                    this.ans = LblCalc.Text;
                    break;
                case "*":
                    LblCalc.Text = (num1 * num2).ToString();
                    this.ans = LblCalc.Text;
                    break;
                case "/":
                    LblCalc.Text = (num1 / num2).ToString();
                    this.ans = LblCalc.Text;
                    break;
                default:
                    LblCalc.Text = "Invalid Operator";
                    break;


            }
            
           
        }

        private void BtnMult_Click(object sender, EventArgs e)
        {
            this.op = "*";
            this.op1 = LblCalc.Text;
        }

        private void BtnSub_Click(object sender, EventArgs e)
        {
            this.op = "-";
            this.op1 = LblCalc.Text;
        }

        private void BtnDiv_Click(object sender, EventArgs e)
        {
            this.op = "/";
            this.op1 = LblCalc.Text;
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            LblCalc.Text = "";
        }

        private void BtnAns_Click(object sender, EventArgs e)
        {
            LblCalc.Text = this.ans;
        }
    }
}
