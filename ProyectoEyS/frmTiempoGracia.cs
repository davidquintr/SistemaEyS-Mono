using System;
using Gtk;
using Datos;
using Entidades;

namespace ProyectoEyS
{
    public partial class frmTiempoGracia : Gtk.Window
    {

        Tbl_Config cfg = new Tbl_Config();
        Dt_tbl_config dtCfg = new Dt_tbl_config();

        public frmTiempoGracia() :
                base(Gtk.WindowType.Toplevel)
        {
            this.Build();
            cfg = dtCfg.colocarConfig();
            CargarDatos();
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        private void CargarDatos() {
            sbtTemGra.Value = cfg.TiempoGracia;
        }
        
        private void OrganizarDatos() {
            cfg.TiempoGracia = sbtTemGra.ValueAsInt;
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
                this.Destroy();
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                OrganizarDatos();
                if (dtCfg.EditarConfig(cfg)) {
                    CuadroMensaje("Se han guardado los cambios", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                }
            }
        }
    }
}
