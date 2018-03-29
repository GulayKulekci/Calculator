using Calculator;
using Calculator.UWP.Renderers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Automation.Peers;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace Calculator.UWP.Renderers
{
	public class CustomButtonRenderer : ButtonRenderer
	{	

		protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
		{
			base.OnElementChanged(e);

			if (Control != null)
			{				
				(Control as FormsButton).PointerEntered += CustomButtonRenderer_PointerEntered;
				(Control as FormsButton).PointerExited += CustomButtonRenderer_PointerExited;
			}

		}

		//Bir sayfadan başka bir sayfaya geçtiğinde burdaki rendererlar ile UI arasındaki bağlantıları koparır bu render'lar boşa hafıza kaplamaz.
		protected override void Dispose(bool disposing)
		{
			Control.PointerExited -= CustomButtonRenderer_PointerExited;
			Control.PointerEntered -= CustomButtonRenderer_PointerEntered;

			base.Dispose(disposing);
		}

		private void CustomButtonRenderer_PointerExited(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255, 231, 231, 230));
		}

		private void CustomButtonRenderer_PointerEntered(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
		{
			(sender as FormsButton).BackgroundColor = new SolidColorBrush(Windows.UI.Color.FromArgb(255,215,215,217));
			(sender as FormsButton).BorderThickness = new Windows.UI.Xaml.Thickness(0.0);
		}
		
	}
}
