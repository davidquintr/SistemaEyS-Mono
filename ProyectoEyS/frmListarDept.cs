using System;
using Datos;
using Vistas;
using System.Collections.Generic;
using Gtk;
using Negocio;
using Entidades;

namespace ProyectoEyS {
    public partial class frmListarDept : Gtk.Window {

        Dt_tbl_dep dtDep = new Dt_tbl_dep();
        List<Tbl_Vw_Departamento> listDep = new List<Tbl_Vw_Departamento>();
        int id = 0;
        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        public frmListarDept() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            try {
                scrolled.Visible = false;
                listDep = dtDep.ColocarVwDepart();
                LlenarcbxeDepartamento();

                Title = "Listar Departamentos";

                this.trvwDept.Model = dtDep.listarDepartamento();
                string[] titulos = { "Id", "Nombre", "Email", "Extension" , "Descripcion" };
                for (int i = 0; i < titulos.Length; i++) {
                    this.trvwDept.AppendColumn(titulos[i], new CellRendererText(), "text", i);
                }
                MostrarDatos(id);
            } catch (Exception) {
                CuadroMensaje("No existen datos mostrar, por favor, agregue un departamento", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            };

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

        protected void LlenarcbxeDepartamento() {

            TreeModel model = dtDep.listarDepartamento();
            model.GetIterFirst(out TreeIter iter);
            do {
                int id = Convert.ToInt32(model.GetValue(iter, 0));
                string nombre = model.GetValue(iter, 1).ToString();
                model.SetValue(iter, 0, nombre);
                model.SetValue(iter, 1, id.ToString());
            } while (model.IterNext(ref iter));

            this.cbxEListarDep.Model = model;
        }

        public void MostrarDatos(int id) {
            lbID.Text = listDep[id].Id.ToString();
            lbNombre.Text = listDep[id].Nombre;
            lbEmail.Text = listDep[id].Email;
            lbExt.Text = listDep[id].Ext;
            lbDescrip.Buffer.Text = listDep[id].Descripcion;

            cbxEListarDep.Active = id;
            lbCountDep.Text = "" + (id + 1) + "/" + listDep.Count;
        }

        protected void OnBtnAdminDepClicked(object sender, EventArgs e) {
            frmAddDept editarDept = new frmAddDept();
            editarDept.CambiarModo(listDep[id]);
            editarDept.ComprobarPermiso(selectedUser);
        }

        protected void OnBtnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnCbxEListarDepChanged(object sender, EventArgs e) {
            id = cbxEListarDep.Active;
            MostrarDatos(id);
        }

        protected void OnBtnAntDepClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigDepClicked(object sender, EventArgs e) {
            if (id < listDep.Count - 1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonFiltrarClicked(object sender, EventArgs e) {
            if (scrolled.Visible)
                scrolled.Visible = false;
            else
                scrolled.Visible = true;
        }

        protected void OnTrvwDeptCursorChanged(object sender, EventArgs e) {
            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter)) {

                int active = 0;
                TreeModel m = dtDep.listarDepartamento();
                m.GetIterFirst(out TreeIter it);
                do {
                    int idtrv = Convert.ToInt32(model.GetValue(iter, 0));
                    int id = Convert.ToInt32(m.GetValue(it, 0));

                    if (idtrv == id)
                        cbxEListarDep.Active = active;
                    active++;

                } while (m.IterNext(ref it));
            }
        }

        protected void OnTxbBuscarChanged(object sender, EventArgs e)
        {
            this.trvwDept.Model = dtDep.buscarDep(this.txbBuscar.Text);
        }
    }
}
