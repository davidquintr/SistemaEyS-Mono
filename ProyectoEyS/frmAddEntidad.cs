using System;
using Entidades;
using Datos;
using Gtk;

namespace ProyectoEyS
{
    public partial class frmAddEntidad : Gtk.Window {

        Tbl_Config cfg = new Tbl_Config();
        Dt_tbl_config dtCfg = new Dt_tbl_config();
        int mode = 0;

        public frmAddEntidad() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            cfg = dtCfg.colocarConfig();

        }

        public void CargarDatos(int mode) {
            this.mode = mode;
            if(mode == 0) {
                labelSubTitulo.Text = "Introduzca el nombre de la empresa: ";
                entryParam.Text = cfg.NombreEmpresa;
            }
            else {
                labelSubTitulo.Text = "Introduzca el dominio de la empresa: ";
                if (cfg.EmailEmpresa == "")
                    entryParam.Text = "@" + cfg.NombreEmpresa + ".com";
                else
                    entryParam.Text = cfg.EmailEmpresa;
            }
        }

        private void OrganizarDatos() {
            if (mode == 0)
                cfg.NombreEmpresa = entryParam.Text;
            else
                cfg.EmailEmpresa = entryParam.Text;
        }


        protected void OnAceptarClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                OrganizarDatos();
                if (dtCfg.EditarConfig(cfg)) {
                    CuadroMensaje("Se han guardado los cambios", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                }
            }
        }

        protected void OnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
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
