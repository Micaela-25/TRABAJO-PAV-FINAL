using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico.Entidades
{
    public class Cliente
    {
      
        private string Nombre;
        private string Apellido;
        private int Id_Tipo_Doc;
        private int NroDoc;
        private string Mail;
        private long NroTelefono;

        public Cliente ( string nom, string ape, int tipoDoc, int nroDoc, string mail, long NroTel)
        {
            
            Nombre = nom;
            Apellido = ape;
            Id_Tipo_Doc = tipoDoc;
            NroDoc = nroDoc;
            Mail = mail;
            NroTelefono = NroTel;
        }

        public Cliente()
        {

        }

       

        public string nombre
        {
            get => Nombre;
            set => Nombre = value;
        }

        public string apellido
        {
            get => Apellido;
            set => Apellido = value;
        }

        public int tipoDocu
        {
            get => Id_Tipo_Doc;
            set => Id_Tipo_Doc = value;
        }

        public int nroDocu
        {
            get => NroDoc;
            set => NroDoc = value;
        }

        public string email
        {
            get => Mail;
            set => Mail = value;
        }

        public long nroTele
        { 
            get => NroTelefono;
            set => NroTelefono = value;
        }
    }
}
