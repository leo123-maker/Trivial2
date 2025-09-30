using Trivial2.Models;
namespace Trivial2;

public partial class Capitales : ContentPage
{
	Random ram = new Random();
	int actual = 0;
	int puntos = 0;
	int indice;
	int correcto1;

	Button[] botones;
    public Capitales()
	{
		InitializeComponent();
		botones = new Button[] { primero , segundo,tercero ,cuarto };
        muestra();

    }
	private void muestra()
	{
		indice = ram.Next(Listas.lpaises.Length);
		String pais = Listas.lpaises[indice];
		String correcto2 = Listas.lcapitales[indice];

		List<String> opciones = new List<String> { correcto2 };

		while (opciones.Count < 4)
		{
			String candi = Listas.lcapitales[ram.Next(Listas.lcapitales.Length)];
			if (!opciones.Contains(candi))
				opciones.Add(candi);
		}
		opciones = opciones.OrderBy(x => ram.Next()).ToList();

		for (int i = 0; i < botones.Length; i++)
		{
			botones[i].Text = opciones[i];
        }
		correcto1 = opciones.IndexOf(correcto2);
    }
}