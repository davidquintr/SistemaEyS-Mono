using System;
namespace Entidades {
    public class Tbl_Horario {

        private DateTime horarioIn;
        private DateTime horarioOut;
        private int tipoHor;
        private bool activo;
        private int idCargo;

        public Tbl_Horario() {
        }

        public DateTime HorarioIn { get => horarioIn; set => horarioIn = value; }
        public DateTime HorarioOut { get => horarioOut; set => horarioOut = value; }
        public int TipoHor { get => tipoHor; set => tipoHor = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }
        public bool Activo { get => activo; set => activo = value; }
    }
}