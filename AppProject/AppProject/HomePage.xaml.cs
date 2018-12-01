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
	public partial class HomePage : ContentPage
	{
		public HomePage ()
		{
			InitializeComponent ();
        }

         // Navigation events for HomePage buttons

        async void Calculator_Clicked(object sender, EventArgs e)
        {
           await Navigation.PushAsync(new CalculatorPage());
        }

        private void Notepad_Clicked(object sender, EventArgs e)
        {

        }

        async void Flashlight_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new FlashlightPage());
        }

        private void Stopwatch_Clicked(object sender, EventArgs e)
        {

        }
    }
}