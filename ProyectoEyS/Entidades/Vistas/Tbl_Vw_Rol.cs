using System;
namespace Vistas 
{
    public class Tbl_Vw_Rol {

        private int id;
        private String nombre;
        private int estado;

        public Tbl_Vw_Rol() {
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
