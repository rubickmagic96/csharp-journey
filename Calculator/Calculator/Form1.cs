using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator {
    public partial class Form1 : Form {
        double operand1;
        double operand2;
        double result;

        public Form1()
        {
            InitializeComponent();
        }

        private void add(object sender, EventArgs e) {
            operand1 = Convert.ToDouble(textOperand1.Text);
            operand2 = Convert.ToDouble(textOperand2.Text);

            result = operand1 + operand2;
            textResult.Text = result.ToString();
        }

        private void substract(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textOperand1.Text);
            operand2 = Convert.ToDouble(textOperand2.Text);

            result = operand1 - operand2;
            textResult.Text = result.ToString();
        }

        private void divide(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textOperand1.Text);
            operand2 = Convert.ToDouble(textOperand2.Text);

            result = operand1 / operand2;
            textResult.Text = result.ToString();
        }

        private void multiply(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(textOperand1.Text);
            operand2 = Convert.ToDouble(textOperand2.Text);

            result = operand1 * operand2;
            textResult.Text = result.ToString();
        }

        private void textOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textOperand1.Text.Contains('.') == true : true))
            {
                e.Handled = true;
            }
        }

        private void textOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? textOperand2.Text.Contains('.') == true : true))
            {
                e.Handled = true;
            }
        }
    }
}
