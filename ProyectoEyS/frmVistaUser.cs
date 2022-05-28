using System;
using Gtk;
using Entidades;
using Datos;
using System.Collections.Generic;
using Vistas;

namespace ProyectoEyS {
    public partial class vistaUsuario : Gtk.Window {
        WatchClock clock;
        Tbl_Vw_Empleado empleado;
        int indice = 0;
        int id;
        bool inh = false;


        List<Tbl_Registro> listReg = new List<Tbl_Registro>();
        Dt_tbl_registro dtReg = new Dt_tbl_registro();
        Tbl_Registro regAct = new Tbl_Registro();

        public vistaUsuario() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            labelFecha.Text = DateTime.Now.ToString("D");

            //drawingarea2.ModifyBg(StateType.Normal, new Gdk.Color(53, 53, 53));

            //Creamos un objeto de la clase WatchClock
            clock = new WatchClock();
            clock.ObtenerDimensiones(123, 100);
            ClockStart();
        }

        public void ConfigurarInicio(Tbl_Vw_Empleado empleado) {
            listReg = dtReg.ColocarRegistros();
            this.empleado = empleado;
            labelBienv.Text = "Bienvenido, " + empleado.Nombres.Split(' ')[0] + " " + empleado.Apellidos.Split(' ')[0];

            for (int i = 0; i < listReg.Count; i++) {
                if (listReg[i].IdEmp == empleado.Id && listReg[i].HoraEntrada.ToString("yyyy MMMMM dd") == DateTime.Now.ToString("yyyy MMMMM dd")) {
                    indice = i + 1;
                    regAct = listReg[i];
                    break;
                }
            }

            if (regAct.HoraEntrada != default(DateTime) && !inh) {
                labelEnt.Text = "Hora de entrada: " + regAct.HoraEntrada.ToString("T");
                buttonEntrada.Sensitive = false;
            } else {
                labelEnt.Text = "No se ha iniciado la jornada laboral";
                labelTiempo.Text = "";
            }

            if (regAct.HoraSalida != default(DateTime) && !inh) {
                buttonSalida.Sensitive = false;
                buttonAlmuerzo.Sensitive = false;
            }
            if (regAct.HoraAlmuerzoIn != default(DateTime) && !inh) {
                buttonAlmuerzo.Sensitive = false;
            }

            if (regAct.HoraSalida != default(DateTime) && !inh) {
                labelEnt.Text = "Ronda de trabajo finalizada";
                labelHora.Text = "";
            }
            if (regAct.HoraAlmuerzoOut != default(DateTime) && regAct.HoraAlmuerzoIn == default(DateTime))
                buttonSalida.Sensitive = false;
        }

        //Creamos un timer
        void ClockStart() {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Update));
        }

        //Dibujamos la hora y las lineas de las horas
        bool Update() {
            drawingarea2.GdkWindow.Clear();
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");

            clock.DrawRing(drawingarea2.GdkWindow);
            clock.HourLine(drawingarea2.GdkWindow);
            clock.MinuteLine(drawingarea2.GdkWindow);
            clock.SecondsLine(drawingarea2.GdkWindow);
            return true;
        }


        private Gtk.Window callMainWindow;

        public Window CallMainWindow { get => callMainWindow; set => callMainWindow = value; }

        protected void OnButtonAlmuerzoClicked(object sender, EventArgs e) {
            frmAlmuerzo almuerzo = new frmAlmuerzo();
            if (regAct.HoraAlmuerzoOut != default(DateTime) && !inh)
                almuerzo.AlternarButtons(1);
            else
                almuerzo.AlternarButtons(0);

            almuerzo.CallVistaUser = this;

        }

        protected void OnButtonEntradaClicked(object sender, EventArgs e) {
            MarcarEntrada();
        }

        protected void OnButtonSalidaClicked(object sender, EventArgs e) {
            MarcarSalida();
        }


        private void MarcarEntrada() {
            if (!CuadroMensaje("¿Deseas iniciar tu jornada?", MessageType.Info, ButtonsType.YesNo)) {
                return;
            }

            this.regAct.HoraEntrada = DateTime.Now;
            this.regAct.IdEmp = empleado.Id;

            if (!dtReg.GuardarRegistro(regAct, 1, 0)) {
                CuadroMensaje("Ha ocurrido un error al Guardar", MessageType.Error, ButtonsType.Ok);
            }

            CuadroMensaje("Ha marcado su entrada", MessageType.Info, ButtonsType.Ok);
            ConfigurarInicio(this.empleado);
        }

        private bool ComprobarRegistro() {
            listReg = dtReg.EncontrarRegistros(id);
            for (int i = 0; i < listReg.Count; i++)
                if (listReg[i].HoraEntrada.Date == DateTime.Now.Date)
                    return true;
            return false;
        }


        private void MarcarSalida() {
            if (!CuadroMensaje("¿Deseas terminar tu jornada?", MessageType.Info, ButtonsType.YesNo)) {
                return;
            }

            this.regAct.HoraSalida = DateTime.Now;
            this.regAct.IdEmp = empleado.Id;

            if (!dtReg.GuardarRegistro(regAct, 2, indice)) {
                CuadroMensaje("Ha ocurrido un error al Guardar", MessageType.Error, ButtonsType.Ok);
            }

            CuadroMensaje("Ha marcado su salida", MessageType.Info, ButtonsType.Ok);
            ConfigurarInicio(this.empleado);
        }

        public void MarcarSalidaAlmu() {
            if (!CuadroMensaje("¿Deseas salir a tu almuerzo?", MessageType.Info, ButtonsType.YesNo)) {
                return;
            }

            this.regAct.HoraAlmuerzoOut = DateTime.Now;
            this.regAct.IdEmp = empleado.Id;

            if (!dtReg.GuardarRegistro(regAct, 4, indice)) {
                CuadroMensaje("Ha ocurrido un error al Guardar", MessageType.Error, ButtonsType.Ok);
            }

            CuadroMensaje("Ha marcado su salida al almuerzo", MessageType.Info, ButtonsType.Ok);
            ConfigurarInicio(this.empleado);
        }

        public void MarcarEntradaAlmu() {
            if (!CuadroMensaje("¿Deseas marcar tu entrada nuevamente?", MessageType.Info, ButtonsType.YesNo)) {
                return;
            }

            this.regAct.HoraAlmuerzoIn = DateTime.Now;
            this.regAct.IdEmp = empleado.Id;

            if (!dtReg.GuardarRegistro(regAct, 3, indice)) {
                CuadroMensaje("Ha ocurrido un error al Guardar", MessageType.Error, ButtonsType.Ok);
            }
            CuadroMensaje("Has regresado a tu labor", MessageType.Info, ButtonsType.Ok);
            ConfigurarInicio(this.empleado);
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            callMainWindow.Show();
            this.Hide();
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }
    }
}