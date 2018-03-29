using Calculator;
using Calculator.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomButtonMemory), typeof(CustomButtonMemoryRenderer))]

namespace Calculator.UWP.Renderers
{
	public class CustomButtonMemoryRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			(Control as FormsButton).PointerEntered += CustomButtonMemoryRenderer_PointerEntered;
			(Control as FormsButton).PointerExited += CustomButtonMemoryRenderer_PointerExited;

		}

		private void CustomButtonMemoryRenderer_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 231, 231, 230));

		}

		private void CustomButtonMemoryRenderer_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor= new SolidColorBrush(Windows.UI.Color.FromArgb(255, 213, 213, 212));
		}
	}
}
