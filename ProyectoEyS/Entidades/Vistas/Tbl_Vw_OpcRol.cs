using System;
namespace Vistas {
    public class Tbl_Vw_OpcRol {

        private int idOpcRol;
        private bool activo;
        private string nombre;
        private int idRol;


        public int IdOpcRol { get => idOpcRol; set => idOpcRol = value; }
        public bool Activo { get => activo; set => activo = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int IdRol { get => idRol; set => idRol = value; }
    }
}
