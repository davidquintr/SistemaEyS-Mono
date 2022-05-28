using System;
namespace Vistas 
{
    public class Tbl_Vw_Empleado {

        private int id;
        private String usuario;
        private String nombres;
        private String apellidos;
        private String sexo;
        private String cedula;
        private String departamento;
        private String cargo;
        private String emailCorporativo;
        private String emailPersonal;
        private DateTime fechaNac;
        private DateTime fechaIngreso;
        private String activo;
        private String telefono;
        private String observacion;
        private String direccion;
        private int estado;

        public Tbl_Vw_Empleado() {
        }

        public int Id { get => id; set => id = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Nombres { get => nombres; set => nombres = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Departamento { get => departamento; set => departamento = value; }
        public string Cargo { get => cargo; set => cargo = value; }
        public string EmailCorporativo { get => emailCorporativo; set => emailCorporativo = value; }
        public string EmailPersonal { get => emailPersonal; set => emailPersonal = value; }
        public DateTime FechaNac { get => fechaNac; set => fechaNac = value; }
        public DateTime FechaIngreso { get => fechaIngreso; set => fechaIngreso = value; }
        public string Activo { get => activo; set => activo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Observacion { get => observacion; set => observacion = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public int Estado { get => estado; set => estado = value; }
    }
}
