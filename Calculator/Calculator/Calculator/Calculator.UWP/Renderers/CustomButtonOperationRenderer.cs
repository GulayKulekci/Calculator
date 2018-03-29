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

[assembly: ExportRenderer(typeof(CustomButtonOperation), typeof(CustomButtonOperationRenderer))]
namespace Calculator.UWP.Renderers
{
	public class CustomButtonOperationRenderer : ButtonRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			(Control as FormsButton).PointerEntered += CustomButtonOperationRenderer_PointerEntered;
			(Control as FormsButton).PointerExited += CustomButtonOperationRenderer_PointerExited;
		}

		private void CustomButtonOperationRenderer_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 232, 235, 236));
		}

		private void CustomButtonOperationRenderer_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor= new SolidColorBrush(Windows.UI.Color.FromArgb(255, 166, 216, 255));
			(sender as FormsButton).BorderThickness = new Windows.UI.Xaml.Thickness(0.0);
		}
	}
}
