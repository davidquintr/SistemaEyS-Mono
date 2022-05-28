using System;
namespace Vistas 
{
    public class Tbl_Vw_Cargo {

        private int id;
        private String nombre;
        private String departamento;
        private String descripcion;
        private int estado;

        public Tbl_Vw_Cargo() {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
