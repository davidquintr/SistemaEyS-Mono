using System;
namespace Entidades 
{
    public class Tbl_Registro {

        private DateTime horaEntrada;
        private DateTime horaSalida;
        private DateTime horaAlmuerzoIn;
        private DateTime horaAlmuerzoOut;
        private int idEmp;

        public Tbl_Registro() {
        }

        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSalida { get => horaSalida; set => horaSalida = value; }
        public DateTime HoraAlmuerzoIn { get => horaAlmuerzoIn; set => horaAlmuerzoIn = value; }
        public DateTime HoraAlmuerzoOut { get => horaAlmuerzoOut; set => horaAlmuerzoOut = value; }
        public int IdEmp { get => idEmp; set => idEmp = value; }
    }
}