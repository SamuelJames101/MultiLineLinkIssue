namespace MultiLineLinkIssue;

public partial class MainPage : ContentPage
{
    public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        myLabel.FontSize++;
    }

    async void TapGestureRecognizer_Tapped(System.Object sender, Microsoft.Maui.Controls.TappedEventArgs e)
    {
        await Application.Current.MainPage.DisplayAlert("Link worked", "I worked", "close");
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        myLabel.FontSize--;
    }
}


