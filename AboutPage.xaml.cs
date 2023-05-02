namespace Notes;

public partial class AboutPage : ContentPage
{
	public AboutPage()
	{
		InitializeComponent();
	}

    private async void LearnMore_Clicked(object sender, EventArgs e)
    {
		//This will navigate to a specifed URL in the system browser.

		await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}