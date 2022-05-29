using System;
using Vistas;
using Datos;
using System.Collections.Generic;
using Gtk;
using Entidades;
using Negocio;

namespace ProyectoEyS {
    public partial class frmListarCargo : Gtk.Window {

        Dt_tbl_cargo dtr = new Dt_tbl_cargo();
        List<Tbl_Vw_Cargo> listCargo = new List<Tbl_Vw_Cargo>();
        int id = 0;

        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        public frmListarCargo() : base(Gtk.WindowType.Toplevel) {
            try {
                this.Build();
                scrolled.Visible = false;
                listCargo = dtr.ColocarVwCargos();
                LlenarComboCrg();
                MostrarDatos(id);
                Title = "Listar Cargos";

                this.trvwCargo.Model = dtr.listarCargos();
                string[] titulos = { "Id", "Nombre", "Departamento", "Descripcion" };
                for (int i = 0; i < titulos.Length; i++) {
                    this.trvwCargo.AppendColumn(titulos[i], new CellRendererText(), "text", i);
                }

            }
            catch (Exception) {
                CuadroMensaje("No existen datos mostrar, por favor, agregue un cargo", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            };

        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            }
            else
                this.selectedUser = selectedUser;
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void LlenarComboCrg() {
            TreeModel model = dtr.listarCargos();
            model.GetIterFirst(out TreeIter iter);
            do {
                int id = Convert.ToInt32(model.GetValue(iter, 0));
                string nombre = model.GetValue(iter, 1).ToString();
                model.SetValue(iter, 0, nombre);
                model.SetValue(iter, 1, id.ToString());
            } while (model.IterNext(ref iter));

            this.cbxEListarCar.Model = model;
        }

        public void MostrarDatos(int id) {
            lbID.Text = listCargo[id].Id.ToString();
            lbNombre.Text = listCargo[id].Nombre;
            lbDept.Text = listCargo[id].Departamento;
            lbDesc.Buffer.Text = listCargo[id].Descripcion;
            cbxEListarCar.Active = id;
            lbCountCar.Text = "" + (id + 1) + "/" + listCargo.Count;
        }

        protected void OnCbxEListarEmpChanged(object sender, EventArgs e) {
            foreach (Tbl_Vw_Cargo car in listCargo) {
                if (listCargo.IndexOf(car) == cbxEListarCar.Active) {
                    id = listCargo.IndexOf(car);
                    MostrarDatos(id);
                }
            }
        }

        protected void OnBtnAntCarClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigCarClicked(object sender, EventArgs e) {
            if (id < listCargo.Count - 1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            frmAddCargo editarCargo = new frmAddCargo();
            editarCargo.CambiarModo(listCargo[id]);
            editarCargo.ComprobarPermiso(selectedUser);
        }

        protected void OnBtnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonCambiarHorClicked(object sender, EventArgs e) {
            frmEstablecerHorarios establecerHorarios = new frmEstablecerHorarios();
        }

        protected void OnButtonFiltrarClicked(object sender, EventArgs e) {
            if (scrolled.Visible)
                scrolled.Visible = false;
            else
                scrolled.Visible = true;

        }

        protected void OnTrvwCargoCursorChanged(object sender, EventArgs e) {
            TreeSelection seleccion = (sender as TreeView).Selection;
            TreeIter iter;
            TreeModel model;
            if (seleccion.GetSelected(out model, out iter)) {

                int active = 0;
                TreeModel m = dtr.listarCargos();
                m.GetIterFirst(out TreeIter it);
                do {
                    int idtrv = Convert.ToInt32(model.GetValue(iter, 0));
                    int id = Convert.ToInt32(m.GetValue(it, 0));

                    if (idtrv == id)
                        cbxEListarCar.Active = active;
                    active++;

                } while (m.IterNext(ref it));
            }
        }
    }
}

