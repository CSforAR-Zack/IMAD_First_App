namespace IMAD_First_App;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnMagentaClicked(object sender, EventArgs e)
	{
		scrollView.BackgroundColor = Color.Parse("Magenta");
	}

    private void OnOrangeClicked(object sender, EventArgs e)
    {
        scrollView.BackgroundColor = Color.Parse("Orange");
    }

    private void OnResetClicked(object sender, EventArgs e)
    {
        scrollView.BackgroundColor = Color.Parse("White");
    }
}

