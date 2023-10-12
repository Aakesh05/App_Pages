namespace PageOrientations.Pages.Navigation_Pages_;

public partial class NavPage2 : ContentPage
{
	public NavPage2()
	{
		InitializeComponent();
	}

    private async void navCloseButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PopAsync();
    }

    private async void navContentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new NavPage3());
    }
}