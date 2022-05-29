using System;
namespace Vistas {
    public class Tbl_Vw_Evento {

        private int idEvento;
        private DateTime fechaInicio;
        private DateTime fechaFin;
        private string razon;
        private string descripcion;
        private string empleadoSel;

        public Tbl_Vw_Evento() {

        }

        public int IdEvento { get => idEvento; set => idEvento = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public string Razon { get => razon; set => razon = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public string EmpleadoSel { get => empleadoSel; set => empleadoSel = value; }
    }

}
