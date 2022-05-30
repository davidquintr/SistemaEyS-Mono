using System;
using Datos;
using Entidades;
using Gtk;
using Negocio;
using Vistas;

namespace ProyectoEyS {
    public partial class frmAddRol : Gtk.Window {

        private Dt_tbl_rol dtRol = new Dt_tbl_rol();
        Ng_tbl_rol ngRol = new Ng_tbl_rol();
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();
        Tbl_Usuario selectedUser;
        private Tbl_Vw_Rol rol = null;
        private int mode = 0;

        public frmAddRol() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            Title = "Agregar Rol";
            buttonEliminar.Visible = false;
            buttonPermisos.Visible = false;
            entryNombre.GrabFocus();
            entryID.Text = (ngRol.ContarRoles() + 1).ToString();
        }

        public void CambiarModo(Tbl_Vw_Rol rol) {
            mode = 1;
            Title = "Administrar Rol";
            labelTitulo.Text = "Editar rol";
            this.rol = rol;
            entryID.Text = this.rol.Id.ToString();
            entryNombre.Text = this.rol.Nombre;
            buttonEliminar.Visible = true;
            buttonPermisos.Visible = true;
        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }

        private bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        private Tbl_Rol OrganizarDatos() {
            Tbl_Rol rol = new Tbl_Rol();

            rol.Nombre = entryNombre.Text;

            return rol;
        }

        protected void OnButtonGuardarClicked(object sender, EventArgs e) {
            if (entryNombre.Text.Length < 1) { 
                CuadroMensaje("El campo nombre no puede estar vacio", MessageType.Warning, ButtonsType.Close);
                return;
            }
            if (mode == 0)
                GuardarRol();
            else
                GuardarCambios();

        }

        private void GuardarCambios() {
            Tbl_Rol rol = new Tbl_Rol();
            rol.Estado = 2;
            rol = OrganizarDatos();



            if (!CuadroMensaje("¿Quieres guardar los cambios?", MessageType.Question, ButtonsType.YesNo))
                return;

            if (dtRol.EditarRol(rol, this.rol.Id)) {
                CuadroMensaje("Se ha guardado correctamente", MessageType.Info, ButtonsType.Ok);
                this.Destroy();
            } else
                CuadroMensaje("No se guardaron los cambios", MessageType.Error, ButtonsType.Ok);
        }

        private void GuardarRol() {
            if (!CuadroMensaje("¿Quieres guardar los datos?", MessageType.Question, ButtonsType.YesNo))
                return;

            if (dtRol.GuardarRol(OrganizarDatos())) {
                CuadroMensaje("Se ha guardado correctamente", MessageType.Info, ButtonsType.Ok);
                this.Destroy();
            } else
                CuadroMensaje("No se pudo guardar", MessageType.Error, ButtonsType.Ok);
        }

        protected void OnButtonPermisosClicked(object sender, EventArgs e) {
            frmSeguridadPermisos seguridadPermisos = new frmSeguridadPermisos();
            seguridadPermisos.CargarDatos(rol);
        }
    }
}
