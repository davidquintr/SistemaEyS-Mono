using System;
namespace Entidades 
{
    public class Tbl_Departamento {

        private String nombre;
        private String ext;
        private String email;
        private String descripcion;
        private int estado;

        public Tbl_Departamento() {


        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Ext { get => ext; set => ext = value; }
        public string Email { get => email; set => email = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
    }
}
