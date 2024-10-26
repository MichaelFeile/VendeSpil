namespace VendeSpil.Olivia;

public partial class Vendespil : ContentPage
{
	public Vendespil()
	{
		InitializeComponent();
	}

    private async void Button_Clicked00(object sender, EventArgs e)
    {
        await knap00.ScaleTo(0, 2000);
        knap00.Source = "hund.jpg";
        await knap00.ScaleTo(1, 2000);
    }

    private async void Button_Clicked02(object sender, EventArgs e)
    {
        await knap02.ScaleTo(0, 2000);
        knap02.Source = "hund.jpg";
        await knap02.ScaleTo(1, 2000);
    }

    private async void Button_Clicked01(object sender, EventArgs e)
    {
        await knap01.ScaleTo(0, 2000);
        knap01.Source = "kat.jpg";
        await knap01.ScaleTo(1, 2000);
    }

    private async void Button_Clicked03(object sender, EventArgs e)
    {
        await knap03.ScaleTo(0, 2000);
        knap03.Source = "hest.jpg";
        await knap03.ScaleTo(1, 2000);
    }

    private async void Button_Clicked10(object sender, EventArgs e)
    {
        await knap10.ScaleTo(0, 2000);
        knap10.Source = "hest.jpg";
        await knap10.ScaleTo(1, 2000);
    }

    private async void Button_Clicked12(object sender, EventArgs e)
    {
        await knap12.ScaleTo(0, 2000);
        knap12.Source = "kat.jpg";
        await knap12.ScaleTo(1, 2000);
    }

    private async void Button_Clicked11(object sender, EventArgs e)
    {
        await knap11.ScaleTo(0, 2000);
        knap11.Source = "kanin.jpg";
        await knap11.ScaleTo(1, 2000);
    }

    private async void Button_Clicked13(object sender, EventArgs e)
    {
        await knap13.ScaleTo(0, 2000);
        knap13.Source = "kanin.jpg";
        await knap13.ScaleTo(1, 2000);
    }
}