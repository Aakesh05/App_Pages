namespace PageOrientations.Pages.Navigation_Pages_;

public partial class NavPage1 : ContentPage
{
	public NavPage1()
	{
		InitializeComponent();
	}

    private async void navContentPage2Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushAsync(new NavPage2());
    }
}