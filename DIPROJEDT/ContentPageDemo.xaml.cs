namespace DIPROJEDT;

public partial class ContentPageDemo : ContentPage
{
	public ContentPageDemo()
	{
		InitializeComponent();
	}

    private void OnCounterClicked1(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
        //Navigation.PopAsync();  //botón pop
    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        
        Navigation.PopAsync();  
    }
}
