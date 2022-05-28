using System;
using System.Collections.Generic;
using Vistas;
using Datos;
using Negocio;
using Entidades;
using Gtk;

namespace ProyectoEyS {
    public partial class frmListarCredenciales : Gtk.Window {

        Dt_tbl_usuario dtUsr = new Dt_tbl_usuario();
        List<Tbl_Vw_Usuario> listUsuarios = new List<Tbl_Vw_Usuario>();
        int id = 0;
        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        public frmListarCredenciales() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            scrolled.Visible = false;
            listUsuarios = dtUsr.ColocarVwUsuarios();
            LlenarComboUser();
            MostrarDatos(id);
            Title = "Listar Usuarios";

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

        private void LlenarComboUser() {
            for (int i = 0; i < listUsuarios.Count; i++) {
                cbxEListarUsuario.InsertText(i, listUsuarios[i].Username);
            }
        }

        public void MostrarDatos(int id) {
            lbID.Text = listUsuarios[id].Id.ToString();
            lbNombre.Text = listUsuarios[id].Username;
            lbContraseña.Text = listUsuarios[id].Clave;
            lbEmpleado.Text = listUsuarios[id].Empleado == string.Empty ? "Sin empleado asignado": listUsuarios[id].Empleado;
            lbRol.Text = listUsuarios[id].Rol;
            cbxEListarUsuario.Active = id;
            lbCountCar.Text = "" + (id + 1) + "/" + listUsuarios.Count;
        }

        protected void OnCbxEListarUsuarioChanged(object sender, EventArgs e) {
            foreach (Tbl_Vw_Usuario car in listUsuarios) {
                if (listUsuarios.IndexOf(car) == cbxEListarUsuario.Active) {
                    id = listUsuarios.IndexOf(car);
                    MostrarDatos(id);
                }
            }
        }

        protected void OnBtnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnBtnAntCreClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigCreClicked(object sender, EventArgs e) {
            if (id < listUsuarios.Count - 1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnBtnAdminClicked(object sender, EventArgs e) {
            frmAdminCredenciales adminUser = new frmAdminCredenciales();
            adminUser.CambiarModo(listUsuarios[id]);
            adminUser.ComprobarPermiso(selectedUser);
        }

        protected void OnButtonFiltrarClicked(object sender, EventArgs e) {
            if (scrolled.Visible)
                scrolled.Visible = false;
            else
                scrolled.Visible = true;
        }
    }
    }