using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


namespace Intro
{
	
	public partial class GestRecogExample : ContentPage
	{
		public GestRecogExample ()
		{
			InitializeComponent ();
            TapGestureRecognizer tap = new TapGestureRecognizer();
            tap.Tapped += (sender, e) =>
            {
                this.BackgroundColor = Color.Purple;
            };
            myLabel.GestureRecognizers.Add(tap);
        }
	}
}