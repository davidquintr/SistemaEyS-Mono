using System;
namespace Entidades {
    public class Tbl_Rol {

        private string nombre;
        private int estado;

        public Tbl_Rol() {
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
