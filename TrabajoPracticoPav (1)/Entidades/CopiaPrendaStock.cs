using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Entidades
{
    public class CopiaPrendaStock
    {
        private string Nombre;
        private string Descripción;
        private string Marca;
        private string Color;
        private float PrecioUnitario;
        private int Tipo;
        private int Cantidad;
        private int StockActual;
        private int Codigo;
        private int Talle;

        public CopiaPrendaStock (int cod,string nom, string desc, string marca, string color, float Precio, int tipo, int cant, int talle)
        {
            Codigo = cod;
            Nombre = nom;
            Descripción = desc;
            Marca = marca;
            Color = color;
            PrecioUnitario = Precio;
            Tipo = tipo;
            Cantidad = cant;
            StockActual = cant;
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
        public int stockActual
        {
            get => StockActual;
            set => StockActual = value;
        }
        public int codigo
        {
            get => Codigo;
            set => Codigo = value;
        }

        public int talle
        {
            get => Talle;
            set => Talle = value;
        }
    }
}
