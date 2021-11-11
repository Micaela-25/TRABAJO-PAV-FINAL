using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Entidades
{
    public class PrendaRopa
    {
        private string Nombre;
        private string Descripción;
        private string Marca;
        private string Color;
        private float PrecioUnitario;
        private int Tipo;
        private int Cantidad;
        private int Talle;
        
        public PrendaRopa ()
        {

        }
        public PrendaRopa(string nombrePrenda, string descripciónPrenda, string marcaPrenda, string colorPrenda, float precioUniPrenda, int tipoPrenda, int cantidadPrenda, int talle)
        {
            Nombre = nombrePrenda;
            Descripción = descripciónPrenda;
            Marca = marcaPrenda;
            Color = colorPrenda;
            PrecioUnitario = precioUniPrenda;
            Tipo = tipoPrenda;
            Cantidad = cantidadPrenda;
            Talle = talle;
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

        public string marca
        {
            get => Marca;
            set => Marca = value;
        }

        public string color
        {
            get => Color;
            set => Color = value;
        }

        public float precioUni
        {
            get => PrecioUnitario;
            set => PrecioUnitario = value;
        }
        public int tipo
        {
            get => Tipo;
            set => Tipo = value;
        }

        public int cantidad
        {
            get => Cantidad;
            set => Cantidad = value;
        }


        public int talle
        {
            get => Talle;
            set => Talle = value;
        }
    }

}
