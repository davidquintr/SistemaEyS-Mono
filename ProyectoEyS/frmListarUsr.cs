using System;
using Datos;
using Vistas;
using System.Collections.Generic;
using Gtk;

namespace ProyectoEyS
{
    public partial class frmListarUsr : Gtk.Window{

        Dt_tbl_emp dtEmp = new Dt_tbl_emp();
        List<Tbl_Vw_Empleado> listEmp = new List<Tbl_Vw_Empleado>();

        int id = 0;

        public frmListarUsr() :base(Gtk.WindowType.Toplevel){
            try {
                this.Build();
                listEmp = dtEmp.ColocarVwEmpleado();
                LlenarcbxeEmp();
                MostrarDatos(id);
            }catch(Exception ex) {
                CuadroMensaje("No existen datos mostrar, por favor, agregue un empleado", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            };
                
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void LlenarcbxeEmp() {
            for (int i = 0; i < listEmp.Count; i++) {
                this.cbxEListarUsr.InsertText(i, listEmp[id].Nombres);
            }
        }

        public void MostrarDatos(int id){

            lbCedula.Text = listEmp[id].Cedula;
            lbID.Text = listEmp[id].Id.ToString();
            lbUsername.Text = listEmp[id].Usuario == string.Empty ?"(Sin nombre de usuario)": listEmp[id].Usuario;
            lbNombre.Text = listEmp[id].Nombres;
            lbApellido.Text = listEmp[id].Apellidos;
            lbSexo.Text = listEmp[id].Sexo;
            lbDirec.Text = listEmp[id].Direccion;
            lbObs.Text = listEmp[id].Observacion;
            lbTel.Text = listEmp[id].Telefono;
            lbEmailCorp.Text = listEmp[id].EmailCorporativo;
            lbEmailPer.Text = listEmp[id].EmailPersonal;
            lbTrab.Text = listEmp[id].Activo;
            lbFechaNac.Text = listEmp[id].FechaNac.ToString("D");
            lbFechaIngr.Text = listEmp[id].FechaIngreso.ToString("D");
            lbCargo.Text = listEmp[id].Cargo;
            lbDept.Text = listEmp[id].Departamento;
            cbxEListarUsr.Active = id;
            lbCountEmp.Text = "" + (id + 1) + "/" + listEmp.Count;
        }

        protected void OnBtnAdminUsrClicked(object sender, EventArgs e) {
            frmAddUsuario editarUsuario = new frmAddUsuario();
        }

        protected void OnBtnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        
        protected void OnBtnEventExtClicked(object sender, EventArgs e) {
            frmEstablecerEventos eventosExtra = new frmEstablecerEventos();
            eventosExtra.alterMode();
        }

        protected void OnBtnAntUsrClicked(object sender, EventArgs e) {
            if (id > 0){
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigUsrClicked(object sender, EventArgs e) {
            if (id < listEmp.Count-1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnCbxEListarUsrChanged(object sender, EventArgs e) {
            foreach (Tbl_Vw_Empleado emp in listEmp){
                if (listEmp.IndexOf(emp) == cbxEListarUsr.Active){
                    id = listEmp.IndexOf(emp);
                    MostrarDatos(id);
                }
            }
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            frmAddUsuario editUser = new frmAddUsuario();
            editUser.CambiarModo(listEmp[id]);
        }
    }
}
