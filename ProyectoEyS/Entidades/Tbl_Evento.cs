using System;
namespace Entidades 
{
    public class Tbl_Evento {

        private DateTime fechaInicio;
        private DateTime fechaFin;
        private String razon;
        private String descripcion;
        private int estado;
        private int idEmp;

        public Tbl_Evento() {
        }

        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public DateTime FechaFin { get => fechaFin; set => fechaFin = value; }
        public int Estado { get => estado; set => estado = value; }
        public string Razon { get => razon; set => razon = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
    }
}
