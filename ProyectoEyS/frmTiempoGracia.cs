using System;
using Gtk;

namespace ProyectoEyS
{
    public partial class frmTiempoGracia : Gtk.Window
    {
        public frmTiempoGracia() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void 
        OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo))
                CuadroMensaje("Se han guardado los cambios", MessageType.Info, ButtonsType.Ok);
        }

    }
}
