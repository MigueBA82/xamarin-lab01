using Xamarin.Forms;

namespace MobileApp
{
    public partial class App
    {
        public class HelloWorldPage: ContentPage
		{
			public HelloWorldPage()
			{
				var label = new Label()
				{
					Text = "Hello, World",
					FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
                };
				var button = new Button
				{
					Text = "Clik me!"
				};
				int i = 0;
				button.Clicked += (s, e) =>{
					button.Text = "Hello, World!"+ i++;
				};

				Content = new StackLayout
				{
					BackgroundColor = Color.Transparent,
				 VerticalOptions= LayoutOptions.Start,
				 HorizontalOptions= LayoutOptions.Center,
				 Children ={ label, button}
				};
				Title = "HelloWorldPage";
			}
		}
	}
}