namespace BibliotecaClasesRE3
{
    // Enum
    public enum ColoresBoton : byte { Blue, Green, Red }

    public class EstadosBotones
    {
        // MIEMBROS
        private ColoresBoton _coloresBoton;

        // CONSTRUCTORES

        public EstadosBotones()
        {
            _coloresBoton = ColoresBoton.Blue;
        }

        public EstadosBotones(ColoresBoton coloresBoton)
        {
            ColoresBotones = coloresBoton;
        }

        // PROPIEDADES

        public ColoresBoton ColoresBotones
        {
            get
            {
                return _coloresBoton;
            }
            set
            {
                _coloresBoton = value;
            }
        }

        // MÉTODOS

        public void AsignacionColores()
        {
            if (ColoresBotones == ColoresBoton.Blue) ColoresBotones = ColoresBoton.Green;
            else if (ColoresBotones == ColoresBoton.Green) ColoresBotones = ColoresBoton.Red;
            else ColoresBotones = ColoresBoton.Blue;
        }


    }
}
