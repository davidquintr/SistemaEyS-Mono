using System;
using Gtk;
using Entidades;
using Datos;
using Vistas;
using Negocio;

namespace ProyectoEyS
{
    public partial class frmAddDept : Gtk.Window {

        Dt_tbl_dep dtDep = new Dt_tbl_dep();
        Tbl_Departamento dep = new Tbl_Departamento();
        Tbl_Vw_Departamento depVw = new Tbl_Vw_Departamento();

        Ng_tbl_departamento ngDept = new Ng_tbl_departamento();

        private int mode = 0;
        public frmAddDept() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            this.buttonEliminar.Visible = false;
            entryID.Text = ngDept.ContarDepts().ToString();
            entryNombre.GrabFocus();
        }


        public void CambiarModo(Tbl_Vw_Departamento depVw) {
            mode = 1;
            labelTitulo.Text = "Editar departamento: Departamento";
            this.buttonEliminar.Visible = true;

            this.depVw = depVw;
            LlenarCampos();
        }


        public void LlenarCampos() {

            entryID.Text = depVw.Id.ToString();
            entryNombre.Text = depVw.Nombre;
            entryEmail.Text = depVw.Email;
            entryExt.Text = depVw.Ext;
            textvDesc.Buffer.Text = depVw.Descripcion;
        }


        private Tbl_Departamento OrganizarDatos() {

            dep.Nombre = entryNombre.Text;
            dep.Descripcion = textvDesc.Buffer.Text;
            dep.Email = entryEmail.Text;
            dep.Ext = entryExt.Text;

            return dep;
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }


        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }


        protected void OnButtonSaveClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) { 
                if (mode == 0) {
                    if (dtDep.GuardarDepartamento(OrganizarDatos()))
                        CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                    else
                        CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                }
                else {
                    dep.Estado = 2;
                    if(dtDep.EditarDepartamento(OrganizarDatos(), depVw.Id))
                        CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                    else
                        CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                }
                this.Destroy();
            }
        }


        protected void OnButtonEliminarClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas dar de baja a este empleado?", MessageType.Question, ButtonsType.YesNo)) {
                dep.Estado = 3;
                if(dtDep.EditarDepartamento(OrganizarDatos(), depVw.Id))
                    CuadroMensaje("Se ha dado de baja al empleado", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            }
        }
    }
}
