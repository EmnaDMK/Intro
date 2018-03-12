using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Intro
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        public void Display( Object sender , EventArgs e)
        {
            lblMessage.Text = "Welcome Mr." + txtName.Text;
            lblMessage.TextColor = Color.Purple;
            lblMessage.BackgroundColor = Color.White;
        }
	}
}
