using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 计算器
{
    public partial class Form1 : Form
    {
        double num,num1,result;
        String operation;
        Boolean Bool = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if(Bool)
            {
                textBox1.Text = "1";
                num1 = 1;
                Bool = false;
            }
            else
            {
                textBox1.Text += "1";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "2";
                num1 = 2;
                Bool = false;
            }
            else
            {
                textBox1.Text += "2";
            }

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "3";
                num1 = 3;
                Bool = false;
            }
            else
            {
                textBox1.Text += "3";
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "5";
                num1 = 5;
                Bool = false;
            }
            else
            {
                textBox1.Text += "5";
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "6";
                num1 = 6;
                Bool = false;
            }
            else
            {
                textBox1.Text += "6";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "7";
                num1 = 7;
                Bool = false;
            }
            else
            {
                textBox1.Text += "7";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "8";
                num1 = 8;
                Bool = false;
            }
            else
            {
                textBox1.Text += "8";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "9";
                num1 = 9;
                Bool = false;
            }
            else
            {
                textBox1.Text += "9";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Bool = true;
            num = double.Parse(textBox1.Text);
            operation = "+";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Bool = true;
            num = double.Parse(textBox1.Text);
            operation = "-";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Bool = true;
            num = double.Parse(textBox1.Text);
            operation = "*";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Bool = true;
            num = double.Parse(textBox1.Text);
            operation = "/";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "";
                Bool = false;
            }
            textBox1.Text += "0";
            if (operation == "/")   //之前按下/号
            {
                textBox1.Clear();    //清空文本框 
                                     //下面弹出警告，请自己尝试下
                MessageBox.Show("除数不能为零", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
  
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+" :  result = num + num1; break;
                case "-" :  result = num - num1; break;
                case "*" :  result = num * num1; break;
                case "/" :  result = num / num1 ; break;
            }
            textBox1.Text = result + "";
            Bool = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (Bool)
            {
                textBox1.Text = "4";
                num1 = 4;
                Bool = false;
            }
            else
            {
                textBox1.Text += "4";
            }
        }

    }
}
