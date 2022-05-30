using System;
using Datos;
using Entidades;
using Gtk;
using Negocio;

namespace ProyectoEyS
{
    public partial class frmParametrosGen : Gtk.Window {

        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();
        Tbl_Usuario selectedUser;

        Tbl_Config cfg;
        Dt_tbl_config dtCfg = new Dt_tbl_config();


        public frmParametrosGen() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            Title = "Parámetros Generales";
            cfg = dtCfg.colocarConfig();

            if (cfg.HAlmuerzoIn == default(DateTime)) {
                cfg.HAlmuerzoIn = DateTime.Parse("2001-09-11 12:00:00");
                cfg.HAlmuerzoOut = DateTime.Parse("2001-09-11 13:00:00");
                cfg.EmailEmpresa = "@empresa.com";
                cfg.TiempoGracia = 10;
                cfg.NombreEmpresa = "Empresa";
                dtCfg.GuardarOpcion(cfg);
            }

        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
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