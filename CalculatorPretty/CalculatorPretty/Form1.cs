using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorPretty
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public static string previousEquation = "";
        public static string prevOperation = "";
        public static string operation = "";
        public static double answer = 0;

        private void allBtnClick(Object sender, EventArgs e)
        {
            Button btn = sender as Button;

            switch(btn.Name)
            {
                case "ceBtn":
                    textDisplay.ResetText();
                    break;
                case "cBtn":
                    operation = "";
                    textDisplay.ResetText();
                    textDisplay2.ResetText();
                    break;
                case "delBtn":
                    if (textDisplay.Text.Length > 0)
                    {
                        textDisplay.Text = textDisplay.Text.Substring(0, textDisplay.Text.Length - 1);
                    }
                    break;
                case "plusMinBtn":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (!textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = "-" + textDisplay.Text;
                        } else if (textDisplay.Text.Contains("-"))
                        {
                            textDisplay.Text = textDisplay.Text.Substring(1, textDisplay.Text.Length - 1);
                        }
                    }
                    break;
                case "dotBtn":
                    if (!textDisplay.Text.Contains("."))
                    {
                        textDisplay.Text += ".";
                    }
                    break;
                default:
                    if (operation == "-")
                    {
                        operation = "";
                        textDisplay.ResetText();
                    }
                    textDisplay.Text += btn.Text;
                    break;
            }
        }

        private void operationClick(Object sender, EventArgs e)
        {
            Button opr = sender as Button;

            //MessageBox.Show(opr.Text);

            switch(opr.Text)
            {
                case "+":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "+";
                            prevOperation = operation;
                            previousEquation = textDisplay.Text;
                            textDisplay2.Text = previousEquation + operation;
                            textDisplay.ResetText();
                        }
                    } else
                    {
                        operation = "+";
                        multiOperations();
                    }
                    break;
                case "-":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "-";
                            prevOperation = operation;
                            previousEquation = textDisplay.Text;
                            textDisplay2.Text = previousEquation + operation;
                            textDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "-";
                        multiOperations();
                    }
                    break;
                case "/":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "/";
                            prevOperation = operation;
                            previousEquation = textDisplay.Text;
                            textDisplay2.Text = previousEquation + operation;
                            textDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "/";
                        multiOperations();
                    }
                    break;
                case "x":
                    if (textDisplay.Text.Length > 0)
                    {
                        if (operation == "" || operation == "=")
                        {
                            operation = "x";
                            prevOperation = operation;
                            previousEquation = textDisplay.Text;
                            textDisplay2.Text = previousEquation + operation;
                            textDisplay.ResetText();
                        }
                    }
                    else
                    {
                        operation = "x";
                        multiOperations();
                    }
                    break;
                case "=":
                    if (textDisplay.Text.Length > 0)
                    {
                        operation = "=";
                        multiOperations();
                        textDisplay2.ResetText();
                        textDisplay.Text = answer.ToString();
                    }
                    break;
            }
        }

        public void multiOperations()
        {
            if (prevOperation == "+")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(previousEquation) + Convert.ToDouble(textDisplay.Text);
                previousEquation = answer.ToString();
                textDisplay.Text = previousEquation + operation;
                textDisplay2.ResetText();
            } else if (prevOperation == "-")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(previousEquation) - Convert.ToDouble(textDisplay.Text);
                previousEquation = answer.ToString();
                textDisplay.Text = previousEquation + operation;
                textDisplay2.ResetText();
            } else if (prevOperation == "x")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(previousEquation) * Convert.ToDouble(textDisplay.Text);
                previousEquation = answer.ToString();
                textDisplay.Text = previousEquation + operation;
                textDisplay2.ResetText();
            } else if (prevOperation == "/")
            {
                prevOperation = operation;
                answer = Convert.ToDouble(previousEquation) / Convert.ToDouble(textDisplay.Text);
                previousEquation = answer.ToString();
                textDisplay.Text = previousEquation + operation;
                textDisplay2.ResetText();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
