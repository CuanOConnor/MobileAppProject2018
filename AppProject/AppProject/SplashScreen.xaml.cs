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
	public partial class SplashScreen : ContentPage
	{
		public SplashScreen ()
		{
			InitializeComponent ();
            SetupImagesOnPage();
		}

        private void SetupImagesOnPage()
        {
            var assembly = typeof(SplashScreen);

            string strFileName = "AppProject.Assets.Images.SplashIcon.png";

            imageMain.Source = ImageSource.FromResource(strFileName, assembly);
        }

	}
}