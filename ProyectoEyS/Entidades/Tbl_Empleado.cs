using System;
namespace Entidades 
{
    public class Tbl_Empleado {

        private String cedula;
        private String primerNombre;
        private String segundoNombre;
        private String primerApellido;
        private String segundoApellido;
        private String direccion;
        private String observacion;
        private String telefono;
        private String emailPersonal;
        private String emailCorporativo;
        private bool sexo;
        private bool actividad;
        private int estado;
        private DateTime fechaNac;
        private DateTime fechaIngr;
        private DateTime fechaAgr;
        private int idCargo;
        private int idUsuario;

        public Tbl_Empleado() {
        }

        public string Cedula { get => cedula; set => cedula = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string EmailPersonal { get => emailPersonal; set => emailPersonal = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }
        public bool Sexo { get => sexo; set => sexo = value; }
        public bool Actividad { get => actividad; set => actividad = value; }
        public int Estado { get => estado; set => estado = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public DateTime FechaIngr { get => fechaIngr; set => fechaIngr = value; }
        public DateTime FechaAgr { get => fechaAgr; set => fechaAgr = value; }
        public int IdCargo { get => idCargo; set => idCargo = value; }
        public int IdUsuario { get => idUsuario; set => idUsuario = value; }
    }
}
