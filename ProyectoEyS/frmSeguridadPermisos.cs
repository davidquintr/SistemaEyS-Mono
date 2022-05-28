using System;
using System.Collections.Generic;
using Datos;
using Entidades;
using Gtk;
using Vistas;

namespace ProyectoEyS {
    public partial class frmSeguridadPermisos : Gtk.Window {

        Dt_tbl_opcRol dtOR = new Dt_tbl_opcRol();
        Tbl_Vw_Rol vwRol;
        List<Tbl_OpcRol> listOR;

        public frmSeguridadPermisos() : base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        public void CargarDatos(Tbl_Vw_Rol vwRol) {
            this.vwRol = vwRol;
            Tbl_OpcRol opcRol;

            labelMainOpc.Text = "Seguridad: Permisos para: " + vwRol.Nombre;
            listOR = dtOR.EncontrarOpcRol(vwRol.Id);

            if(listOR.Count > 0) {
                LLenarCampos();

            
            } else { 
                for(int i = 0; i < 19; i++) {
                    opcRol = new Tbl_OpcRol();
                    opcRol.IdOpcion = i + 1;
                    opcRol.IdRol = vwRol.Id;
                    opcRol.Activo = false;
                    listOR.Add(opcRol);
                }
                dtOR.GuardarOpcRol(listOR);
            }
        }

        private void LLenarCampos() {
            ckbAdmEmp.Active = listOR[0].Activo;
            ckbAdmCrg.Active = listOR[1].Activo;
            ckbAdmDep.Active = listOR[2].Activo;
            ckbAdmUsr.Active = listOR[3].Activo;
            ckbAdmRol.Active = listOR[4].Activo;

            ckbLisEmp.Active = listOR[5].Activo;
            ckbLisCrg.Active = listOR[6].Activo;
            ckbLisDep.Active = listOR[7].Activo;
            ckbLisUsr.Active = listOR[8].Activo;
            ckbLisRol.Active = listOR[9].Activo;

            ckbAgrEmp.Active = listOR[10].Activo;
            ckbAgrCrg.Active = listOR[11].Activo;
            ckbAgrDep.Active = listOR[12].Activo;
            ckbAgrUsr.Active = listOR[13].Activo;
            ckbAgrRol.Active = listOR[14].Activo;

            ckbConHor.Active = listOR[15].Activo;
            ckbConEve.Active = listOR[16].Activo;
            ckbParGen.Active = listOR[17].Activo;
            ckbResEnt.Active = listOR[18].Activo;
        }

        private bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnRbPersClicked(object sender, EventArgs e) {
            if (rbPers.Active) {
                selecCh(false);
            }
        }

        protected void OnRbControlClicked(object sender, EventArgs e) {
            if (rbControl.Active) {
                selecCh(true);
            }
        }

        private void selecCh(bool alter) {
            ckbAdmCrg.Active = alter;
            ckbAdmDep.Active = alter;
            ckbAdmEmp.Active = alter;
            ckbAdmRol.Active = alter;
            ckbAdmUsr.Active = alter;

            ckbLisCrg.Active = alter;
            ckbLisDep.Active = alter;
            ckbLisEmp.Active = alter;
            ckbLisRol.Active = alter;
            ckbLisUsr.Active = alter;

            ckbAgrCrg.Active = alter;
            ckbAgrDep.Active = alter;
            ckbAgrEmp.Active = alter;
            ckbAgrRol.Active = alter;
            ckbAgrUsr.Active = alter;

            ckbConEve.Active = alter;
            ckbConHor.Active = alter;
            ckbParGen.Active = alter;
            ckbResEnt.Active = alter;
        }

        protected void OnButtonGuardarClicked(object sender, EventArgs e) {
            if (!CuadroMensaje("¿Deseas guardar los cambios?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }
            OrganizarDatos();
            if (!dtOR.EditarOpcRol(listOR)) {
                CuadroMensaje("No se guardaron los cambios", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            }
            CuadroMensaje("Se guardaron los cambios exitosamente", MessageType.Error, ButtonsType.Ok);
            this.Destroy();
        }

        private void OrganizarDatos() {
            listOR[0].Activo = ckbAdmEmp.Active;
            listOR[1].Activo = ckbAdmCrg.Active;
            listOR[2].Activo = ckbAdmDep.Active;
            listOR[3].Activo = ckbAdmUsr.Active;
            listOR[4].Activo = ckbAdmRol.Active;

            listOR[5].Activo = ckbLisEmp.Active;
            listOR[6].Activo = ckbLisCrg.Active;
            listOR[7].Activo = ckbLisDep.Active;
            listOR[8].Activo = ckbLisUsr.Active;
            listOR[9].Activo = ckbLisRol.Active;

            listOR[10].Activo = ckbAgrEmp.Active;
            listOR[11].Activo = ckbAgrCrg.Active;
            listOR[12].Activo = ckbAgrDep.Active;
            listOR[13].Activo = ckbAgrUsr.Active;
            listOR[14].Activo = ckbAgrRol.Active;

            listOR[15].Activo = ckbConHor.Active;
            listOR[16].Activo = ckbConEve.Active;
            listOR[17].Activo = ckbParGen.Active;
            listOR[18].Activo = ckbResEnt.Active;
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }
    }
}
