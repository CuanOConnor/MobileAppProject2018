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

        private void Calculator_Clicked(object sender, EventArgs e)
        {

        }

        private void Notepad_Clicked(object sender, EventArgs e)
        {

        }

        private void Flashlight_Clicked(object sender, EventArgs e)
        {

        }

        private void Stopwatch_Clicked(object sender, EventArgs e)
        {

        }
    }
}