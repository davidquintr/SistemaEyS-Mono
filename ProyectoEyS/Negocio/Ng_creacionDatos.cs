using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using Vistas;

namespace Negocio {
    internal class Ng_creacionDatos {

        public Tbl_Departamento CargarDepartamento(string[] datos) {
            Tbl_Departamento departamento = new Tbl_Departamento();

            departamento.Nombre = datos[1];
            departamento.Ext = datos[2];
            departamento.Email = datos[3];
            departamento.Descripcion = datos[4];
            departamento.Estado = int.Parse(datos[5]);

            return departamento;
        }

        public Tbl_Vw_Departamento CargarVwDepartamento(string[] datos) {
            Tbl_Vw_Departamento departamento = new Tbl_Vw_Departamento();

            departamento.Id = int.Parse(datos[0]);
            departamento.Nombre = datos[1];
            departamento.Ext = datos[2];
            departamento.Email = datos[3];
            departamento.Descripcion = datos[4];
            departamento.Estado = int.Parse(datos[5]);

            return departamento;
        }

        public Tbl_Cargo CargarCargo(string[] datos) {
            Tbl_Cargo cargo = new Tbl_Cargo();

            cargo.Nombre = datos[1];
            cargo.Descripcion = datos[2];
            cargo.Estado = int.Parse(datos[3]);
            cargo.IdDept = int.Parse(datos[4]);

            return cargo;
        }

        public Tbl_Vw_Cargo CargarVwCargo(string[] datos) {
            Tbl_Vw_Cargo cargo = new Tbl_Vw_Cargo();

            cargo.Id = int.Parse(datos[0]);
            cargo.Nombre = datos[1];
            cargo.Departamento = datos[2];
            cargo.Descripcion = datos[3];
            cargo.Estado = Convert.ToInt16(datos[4]);

            return cargo;
        }

        public Tbl_Usuario CargarUsuario(string[] datos) {
            Tbl_Usuario usuario = new Tbl_Usuario();

            usuario.Username = datos[1];
            usuario.Password = datos[2];
            usuario.Estado = int.Parse(datos[3]);
            usuario.IdRol = int.Parse(datos[4]);

            return usuario;
        }

        public Tbl_Vw_Usuario CargarVwUsuario(string[] datos) {
            Tbl_Vw_Usuario usuario = new Tbl_Vw_Usuario();

            usuario.Id = int.Parse(datos[0]);
            usuario.Username = datos[1];
            usuario.Clave = datos[2];
            usuario.Empleado = datos[3];
            usuario.Rol = datos[4];
            usuario.Estado = int.Parse(datos[5]);

            return usuario;
        }

        public Tbl_Opcion CargarOpcion(string[] datos) {
            Tbl_Opcion opcion = new Tbl_Opcion();

            opcion.Formulario = datos[1];

            return opcion;
        }

        public Tbl_Evento CargarEvento(string[] datos) {
            Tbl_Evento evento = new Tbl_Evento();

            evento.FechaInicio = ConfirmarFecha(datos[1]);
            evento.FechaFin = ConfirmarFecha(datos[2]);
            evento.Razon = datos[3];
            evento.Descripcion = datos[4];
            evento.Estado = int.Parse(datos[5]);
            evento.IdEmp = int.Parse(datos[6]);
            return evento;
        }

        public Tbl_Vw_Evento CargarVwEvento(string[] datos) {

            Tbl_Vw_Evento evento = new Tbl_Vw_Evento();

            evento.IdEvento = int.Parse(datos[0]);
            evento.FechaInicio = ConfirmarFecha(datos[1]);
            evento.FechaFin = ConfirmarFecha(datos[2]);
            evento.Razon = datos[3];
            evento.Descripcion = datos[4];
            evento.EmpleadoSel = datos[5];

            return evento;
        }

        public Tbl_Horario CargarHorario(string[] datos) {
            Tbl_Horario horario = new Tbl_Horario();

            horario.HorarioIn = ConfirmarFecha(datos[1]);
            horario.HorarioOut = ConfirmarFecha(datos[2]);
            horario.TipoHor = int.Parse(datos[3]);
            horario.Activo = ConfirmarBool(datos[4]);
            horario.IdCargo = int.Parse(datos[5]);

            return horario;
        }

        public Tbl_Registro CargarRegistro(string[] datos) {
            Tbl_Registro registro = new Tbl_Registro();

            registro.HoraEntrada = ConfirmarFecha(datos[1]);
            registro.HoraSalida = ConfirmarFecha(datos[2]);
            registro.HoraAlmuerzoIn = ConfirmarFecha(datos[3]);
            registro.HoraAlmuerzoOut = ConfirmarFecha(datos[4]);
            registro.IdEmp = int.Parse(datos[5]);

            return registro;
        }

