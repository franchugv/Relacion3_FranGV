using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClasesRE3Maui
{
    public class MiBoton_Jesus : Button
    {
        private enum Estado : byte { Azul, Verde, Rojo }

        // MIMEMBROS
        private Estado _miEstado;

        // CONSTRUCTORES
        // Constructor por defecto
        public MiBoton_Jesus() : base()
        {
            _miEstado = Estado.Azul;
            BackgroundColor = Colors.Blue;
            Clicked += MiBotonClicked;
        }

        // MÉTODOS
        // Evento
        private void MiBotonClicked(object sender, EventArgs e)
        {
            switch (_miEstado)
            {
                case Estado.Azul:
                    _miEstado = Estado.Verde;
                    this.Background = Colors.Green;
                    break;
                case Estado.Verde:
                    _miEstado = Estado.Rojo;
                    this.Background = Colors.Red;
                    break;
                case Estado.Rojo:
                    _miEstado = Estado.Azul;
                    this.Background = Colors.Blue;
                    break;

            }
        }
    
    }
}
