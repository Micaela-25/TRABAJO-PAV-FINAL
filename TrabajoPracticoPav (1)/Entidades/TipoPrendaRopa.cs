using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico
{
    public class TipoPrendaRopa
    {
        private string Nombre;
        private string Descripción;
        
        public TipoPrendaRopa()
        {
            Nombre = "";
            Descripción = "";
        }

        public TipoPrendaRopa(string NombreTipo, string DescrTipo)
        {
            Nombre = NombreTipo;
            Descripción = DescrTipo;
        }

        public string nombre
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string descripcion
        {
            get => Descripción;
            set => Descripción = value;
        }

    }
}
