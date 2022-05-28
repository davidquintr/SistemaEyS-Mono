using System;
using Datos;
using Vistas;
using System.Collections.Generic;

namespace ProyectoEyS 
{
    public partial class frmListarRoles : Gtk.Window {

        Dt_tbl_rol dtRol = new Dt_tbl_rol();
        List<Tbl_Vw_Rol> listRol = new List<Tbl_Vw_Rol>();
        int id = 0;

        public frmListarRoles() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            listRol = dtRol.ColocarVwRol();
            LlenarComboRol();
            MostrarDatos(id);
        }

        protected void LlenarComboRol() {
            for (int i = 0; i < listRol.Count; i++) {
                cbxEListarRol.InsertText(i, listRol[i].Nombre);
            }
        }

        protected void MostrarDatos(int id) {

            lbID.Text = listRol[id].Id.ToString();
            lbNombre.Text = listRol[id].Nombre;
            cbxEListarRol.Active = id;
            lbCountRol.Text = "" + (id + 1) + "/" + listRol.Count;
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
        }
    }
}
