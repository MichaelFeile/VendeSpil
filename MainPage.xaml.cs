namespace VendeSpil
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnAlbertClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Albert.AlbertStart));
        }

        private async void OnFarClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Far.FarStart));
        }

        private async void OnOliviaClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Olivia.OliviaStart));
        }

        private async void OnJuliusClicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync(nameof(Julius.JuliusStart));
        }
    }
}