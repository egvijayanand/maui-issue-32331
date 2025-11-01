namespace MauiApp1;

public partial class SearchPage : ContentPage
{
	public SearchPage()
	{
		InitializeComponent();
	}

	private async void OnBackClicked(object sender, EventArgs e)
		=> await Shell.Current.GoToAsync("..");
}
