using System;
using Entidades;
using Gtk;
using Datos;
using Negocio;

namespace ProyectoEyS
{
    public partial class frmHorarioAlmuerzo : Gtk.Window
    {

        Tbl_Config cfg = new Tbl_Config();
        Dt_tbl_config dtCfg = new Dt_tbl_config();

        public frmHorarioAlmuerzo() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            cfg = dtCfg.colocarConfig();

            CargarDatos();
        }

        private void CargarDatos() {
            sbtHoraIn.Value = cfg.HAlmuerzoOut.Hour;
            sbtMinutoIn.Value = cfg.HAlmuerzoOut.Minute;
            sbtHoraOut.Value = cfg.HAlmuerzoIn.Hour;
            sbtMinutoOut.Value = cfg.HAlmuerzoIn.Minute;
        }

        private void OrganizarDatos() {
            cfg.HAlmuerzoOut = DateTime.Parse("2001-09-11 " + sbtHoraIn.Text + ":" + sbtMinutoIn.Text + ":" + "00");
            cfg.HAlmuerzoIn = DateTime.Parse("2001-09-11 " + sbtHoraOut.Text + ":" + sbtMinutoOut.Text + ":" + "00");

        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            if (!CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }

            OrganizarDatos();
            if (dtCfg.EditarConfig(cfg)) {
                CuadroMensaje("Se han guardado los cambios", MessageType.Info, ButtonsType.Ok);
                this.Destroy();
            }
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }
    }
}
