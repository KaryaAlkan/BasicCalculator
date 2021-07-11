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

        int Accu = 0;
        private double Result(string expression)
        {
            System.Data.DataTable table = new DataTable();
            return Convert.ToDouble(table.Compute(expression, String.Empty));
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myTextBox.Text = Accu.ToString();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Accu = 0;
            myTextBox.Text = Accu.ToString();
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") return;
            myTextBox.Text = myTextBox.Text.Trim() + "0";
        }

        private void one_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "4";
        }

        private void five_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if (myTextBox.Text.Trim() == "0") myTextBox.Text = "";
            myTextBox.Text = myTextBox.Text.Trim() + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            myTextBox.Text = myTextBox.Text.Trim() + "+";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            myTextBox.Text = myTextBox.Text.Trim() + "-";
        }

        private void multiple_Click(object sender, EventArgs e)
        {
            myTextBox.Text = myTextBox.Text.Trim() + "*";
        }

        private void divide_Click(object sender, EventArgs e)
        {
            myTextBox.Text = myTextBox.Text.Trim() + "/";
        }

        private void equal_Click(object sender, EventArgs e)
        {
            myTextBox.Text = Result(myTextBox.Text.Trim()).ToString();
        }

       private void myTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}
