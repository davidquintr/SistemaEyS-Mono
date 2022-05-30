using System;
using System.Collections.Generic;
using Datos;
using Entidades;
using Gtk;
using Vistas;

namespace ProyectoEyS {
    public partial class vistaUsuario : Gtk.Window {
        WatchClock clock;
        Tbl_Vw_Empleado empleado;
        int indice = 0;
        bool inh = false;
        int id;

        private Dt_tbl_config dtCfg = new Dt_tbl_config();
        private Tbl_Config cfg;

        private List<Tbl_Registro> listReg = new List<Tbl_Registro>();
        private Dt_tbl_registro dtReg = new Dt_tbl_registro();
        private Tbl_Registro regAct = new Tbl_Registro();

        private TimeSpan tiempoTrab;


        public vistaUsuario() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            labelFecha.Text = DateTime.Now.ToString("D");

            //drawingarea2.ModifyBg(StateType.Normal, new Gdk.Color(53, 53, 53));

            //Creamos un objeto de la clase WatchClock
            clock = new WatchClock();
            clock.ObtenerDimensiones(123, 100);
            ClockStart();
            cfg = dtCfg.colocarConfig();
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

            if (regAct.HoraEntrada != default(DateTime) && regAct.HoraSalida == default(DateTime)) {
                labelEnt.Text = "Hora de entrada: " + regAct.HoraEntrada.ToString("T");
                buttonEntrada.Sensitive = false;
                buttonSalida.Sensitive = true;
                buttonAlmuerzo.Sensitive = true;

                labelTiempo.Visible = true;

            } else if (regAct.HoraEntrada == default(DateTime)) {
                labelEnt.Text = "No se ha iniciado la jornada laboral";
                labelTiempo.Text = "";
                buttonSalida.Sensitive = false;
                buttonAlmuerzo.Sensitive = false;
            }

            if (regAct.HoraAlmuerzoOut != default(DateTime) && regAct.HoraAlmuerzoIn == default(DateTime)) {
                buttonSalida.Sensitive = false;
            } else if (regAct.HoraAlmuerzoOut != default(DateTime))
                buttonSalida.Sensitive = true;

            if (regAct.HoraSalida != default(DateTime)) {
                buttonSalida.Sensitive = false;
                buttonAlmuerzo.Sensitive = false;
                buttonEntrada.Sensitive = false;
                labelEnt.Text = "Ronda de trabajo finalizada";
                labelHora.Text = "";
            }

            if (regAct.HoraAlmuerzoIn != default(DateTime)) {
                buttonAlmuerzo.Sensitive = false;
            } 
           
             if (regAct.HoraEntrada != default(DateTime) && regAct.HoraSalida != default(DateTime)) {
                labelTiempo.Text = "Tiempo trabajado : ";
                tiempoTrab = regAct.HoraSalida.Subtract(regAct.HoraEntrada);
                labelTiempo.Text += tiempoTrab.ToString("c");
            } else labelTiempo.Text = "";

        }

        //Creamos un timer
        void ClockStart() {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Update));
        }

        private void TiempoTrab() {
            try {
                if (regAct.HoraEntrada != default(DateTime) && regAct.HoraSalida == default(DateTime)) {
                    labelTiempo.Text = "Tiempo trabajado : ";
                    tiempoTrab = DateTime.Now.Subtract(regAct.HoraEntrada);
                    labelTiempo.Text += tiempoTrab.ToString("c").Substring(0, 10);
                }
            } catch (Exception) { };
        }

        //Dibujamos la hora y las lineas de las horas
        bool Update() {
            TiempoTrab();
            drawingarea2.GdkWindow.Clear();
            labelHora.Text = DateTime.Now.ToString("T");
            clock.DrawRing(drawingarea2.GdkWindow);
            clock.HourLine(drawingarea2.GdkWindow);
            clock.MinuteLine(drawingarea2.GdkWindow);
            clock.SecondsLine(drawingarea2.GdkWindow);
            return true;
        }

        private Gtk.Window callMainWindow;

        public Window CallMainWindow { get => callMainWindow; set => callMainWindow = value; }

        protected void OnButtonAlmuerzoClicked(object sender, EventArgs e) {

            string datosNorm = DateTime.Now.ToString("yyyy-M-d") + " " + cfg.HAlmuerzoOut.Hour + ":" + cfg.HAlmuerzoOut.Minute + ":" + cfg.HAlmuerzoOut.Second;
            cfg.HAlmuerzoOut = DateTime.Parse(datosNorm);

            if (cfg.HAlmuerzoOut.Hour > DateTime.Now.Hour) {
                CuadroMensaje("¡Aún no es tiempo de almuerzo!, faltan: " + cfg.HAlmuerzoOut.Subtract(DateTime.Now).ToString().Substring(0,8), MessageType.Warning, ButtonsType.Ok);
                return;
            }

            frmAlmuerzo almuerzo = new frmAlmuerzo();
            if (regAct.HoraAlmuerzoOut != default(DateTime) && !inh)
                almuerzo.AlternarButtons(1);
            else
                almuerzo.AlternarButtons(0);

            almuerzo.CallVistaUser = this;
            almuerzo.EstablecerHorarioAlm(cfg.HAlmuerzoIn,cfg.HAlmuerzoOut);
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