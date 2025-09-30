namespace Trivial2
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private async void pagina2_clikcked(object sender, EventArgs a)
        { 
        
            await Navigation.PushAsync(new Capitales());

        }
        private async void pagina3_clikcked(object sender, EventArgs a)
        {
            await Navigation.PushAsync(new Paises());
        }
    }
}
