namespace VendeSpil
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(Albert.AlbertStart), typeof(Albert.AlbertStart));
            Routing.RegisterRoute(nameof(Far.FarStart), typeof(Far.FarStart));
            Routing.RegisterRoute(nameof(Julius.JuliusStart), typeof(Julius.JuliusStart));
            Routing.RegisterRoute(nameof(Olivia.OliviaStart), typeof(Olivia.OliviaStart));
        }
    }
}