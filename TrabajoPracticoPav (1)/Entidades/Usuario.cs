using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPractico.Entidades
{
    public class Usuario //lo declaramos public para que se pueda acceder en las otras clases
    {   // declaración de atributos
        private string NombreUsu;
        private string Pass;
        private string Rol;
        private int id;
      
        public Usuario(string NombreUsuario, string password, string rol, int IdUsu)
        {
            NombreUsu = NombreUsuario;
            Pass = password;
            Rol = rol;
            id = IdUsu;
         
        }
        
        public Usuario (string NombreUsuario, string password)
        {
            NombreUsu = NombreUsuario;
            Pass = password;
          
        }

        public Usuario(string NombreUsuario, string password, string rol)
        {
            NombreUsu = NombreUsuario;
            Pass = password;
            Rol = rol;
            
        }

        //propiedades
        public string NombreUsuario
        {
            get => NombreUsu;
            set => NombreUsu = value;
        }
        //propiedades
        public string password
        {
            get => Pass;
            set => Pass = value;
        }
        //propiedades
        public string rol
        {
            get => Rol;
            set => Rol = value;

        }

        public int Id
        {
            get => id;
            set => id = value;

        }

    }

    
}
