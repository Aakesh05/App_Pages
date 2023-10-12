using PageOrientations.Pages.Navigation_Pages_;

namespace PageOrientations;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new ContentPage();

		var navigationPage = new NavigationPage(new NavPage1());
		navigationPage.BarBackgroundColor = Colors.Firebrick;
		navigationPage.BarTextColor = Colors.Black;
		MainPage = new NavigationPage(new NavPage1());

	}
}
