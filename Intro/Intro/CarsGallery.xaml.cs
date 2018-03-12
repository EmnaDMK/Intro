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
	public partial class CarsGallery : CarouselPage
	{
		public CarsGallery ()
		{
            //comment
			InitializeComponent ();

            Car1.Source = ImageSource.FromFile("car1.png");

            Car2.Source = ImageSource.FromResource("Intro.images.car2.png");
                
            Car3.Source = ImageSource.FromUri(new Uri("http://www.pngmart.com/files/4/Ferrari-Sergio-PNG-Pic.png"));
          
        }
	}
}