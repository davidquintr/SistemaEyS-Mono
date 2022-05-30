using System;
using Gtk;
namespace ProyectoEyS {
    public partial class frmAlmuerzo : Gtk.Window {

        private DateTime almIn, almOut;

        public frmAlmuerzo() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            ClockStart();
        }

        public void AlternarButtons(int mode) {
            switch (mode) {
                case 0:
                    buttonComenazar.Sensitive = true;
                    buttonConcluir.Sensitive = false;
                    break;
                case 1:
                    buttonComenazar.Sensitive = false;
                    buttonConcluir.Sensitive = true;
                    break;
                case 2:
                    buttonComenazar.Sensitive = false;
                    buttonConcluir.Sensitive = false;
                    break;
            }
        }

        public void EstablecerHorarioAlm(DateTime almIn, DateTime almOut) {
            string datosNorm = DateTime.Now.ToString("yyyy-M-d") + " " + almIn.Hour +":"+almIn.Minute+":"+ almIn.Second;
            this.almIn = DateTime.Parse(datosNorm);
            this.almOut = almOut;
        }

        private vistaUsuario callVistaUser;
        public vistaUsuario CallVistaUser { get => callVistaUser; set => callVistaUser = value; }

        protected void OnButtonComenazarClicked(object sender, EventArgs e) {
            callVistaUser.MarcarSalidaAlmu();
            AlternarButtons(1);
        }

        void ClockStart() {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Update));
        }

        //Dibujamos la hora y las lineas de las horas
        bool Update() {
            tiempoRest.Text = "Tiempo Restante: " + almIn.Subtract(DateTime.Now).ToString().Substring(0,8);
            return true;
        }

        protected void OnButtonConcluirClicked(object sender, EventArgs e) {
            callVistaUser.MarcarEntradaAlmu();
            AlternarButtons(2);
        }


        protected void OnButtonFinalizarClicked(object sender, EventArgs e) {
            this.Destroy();
        }
    }
}