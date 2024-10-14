namespace Relacion3_FranGV;

public partial class Ejercicio01 : ContentPage
{

    HorizontalStackLayout filas = new HorizontalStackLayout();


    public Ejercicio01()
	{
		InitializeComponent();
	}

	// MÉTODOS

	private Button CrearBoton(string text, int tamanio)
	{
		Button button = new Button
		{
			Text = text,
			WidthRequest = tamanio
		};

		button.Clicked += (s, e) => ButtonClicked(s, e);

		return button;
	}

    private void GenerarClicked(object sender, EventArgs e)
    {
		int cont = 0;

		for (int fila = 0; fila < ConvertirInt(EntryNumBotones.Text); fila++)
		{
            filas = new HorizontalStackLayout();

			for(int column = 0; column < ConvertirInt(EntryNumBotones.Text); column++)
			{
                cont++;

                filas.Add(CrearBoton(cont.ToString(), 40));
			}

			MainVSL.Add(filas);


		}
    }

    private void ButtonClicked(object sender, EventArgs e)
	{
        Button boton = (Button)sender;

        DisplayAlert("Mensaje", boton.Text, "Ok");
	}


    private int ConvertirInt(string text)
	{
		return Convert.ToInt32(text);
	}
}