using System;
using System.Web.UI;

namespace tasks_3_7
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x + y);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x - y);
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x * y);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            PerformCalculation((x, y) => x / y);
        }

        private void PerformCalculation(Func<decimal, decimal, decimal> operation)
        {
            if (decimal.TryParse(number1.Text, out decimal num1) && decimal.TryParse(number2.Text, out decimal num2))
            {
                try
                {
                    decimal result = operation(num1, num2);
                    resultLabel.Text =  result.ToString();
                }
                catch (DivideByZeroException)
                {
                    resultLabel.Text = "Error: Division by zero!";
                }
            }
            else
            {
                resultLabel.Text = "Please enter valid numbers.";
            }
        }
    }
}
