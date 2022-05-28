using System;
namespace Entidades 
{
    public class Tbl_Usuario {

        private String username;
        private String password;
        private int estado;
        private int idRol;

        public Tbl_Usuario() {

        }

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public int Estado { get => estado; set => estado = value; }
        public int IdRol { get => idRol; set => idRol = value; }
    }
}
