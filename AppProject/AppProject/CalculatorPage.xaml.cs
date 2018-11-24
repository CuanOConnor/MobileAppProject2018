using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CalculatorPage : ContentPage
	{
        int currentIndicator = 1;
        string myOperator;
        double firstNumber, secondNumber;

        public CalculatorPage ()
		{
			InitializeComponent ();
            Clear_Clicked(this, null);
		}

        // removes values from varibles and goes to first postion in the indicator
        private void Clear_Clicked(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = 0;
            currentIndicator = 1;
            this.outputBox.Text = "0";
        }

        // using Math.sqrt then outputing to result and outputBox
        private void SquareRoot_Clicked(object sender, EventArgs e)
        {
            if ((currentIndicator == -1) || (currentIndicator == 1))
            {
                var result = Math.Sqrt(firstNumber);

                this.outputBox.Text = result.ToString();
                firstNumber = result;
                currentIndicator = -1;
            }
        }

        //Find the percentage of the first or second variable entered depending on the assigned indicator, then resets the indicator
        private void Percent_Clicked(object sender, EventArgs e)
        {
            if ((currentIndicator == -1) || (currentIndicator == 1))
            {
                var result = firstNumber / 100;
                this.outputBox.Text = result.ToString();
                firstNumber = result;
                currentIndicator = -1;
            }
        }

        // using a simple number*number calculation to add square root functionality..output as seen previously
        private void Squared_Clicked(object sender, EventArgs e)
        {
            if ((currentIndicator == -1) || (currentIndicator == 1))
            {
                var result = firstNumber * firstNumber;
                this.outputBox.Text = result.ToString();
                firstNumber = result;
                currentIndicator = -1;
            }
        }

        private void OnSelectNumber(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string pressed = button.Text;

            //validation before button is pressed
            //if the current result is 0 in text box then we will direct the calculator to exclude 0 when pressing buttons

            if (this.outputBox.Text == "0" || currentIndicator < 0)
            {
                this.outputBox.Text = "";

                if (currentIndicator < 0)
                {
                    currentIndicator *= -1;
                }
            }

            // this condition is used when current the state is greater and text box will aquire the pressed action
            this.outputBox.Text += pressed; 

            double number; //if the user is to assign two dynamic number for a given variable it uses the try parse method check the string to number
            if (double.TryParse(this.outputBox.Text, out number))
            {
                this.outputBox.Text = number.ToString("N0");
                if (currentIndicator == 1)
                {
                    firstNumber = number;//at first current state will be 1 and it will assign first number with the pressed number variable
                }
                else
                {
                    secondNumber = number;//it will be added to variable as the number of current indicator changes to 2
                }
            }
        }

        //Performs the specified action of the operators chosen onto the two assigned numbers
        private void Equals_Clicked(object sender, EventArgs e)
        {
            if (currentIndicator == 2)
            {
                var result = Operators.Calculate(firstNumber, secondNumber, myOperator);

                this.outputBox.Text = result.ToString();
                firstNumber = result;
                currentIndicator = -1;
            }
        }

        // Lowers indicator to outside number and selects the operator of choice and assigns it as a pressed action
        private void OnSelectOperator(object sender, EventArgs e)
        {
            currentIndicator = -2;
            Button button = (Button)sender;
            string pressed = button.Text;
            myOperator = pressed;
        }
    }
}