using System;
namespace ProyectoEyS {
    public partial class frmFechador : Gtk.Window {
        public frmFechador() : base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        public delegate void fechaPoner(DateTime valor);
        public fechaPoner fecha;

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonGuardarClicked(object sender, EventArgs e) {
            fecha(calendar.GetDate());
            this.Destroy();
        }
    }
}
