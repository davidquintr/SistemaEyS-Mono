using System;
namespace Vistas 
{
    public class Tbl_Vw_Departamento {

        private int id;
        private String nombre;
        private String ext;
        private String email;
        private String descripcion;
        private int estado;

        public Tbl_Vw_Departamento() {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Ext { get => ext; set => ext = value; }
        public string Email { get => email; set => email = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
