using System;
using System.Collections.Generic;
using Datos;
using Gtk;
using Vistas;

namespace ProyectoEyS {
    public partial class frmSeguridadPermisos : Gtk.Window {

        Dt_tbl_rol dtRol = new Dt_tbl_rol();
        List<Tbl_Vw_Rol> listRol = new List<Tbl_Vw_Rol>();

        int id;

        public frmSeguridadPermisos() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            listRol = dtRol.ColocarVwRol();
            id = 0;
        }


        private bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        private bool CambiarEstado(bool activo) {
            if (activo)
                return false;
            return true;
        }

        private bool ComprobarConTotal() {
            if (ckbAdmEmp.Active && ckbAdmCrg.Active && ckbAdmDep.Active &&
                ckbAdmUsr.Active && ckbAdmRol.Active && ckbAgrCrg.Active &&
                ckbAgrDep.Active && ckbAgrEmp.Active && ckbAgrRol.Active &&
                ckbAgrUsr.Active && ckbLisCrg.Active && ckbLisDep.Active &&
                ckbLisEmp.Active && ckbLisRol.Active && ckbLisUsr.Active &&
                ckbParGen.Active && ckbResEnt.Active && ckbConEve.Active &&
                ckbConHor.Active)
                return false;
            return true;
        }

        protected void OnRbControlToggled(object sender, EventArgs e) {
            rbControl.Active = true;

            ckbAdmEmp.Active = true;
            ckbAdmCrg.Active = true;
            ckbAdmDep.Active = true;
            ckbAdmUsr.Active = true;
            ckbAdmRol.Active = true;

            ckbAgrCrg.Active = true;
            ckbAgrDep.Active = true;
            ckbAgrEmp.Active = true;
            ckbAgrRol.Active = true;
            ckbAgrUsr.Active = true;

            ckbLisCrg.Active = true;
            ckbLisDep.Active = true;
            ckbLisEmp.Active = true;
            ckbLisRol.Active = true;
            ckbLisUsr.Active = true;

            ckbParGen.Active = true;
            ckbResEnt.Active = true;
            ckbConEve.Active = true;
            ckbConHor.Active = true;
        }

        protected void OnCkbAdmEmpClicked(object sender, EventArgs e) {
            try {
                ckbAdmEmp.Active = CambiarEstado(ckbAdmEmp.Active);
            }
            catch (Exception o) {
                CuadroMensaje(o.Message, MessageType.Error, ButtonsType.Ok);
            }



        }
    }
}
