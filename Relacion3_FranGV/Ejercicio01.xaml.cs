namespace Relacion3_FranGV;

public partial class Ejercicio01 : ContentPage
{






    public Ejercicio01()
    {
        InitializeComponent();
    }

    // M�TODOS


    private void ClickerButtonGenerar(object sender, EventArgs e)
    {

        // Recursos
        HorizontalStackLayout filasBotones = new HorizontalStackLayout
        {
            HorizontalOptions = LayoutOptions.Center
        };

        int contadorBotones = 0;



        // Eliminar solo las filas, al eliminar un elemento,
        // los indice cambian, por eso lo hago inverso,
        // si lo hago de derecha a izquierda, los �ndices no cambian
        for (int indice = MainVSL.Children.Count - 1; indice >= 0; indice--)
        {
            if (MainVSL.Children[indice] is HorizontalStackLayout)
            {
                MainVSL.Children.RemoveAt(indice);
            }
        }


        // Generaci�n de los botones

        for (int fila = 0; fila < Metodos.ConvertirInt(EntryNumBotones.Text); fila++)
        {
            filasBotones = new HorizontalStackLayout();

            for (int columna = 0; columna < Metodos.ConvertirInt(EntryNumBotones.Text); columna++)
            {
                contadorBotones++;

                // Adici�n a la fila + Subscripci�n al evento
                filasBotones.Children.Add(CrearBoton(contadorBotones.ToString(), 60));
            }

            MainVSL.Add(filasBotones);


        }


    }

    /// <summary>
    /// Adici�n a la fila + Subscripci�n al evento
    /// </summary>
    /// <param name="text">Texto del bot�n</param>
    /// <param name="tamanio">Altura y anchura del bot�n</param>
    /// <returns>Bot�n creado con nuestros ajustes</returns>
    private Button CrearBoton(string text, int tamanio)
    {
        Button button = new Button
        {
            Text = text,
            WidthRequest = tamanio,
            HeightRequest = tamanio,
            BackgroundColor = Colors.Blue,
            TextColor = Colors.White


        };

        button.Clicked += (s, e) => ButtonClicked(s, e);

        return button;
    }


    private void ButtonClicked(object sender, EventArgs e)
    {
        Button boton = (Button)sender;

        if (boton.BackgroundColor == Colors.Blue) boton.BackgroundColor = Colors.Green;
        else if (boton.BackgroundColor == Colors.Green) boton.BackgroundColor = Colors.Red;
        else boton.BackgroundColor = Colors.Blue;

        MostrarMensaje($"Bot�n pulsado: {boton.Text}");
    }

    private void MostrarMensaje(string mensaje)
    {
        DisplayAlert("Notificaci�n", mensaje, "Ok");
    }


}