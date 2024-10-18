namespace BibliotecaClasesRE3Maui7
{

    // Enum
    public enum ColoresBoton : byte { Blue, Green, Red }

    public class EstadosBotones : Button
    {
        // MIEMBROS
        private Button _boton;

        // CONSTRUCTORES

        public EstadosBotones(Button boton, ColoresBoton coloresBoton)
        {
            _boton = boton;
            _boton.BackgroundColor = ObtenerColor(coloresBoton);
        }




        // PROPIEDADES

        public Button Boton
        {
            get
            {
                return _boton;
            }

        }

        // MÉTODOS

        public void AsignacionColores()
        {
            if (_boton.BackgroundColor == Colors.Blue) _boton.BackgroundColor = Colors.Green;
            else if (_boton.BackgroundColor == Colors.Green) _boton.BackgroundColor = Colors.Red;
            else _boton.BackgroundColor = Colors.Blue;
        }

        // Método para convertir el enum a un color 
        private Color ObtenerColor(ColoresBoton coloresBoton)
        {
            Color color = new Color();

            switch (coloresBoton)
            {
                case ColoresBoton.Blue:
                    color = Colors.Blue;
                    break;

                case ColoresBoton.Green:
                    color = Colors.Green;
                    break;

                case ColoresBoton.Red:
                    color = Colors.Red;
                    break;
            }

            return color;


        }


    }
}
