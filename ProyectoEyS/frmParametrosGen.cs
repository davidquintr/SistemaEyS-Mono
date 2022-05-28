using System;
using Gtk;
namespace ProyectoEyS
{
    public partial class frmParametrosGen : Gtk.Window {

        private Gtk.Button buttonDept = new Gtk.Button();
        private Gtk.Button buttonEventoMod = new Gtk.Button();
        private Gtk.Button buttonTiempo = new Gtk.Button();
        private Gtk.Button buttonHorarioAlmuerzo = new Gtk.Button();

        public frmParametrosGen() : base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButton2Clicked(object sender, EventArgs e) {
            Gtk.Button button = new Gtk.Button();
            vbuttonbox1.Add(button);

        }

        protected void OnBtnNomEprClicked(object sender, EventArgs e) {
            frmAddEntidad nombreEmpresa = new frmAddEntidad();
            nombreEmpresa.CargarDatos(0);
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnBtnDomEprClicked(object sender, EventArgs e) {
            frmAddEntidad nombreEmpresa = new frmAddEntidad();
            nombreEmpresa.CargarDatos(1);
        }

        protected void OnBtnHorAlmClicked(object sender, EventArgs e) {
            frmHorarioAlmuerzo horarioAlmuerzo = new frmHorarioAlmuerzo();
        }

        protected void OnBtnTemGraClicked(object sender, EventArgs e) {
            frmTiempoGracia tiempoGracia = new frmTiempoGracia();
        }
    }
}