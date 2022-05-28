using System;
namespace Entidades 
{
    public class Tbl_Config {

        private String nombreEmpresa;
        private DateTime horarioAlmuerzo;
        private int tiempoGracia;
        private String emailDept;

        public Tbl_Config() {
        }

        public string NombreEmpresa { get => nombreEmpresa; set => nombreEmpresa = value; }
        public DateTime HorarioAlmuerzo { get => horarioAlmuerzo; set => horarioAlmuerzo = value; }
        public int TiempoGracia { get => tiempoGracia; set => tiempoGracia = value; }
        public string EmailDept { get => emailDept; set => emailDept = value; }
    }
}
