using System;
namespace Entidades 
{
    public class Tbl_Cargo {

        private String nombre;
        private String descripcion;
        private int estado;
        private int idDept;

        public Tbl_Cargo() {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int Estado { get => estado; set => estado = value; }
        public int IdDept { get => idDept; set => idDept = value; }
    }
}
