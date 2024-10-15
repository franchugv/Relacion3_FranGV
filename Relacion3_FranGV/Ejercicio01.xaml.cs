namespace Relacion3_FranGV;

public partial class Ejercicio01 : ContentPage
{

    HorizontalStackLayout filas = new HorizontalStackLayout();


    public Ejercicio01()
	{
		InitializeComponent();
	}

	// MÉTODOS


    private void ClickerButtonGenerar(object sender, EventArgs e)
    {
        bool esValido = true;
        string mensajeError = "";
        try
        {

        

        // Eliminar solo las filas, al eliminar un elemento,
        // los indice cambian, por eso lo hago inverso,
        // si lo hago de derecha a izquierda, los índices no cambian
        for (int indice = MainVSL.Children.Count - 1; indice >= 0; indice--)
        {
            if (MainVSL.Children[indice] is HorizontalStackLayout)
            {
                MainVSL.Children.RemoveAt(indice);
            }
        }

        int cont = 0;

		for (int fila = 0; fila < Metodos.ConvertirInt(EntryNumBotones.Text); fila++)
		{
            filas = new HorizontalStackLayout();

			for(int column = 0; column < Metodos.ConvertirInt(EntryNumBotones.Text); column++)
			{
                cont++;

                filas.Children.Add(CrearBoton(cont.ToString(), 60));
			}

            MainVSL.Add(filas);


		}

        }
        catch(Exception error)
        {
            esValido = false;
            mensajeError = error.Message;
        }
        finally
        {
            if (!esValido) MostrarMensaje($"Error: {mensajeError}");
        }
    }

    private Button CrearBoton(string text, int tamanio)
    {
        Button button = new Button
        {
            Text = text,
            WidthRequest = tamanio,
            HeightRequest = tamanio


        };

        button.Clicked += (s, e) => ButtonClicked(s, e);

        return button;
    }


    private void ButtonClicked(object sender, EventArgs e)
	{
        Button boton = (Button)sender;

        MostrarMensaje(boton.Text);

	}

    private void MostrarMensaje(string mensaje)
    {
        DisplayAlert("Mensaje", mensaje, "Ok");
    }


}