namespace VendeSpil.Olivia;

public partial class OliviaStart : ContentPage
{
	public OliviaStart()
	{
		InitializeComponent();
	}

    private async void StartVendespil(object sender, EventArgs e)
    {
		await Shell.Current.GoToAsync(nameof(Vendespil));
    }
}