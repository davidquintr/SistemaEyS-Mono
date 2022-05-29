using System;
using Datos;
using Vistas;
using System.Collections.Generic;
using Entidades;
using Negocio;
using Gtk;

namespace ProyectoEyS {
    public partial class frmListarRoles : Gtk.Window {

        Dt_tbl_rol dtRol = new Dt_tbl_rol();
        List<Tbl_Vw_Rol> listRol = new List<Tbl_Vw_Rol>();
        int id = 0;

        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();
        Dt_tbl_opcRol dtOpcRol = new Dt_tbl_opcRol();

        public frmListarRoles() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            scrolled.Visible = false;
            listRol = dtRol.ColocarVwRol();
            LlenarComboRol();
            Title = "Listar Roles";
            MostrarDatos(id);

            this.trvwRoles.Model = dtRol.listarRoles();
            string[] titulos = { "Id", "Nombre" };
            for (int i = 0; i < titulos.Length; i++) {
                this.trvwRoles.AppendColumn(titulos[i], new CellRendererText(), "text", i);
            }

        }

        protected void LlenarComboRol() {
            TreeModel model = dtRol.listarRoles();
            model.GetIterFirst(out TreeIter iter);
            do {
                int id = Convert.ToInt32(model.GetValue(iter, 0));
                string nombre = model.GetValue(iter, 1).ToString();
                model.SetValue(iter, 0, nombre);
                model.SetValue(iter, 1, id.ToString());
            } while (model.IterNext(ref iter));

            this.cbxEListarRol.Model = model;
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

        protected void MostrarDatos(int id) {

            lbID.Text = listRol[id].Id.ToString();
            lbNombre.Text = listRol[id].Nombre;
            cbxEListarRol.Active = id;
            lbCountRol.Text = "" + (id + 1) + "/" + listRol.Count;
            string texto = dtOpcRol.ObtenerTextoRoles(listRol[id].Id);
            if (texto == "") twPermisos.Buffer.Text = "Sin permisos"; else twPermisos.Buffer.Text = texto;
        }

        protected void OnCbxEListarRolChanged(object sender, EventArgs e) {
            foreach (Tbl_Vw_Rol emp in listRol) {
                if (listRol.IndexOf(emp) == cbxEListarRol.Active) {
                    id = listRol.IndexOf(emp);
                    MostrarDatos(id);
                }
            }
        }

        protected void OnBtnAntRolClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigRolClicked(object sender, EventArgs e) {
            if (id < listRol.Count - 1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnBtnAdminClicked(object sender, EventArgs e) {
            frmAddRol editRol = new frmAddRol();
            editRol.CambiarModo(listRol[id]);
            editRol.ComprobarPermiso(selectedUser);
        }

        protected void OnButtonFiltrarClicked(object sender, EventArgs e) {
            if (scrolled.Visible)
                scrolled.Visible = false;
            else
                scrolled.Visible = true;
        }

        protected void OnTrvwRolesCursorChanged(object sender, EventArgs e) {
            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter)) {

                int active = 0;
                TreeModel m = dtRol.listarRoles();
                m.GetIterFirst(out TreeIter it);
                do {
                    int idtrv = Convert.ToInt32(model.GetValue(iter, 0));
                    int id = Convert.ToInt32(m.GetValue(it, 0));

                    if (idtrv == id)
                        cbxEListarRol.Active = active;
                    active++;

                } while (m.IterNext(ref it));
            }
        }
    }
}

