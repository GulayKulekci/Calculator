using Calculator;
using Calculator.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomButtonNumber), typeof(CustomButtonNumberRenderer))]
namespace Calculator.UWP.Renderers
{
	public class CustomButtonNumberRenderer: ButtonRenderer
	{
	 
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);

			(Control as FormsButton).PointerEntered += CustomButtonNumberRenderer_PointerEntered;
			(Control as FormsButton).PointerExited += CustomButtonNumberRenderer_PointerExited;

		}

		private void CustomButtonNumberRenderer_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 248, 249, 250));

		}

		private void CustomButtonNumberRenderer_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 213, 213, 212));
			(sender as FormsButton).BorderThickness = new Windows.UI.Xaml.Thickness(0.0);
		}
		
	}
}
