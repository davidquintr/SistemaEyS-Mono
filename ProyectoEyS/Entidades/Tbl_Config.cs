using System;
namespace Entidades 
{
    public class Tbl_Config {

        private String nombreEmpresa;
        private DateTime hAlmuerzoIn;
        private DateTime hAlmuerzoOut;
        private int tiempoGracia;
        private String emailEmpresa;

        public Tbl_Config() {
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public DateTime HAlmuerzoIn { get => hAlmuerzoIn; set => hAlmuerzoIn = value; }
        public DateTime HAlmuerzoOut { get => hAlmuerzoOut; set => hAlmuerzoOut = value; }
        public int TiempoGracia { get => tiempoGracia; set => tiempoGracia = value; }
        public string EmailEmpresa { get => emailEmpresa; set => emailEmpresa = value; }
    }
}
