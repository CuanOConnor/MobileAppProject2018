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
        Image splashImage;

        public SplashScreen()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();

            splashImage = new Image
            {
                Source = "SplashIcon.png",
                WidthRequest = 100,
                HeightRequest = 100
            };

            AbsoluteLayout.SetLayoutFlags(splashImage, AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage, new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            this.BackgroundColor = Color.FromHex("#4a576b");
            this.Content = sub;
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await splashImage.ScaleTo(1, 2000);
            Application.Current.MainPage = new NavigationPage(new HomePage());

        }
	}



	
}