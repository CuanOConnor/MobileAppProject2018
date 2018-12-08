using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Lamp.Plugin; // downloaded plugin for functionality

namespace AppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class FlashlightPage : ContentPage
	{
		public FlashlightPage ()
		{
			InitializeComponent ();
		}

        // Simple on and off functionality for flashlight using the plugin downloaded
        private void OnButton_Clicked(object sender, EventArgs e)
        {
            CrossLamp.Current.TurnOn();
        }

        private void OffButton_Clicked(object sender, EventArgs e)
        {
            CrossLamp.Current.TurnOff();
        }
    }
}