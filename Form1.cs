namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double currentValue = 0;
        private string pendingOperator = "";

        private double Calculate(double num1, double num2, string op)
        {
            double result = 0;
            switch (op)
            {
                case "+": result = num1 + num2; break;
                case "-": result = num1 - num2; break;
                case "*": result = num1 * num2; break;
                case "/": result = num1 / num2; break;
            }
            return result;
        }

        private void num0_Click(object sender, EventArgs e)
        {
            boxResult.Text += "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            boxResult.Text += "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            boxResult.Text += "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            boxResult.Text += "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            boxResult.Text += "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            boxResult.Text += "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            boxResult.Text += "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            boxResult.Text += "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            boxResult.Text += "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            boxResult.Text += "9";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            if (!boxResult.Text.Contains("."))
            {
                boxResult.Text += ".";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            boxResult.Text = "";
            currentValue = 0;
            pendingOperator = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (boxResult.Text.Length > 0)
            {
                boxResult.Text = boxResult.Text.Substring(0, boxResult.Text.Length - 1);
            }
        }

        private void btnNeg_Click(object sender, EventArgs e)
        {
            if (boxResult.Text.StartsWith("-"))
            {
                boxResult.Text = boxResult.Text.Substring(1);
            }
            else
            {
                boxResult.Text = "-" + boxResult.Text;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            double typedNumber = double.Parse(boxResult.Text);

            if (pendingOperator == "")
            {
                // first operator pressed — just save the number
                currentValue = typedNumber;
            }
            else
            {
                // an operator was already pending — calculate now, left to right
                currentValue = Calculate(currentValue, typedNumber, pendingOperator);
            }

            pendingOperator = "+";
            boxResult.Text = "";   // clear so the next number can be typed fresh
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            double typedNumber = double.Parse(boxResult.Text);

            if (pendingOperator == "")
            {
                // first operator pressed — just save the number
                currentValue = typedNumber;
            }
            else
            {
                // an operator was already pending — calculate now, left to right
                currentValue = Calculate(currentValue, typedNumber, pendingOperator);
            }

            pendingOperator = "-";
            boxResult.Text = "";   // clear so the next number can be typed fresh
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            double typedNumber = double.Parse(boxResult.Text);

            if (pendingOperator == "")
            {
                // first operator pressed — just save the number
                currentValue = typedNumber;
            }
            else
            {
                // an operator was already pending — calculate now, left to right
                currentValue = Calculate(currentValue, typedNumber, pendingOperator);
            }

            pendingOperator = "*";
            boxResult.Text = "";   // clear so the next number can be typed fresh
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            double typedNumber = double.Parse(boxResult.Text);

            if (pendingOperator == "")
            {
                // first operator pressed — just save the number
                currentValue = typedNumber;
            }
            else
            {
                // an operator was already pending — calculate now, left to right
                currentValue = Calculate(currentValue, typedNumber, pendingOperator);
            }

            pendingOperator = "/";
            boxResult.Text = "";   // clear so the next number can be typed fresh
        }

        private void btnEqls_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(boxResult.Text, out double typedNumber))
            {
                MessageBox.Show("Please enter a valid number.");
                return;
            }

            currentValue = Calculate(currentValue, typedNumber, pendingOperator);
            boxResult.Text = currentValue.ToString();
            pendingOperator = "";
        }
    }
}
