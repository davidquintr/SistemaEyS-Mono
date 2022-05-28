using System;
namespace Entidades 
{
    public class Tbl_OpcRol {

        private bool activo;
        private int idOpcion;
        private int idRol;


        public Tbl_OpcRol() {
        }

        public bool Activo { get => activo; set => activo = value; }
        public int IdOpcion { get => idOpcion; set => idOpcion = value; }
        public int IdRol { get => idRol; set => idRol = value; }
    }
}
