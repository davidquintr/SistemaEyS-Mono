using System;
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

        protected void 
        OnButton2Clicked(object sender, EventArgs e) {
            Gtk.Button button = new Gtk.Button();
            vbuttonbox1.Add(button);

        }
    }
}