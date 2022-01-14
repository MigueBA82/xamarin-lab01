using System;
using Xamarin.Forms;

namespace MobileApp
{
    public partial class App : Application
	{
		public App()
		{
			Button openhello=new  Button { Text = "Go to Hello" };
			var opencontrols = new Button { Text= "Go to controls"};
			var page = new ContentPage
			{
				Content = new StackLayout {
					Orientation= StackOrientation.Vertical,

					Children = { openhello,opencontrols, }
				}
			};
			openhello.Command= new Command(()=> page.Navigation.PushAsync(new HelloWorldPage()));
			opencontrols.Command = new Command(() => page.Navigation.PushAsync(new Views.Controlspage()));
			View titleview = new StackLayout { 
				HorizontalOptions= LayoutOptions.Center,
				VerticalOptions= LayoutOptions.Center,
				Children = { new Label { Text = "Welcome" } }
			};
			NavigationPage.SetTitleView(page, titleview);
			MainPage = new NavigationPage(page);
		}
	}
}