namespace PageOrientations.Pages.Navigation_Pages_;

public partial class NavPage3 : ContentPage
{
	public NavPage3()
	{
		InitializeComponent();
	}

    private async void navContentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage2());
    }

    private async void navContentPageBackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage1());
    }
}