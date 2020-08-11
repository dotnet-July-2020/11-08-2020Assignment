using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassCalculator;

namespace WinCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Class1 obj;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Addition_Click(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.Num1 = Convert.ToInt32(txtNum1.Text);
            obj.Num2 = Convert.ToInt32(txtNum2.Text);
            label3.Text = obj.Add().ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.Num1 = Convert.ToInt32(txtNum1.Text);
            obj.Num2 = Convert.ToInt32(txtNum2.Text);
            label3.Text = obj.Sub().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.Num1 = Convert.ToInt32(txtNum1.Text);
            obj.Num2 = Convert.ToInt32(txtNum2.Text);
            label3.Text = obj.Mul().ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.Num1 = Convert.ToInt32(txtNum1.Text);
            obj.Num2 = Convert.ToInt32(txtNum2.Text);
            label3.Text = obj.Div().ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            obj = new Class1();
            obj.Num1 = Convert.ToInt32(txtNum1.Text);
            obj.Num2 = Convert.ToInt32(txtNum2.Text);
            label3.Text = obj.Div().ToString();
        }
    }
}
