using System;
namespace Vistas {

    public class Tbl_Vw_Registro {
        private int id;
        private DateTime hEntrada;
        private DateTime hSalida;
        private DateTime hAlmuerzoIn;
        private DateTime hAlmuerzoOut;
        private String usuario;

        public Tbl_Vw_Registro() {
        }

        public int Id { get => id; set => id = value; }
        public DateTime HEntrada { get => hEntrada; set => hEntrada = value; }
        public DateTime HSalida { get => hSalida; set => hSalida = value; }
        public DateTime HAlmuerzoIn { get => hAlmuerzoIn; set => hAlmuerzoIn = value; }
        public DateTime HAlmuerzoOut { get => hAlmuerzoOut; set => hAlmuerzoOut = value; }
        public string Usuario { get => usuario; set => usuario = value; }
    }
}