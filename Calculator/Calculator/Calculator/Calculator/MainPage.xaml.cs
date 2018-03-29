using Xamarin.Forms;
using System;
using Windows.ApplicationModel.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Calculator.ViewModels;

namespace Calculator
{
	public partial class MainPage : ContentPage 
	{
		public MainPage()
		{
			InitializeComponent();

			switch (Windows.System.Profile.AnalyticsInfo.VersionInfo.DeviceFamily)
			{
				case "Windows.Mobile":
					break;
				case "Windows.Desktop":
					ApplicationView.GetForCurrentView().SetPreferredMinSize(new Windows.Foundation.Size{ Width = 480, Height = 320 });
					ApplicationView.PreferredLaunchViewSize = new Windows.Foundation.Size{ Height = 480, Width = 320 };
					ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.PreferredLaunchViewSize;

					if (Windows.Foundation.Metadata.ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
					{
						StatusBar statusBar = Windows.UI.ViewManagement.StatusBar.GetForCurrentView();
						statusBar.BackgroundColor = Windows.UI.Colors.Red;
						statusBar.BackgroundOpacity = 1;
						statusBar.ForegroundColor = Windows.UI.Colors.AntiqueWhite;
					}
					
					

					break;

				case "Windows.Tablet":
					break;

				case "Windows.Universal":
					ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
					ApplicationView.GetForCurrentView().TryResizeView(new Windows.Foundation.Size(250, 300));
					break;

				case "Windows.Team":
					break;

				default:
					ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
					ApplicationView.GetForCurrentView().TryResizeView(new Windows.Foundation.Size(250, 300));
					break;

			}

		

			//ApplicationView.GetForCurrentView().SetPreferredMinSize(new Size(200, 100));
		}

		public void OnTotalButtonClicked(object sender, EventArgs e)
		{
			var button = sender as Button;
			(button.BindingContext as MainViewModel).TotalCommand.Execute(null);

		}
	}
}
