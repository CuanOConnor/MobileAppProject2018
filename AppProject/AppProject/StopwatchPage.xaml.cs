using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Diagnostics; // imported for this class

namespace AppProject
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class StopwatchPage : ContentPage
	{
        Stopwatch stopwatch; //accessing the imported Diagnostics

		public StopwatchPage ()
		{
			InitializeComponent ();
            stopwatch = new Stopwatch();
            timerText.Text = "00:00:00.0000";
		}

        private void btnStart_Clicked(object sender, EventArgs e)
        {
            if(!stopwatch.IsRunning) // can only start if is not running
            {
                stopwatch.Start(); // starting it up

                // Starting the time and stringifying it to the label
                Device.StartTimer(TimeSpan.FromMilliseconds(100), () =>
                {
                    timerText.Text = stopwatch.Elapsed.ToString();
                    if (!stopwatch.IsRunning)
                    {
                        return false;
                    }
                    else
                    { 
                        return true;
                    } // if/else makes sure to check wether the watch is currently running before returning
                }

                );
            }
           
        }

        // pauses the timer and changes Start to Resume 
        private void btnPause_Clicked(object sender, EventArgs e)
        {
            btnStart.Text = "Resume";
            stopwatch.Stop();
        }

        // resets the timer and restores the text values as well
        private void btnReset_Clicked(object sender, EventArgs e)
        {
            timerText.Text = "00:00:00.0000";
            btnStart.Text = "Start";
            stopwatch.Reset();
        }
    }
}