using Calculator.Business.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.UI
{
    public partial class Form1 : Form
    {
        private readonly MathService _mathService;
        public Form1(MathService mathService)
        {
            _mathService = mathService;
            InitializeComponent();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains("+") || textBox1.Text.Contains("*") || textBox1.Text.Contains("/") || textBox1.Text.Contains("-"))
                textBox1.Text = _mathService.CheckResult(textBox1.Text);

            //DataTable dataTable = new DataTable();
            //foreach (Match item in Regex.Matches(textBox1.Text, @"(-?\d+)\s*([+\-])\s*(-?\d+)", RegexOptions.None))
            //{
            //    var result = dataTable.Compute(item.Value.ToString(),null);
            //    textBox1.Text = textBox1.Text.Replace(item.Value.ToString(),result.ToString());
            //}
            //foreach (Match item in Regex.Matches(textBox1.Text, @"(-?\d+)\s*([*\/])\s*(-?\d+)", RegexOptions.None))
            //{
            //    var result = dataTable.Compute(item.Value.ToString(), null);
            //    textBox1.Text = textBox1.Text.Replace(item.Value.ToString(), result.ToString());
            //}
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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text += "/";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
