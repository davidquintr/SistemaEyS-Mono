using System;
namespace Vistas 
{
    public class Tbl_Vw_Usuario {

        private int id;
        private String username;
        private String clave;
        private String empleado;
        private String rol;
        private int estado;

        public Tbl_Vw_Usuario() {
        }

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Clave { get => clave; set => clave = value; }
        public string Empleado { get => empleado; set => empleado = value; }
        public string Rol { get => rol; set => rol = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
