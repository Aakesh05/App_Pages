namespace PageOrientations.Pages;

public partial class ContentPage1 : ContentPage
{
	public ContentPage1()
	{
		InitializeComponent();
	}

    private async void contentPage2Button_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new ContentPage2());
    }
}