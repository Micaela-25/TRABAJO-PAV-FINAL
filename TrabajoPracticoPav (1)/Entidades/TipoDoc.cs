using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Entidades
{
    public class TipoDoc
    {

        private string Nombre;
        private string Descripción;
        private int Id;
        private int Borrado;



        public TipoDoc(string NombreTipo, string DescrTipo)
        {
            Nombre = NombreTipo;
            Descripción = DescrTipo;
        }

        public TipoDoc()
        {
            Nombre = "";
            Descripción = "";
            Id = -1;
            Borrado = 0;
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
        public int id
        {
            get => Id;
            set => Id = value;
        }
        public int borrado
        {
            get => Borrado;
            set => Borrado = value;
        }

    }

    
}
