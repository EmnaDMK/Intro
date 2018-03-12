using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Intro
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SwitchExample : ContentPage
	{
		public SwitchExample ()
		{
			InitializeComponent ();
            mySwitch.Toggled += (sender, e) =>
              {
                  if (e.Value == true)
                  {
                      BackgroundColor = Color.Black;
                  }
                  else
                  {
                      BackgroundColor = Color.White;
                  }
              };
		}
	}
}