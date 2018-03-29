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

[assembly: ExportRenderer(typeof(CustomButtonLeftTop), typeof(CustomButtonLeftTopRenderer))]
namespace Calculator.UWP.Renderers
{
	public class CustomButtonLeftTopRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
		{
			base.OnElementChanged(e);
			(Control as FormsButton).PointerEntered += CustomButtonLeftTopRenderer_PointerEntered1;
			(Control as FormsButton).PointerExited += CustomButtonLeftTopRenderer_PointerExited1;
		}

		private void CustomButtonLeftTopRenderer_PointerExited1(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 232, 235, 236));
		}

		private void CustomButtonLeftTopRenderer_PointerEntered1(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 213, 213, 212));
			(sender as FormsButton).BorderThickness = new Windows.UI.Xaml.Thickness(0.0);
		}		
	}
}
