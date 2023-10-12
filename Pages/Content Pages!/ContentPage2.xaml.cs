namespace PageOrientations.Pages;

public partial class ContentPage2 : ContentPage
{
	public ContentPage2()
	{
        InitializeComponent();
	}

    private void InitializeComponent()
    {
        throw new NotImplementedException();
    }

    private async void closeButton_Clicked(object sender, EventArgs e)
    {
		await Navigation.PushModalAsync(new ContentPage1());
    }

    private async void contentPage3Button_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushModalAsync(new ContentPage3());
    }
}