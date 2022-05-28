using System;
using Gtk;
namespace ProyectoEyS {
    public partial class frmAlmuerzo : Gtk.Window {
        public frmAlmuerzo() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        public void AlternarButtons(int mode) {
            if (mode == 0) {
                buttonComenazar.Sensitive = true;
                buttonConcluir.Sensitive = false;
            } else if (mode == 1) {
                buttonComenazar.Sensitive = false;
                buttonConcluir.Sensitive = true;
            } else if (mode == 2) {
                buttonComenazar.Sensitive = false;
                buttonConcluir.Sensitive = false;
            }
        }

        private vistaUsuario callVistaUser;
        public vistaUsuario CallVistaUser { get => callVistaUser; set => callVistaUser = value; }

        protected void OnButtonComenazarClicked(object sender, EventArgs e) {
            callVistaUser.MarcarSalidaAlmu();
            AlternarButtons(1);
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