        public Tbl_Vw_Registro CargarVwRegistro(string[] datos) {
            Tbl_Vw_Registro registro = new Tbl_Vw_Registro();

            registro.Id = Convert.ToInt16(datos[0]);
            registro.HEntrada = ConfirmarFecha(datos[1]);
            registro.HSalida = ConfirmarFecha(datos[2]);
            registro.HAlmuerzoIn = ConfirmarFecha(datos[3]);
            registro.HAlmuerzoOut = ConfirmarFecha(datos[4]);
            registro.Usuario = datos[5];

            return registro;
        }

        public Tbl_OpcRol CargarOpcRol(string[] datos) {
            Tbl_OpcRol opcCar = new Tbl_OpcRol();

            opcCar.Activo = ConfirmarBool(datos[1]);
            opcCar.IdOpcion = int.Parse(datos[2]);
            opcCar.IdRol = int.Parse(datos[3]);

            return opcCar;
        }

        public Tbl_Vw_OpcRol CargarVwOpcRol(string[] datos) {
            Tbl_Vw_OpcRol opcRol = new Tbl_Vw_OpcRol();

            opcRol.IdOpcRol = int.Parse(datos[0]);
            opcRol.Activo = ConfirmarBool(datos[1]);
            opcRol.Nombre = datos[2];
            opcRol.IdRol = int.Parse(datos[3]);

            return opcRol;
        }

        public Tbl_Rol CargarRol(string[] datos) {
            Tbl_Rol rol = new Tbl_Rol();

            rol.Nombre = datos[1];
            rol.Estado = int.Parse(datos[2]);

            return rol;
        }

        public Tbl_Vw_Rol CargarVwRol(string[] datos) {
            Tbl_Vw_Rol rol = new Tbl_Vw_Rol();

            rol.Id = int.Parse(datos[0]);
            rol.Nombre = datos[1];
            rol.Estado = int.Parse(datos[2]);

            return rol;
        }

        public Tbl_Empleado CargarEmpleado(string[] datos) {
            Tbl_Empleado empleado = new Tbl_Empleado();

            empleado.Cedula = datos[1];
            empleado.PrimerNombre = datos[2];
            empleado.SegundoNombre = datos[3];
            empleado.PrimerApellido = datos[4];
            empleado.SegundoApellido = datos[5];
            empleado.Direccion = datos[6];
            empleado.Observacion = datos[7];
            empleado.Telefono = datos[8];
            empleado.EmailPersonal = datos[9];
            empleado.EmailCorporativo = datos[10];
            empleado.Sexo = ConfirmarBool(datos[11]);
            empleado.Actividad = ConfirmarBool(datos[12]);
            empleado.Estado = int.Parse(datos[13]);
            empleado.FechaNac = ConfirmarFecha(datos[14]);
            empleado.FechaIngr = ConfirmarFecha(datos[15]);
            empleado.FechaAgr = ConfirmarFecha(datos[16]);
            empleado.IdCargo = int.Parse(datos[17]) - 1;
            empleado.IdUsuario = int.Parse(datos[18]);
            return empleado;
        }

        public Tbl_Vw_Empleado CargarVwEmpleado(string[] datos) {
            Tbl_Vw_Empleado empleado = new Tbl_Vw_Empleado();

            empleado.Id = int.Parse(datos[0]);
            empleado.Usuario = datos[1];
            empleado.Nombres = datos[2];
            empleado.Apellidos = datos[3];
            empleado.Sexo = datos[4];
            empleado.Cedula = datos[5];
            empleado.Departamento = datos[6];
            empleado.Cargo = datos[7];
            empleado.EmailCorporativo = datos[8];
            empleado.EmailPersonal = datos[9];
            empleado.FechaNac = ConfirmarFecha(datos[10]);
            empleado.FechaIngreso = ConfirmarFecha(datos[11]);
            empleado.Activo = datos[12];
            empleado.Telefono = datos[13];
            empleado.Observacion = datos[14];
            empleado.Direccion = datos[15];
            empleado.Estado = int.Parse(datos[16]);

            return empleado;
        }


        public Tbl_Config CargarConfig(string[] datos) {
            Tbl_Config config = new Tbl_Config();

            config.NombreEmpresa = datos[1];
            config.HAlmuerzoIn = ConfirmarFecha(datos[2]);
            config.HAlmuerzoOut = ConfirmarFecha(datos[3]);
            config.TiempoGracia = int.Parse(datos[4]);
            config.EmailEmpresa = datos[5];

            return config;
        }

        private DateTime ConfirmarFecha(string dato) {
            return dato.Length > 0 ? DateTime.Parse(dato) : default(DateTime);
        }

        private bool ConfirmarBool(string dato) {
            return dato == "0" ? false : true;
        }
    }
}