namespace PageOrientations.Pages;

public partial class ContentPage3 : ContentPage
{
	public ContentPage3()
	{
		InitializeComponent();
	}

    private async void contentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage2());
    }

    private async void contentPageBackButton_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage1());
;    }
}