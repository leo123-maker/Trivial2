namespace Trivial2;

public partial class Paises : ContentPage
{
	public Paises()
	{
		InitializeComponent();
	}
	private async void devuelta(object sender, EventArgs a)
	{
		await Navigation.PopAsync();
    }
}