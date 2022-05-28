using System;
using Vistas;
using Datos;
using System.Collections.Generic;
using Gtk;

namespace ProyectoEyS
{
    public partial class frmListarCargo : Gtk.Window {

        Dt_tbl_cargo dtr = new Dt_tbl_cargo();
        List<Tbl_Vw_Cargo> listCargo = new List<Tbl_Vw_Cargo>();
        int id = 0;

        public frmListarCargo() : base(Gtk.WindowType.Toplevel) {
            try { 
                this.Build();
                listCargo = dtr.ColocarVwCargos();
                LlenarComboCrg();
                MostrarDatos(id);
            } catch (Exception ex) {
                    CuadroMensaje("No existen datos mostrar, por favor, agregue un cargo", MessageType.Error, ButtonsType.Ok);
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

        protected void LlenarComboCrg() {
            for (int i = 0; i < listCargo.Count; i++) {
                cbxEListarCar.InsertText(i, listCargo[i].Nombre);
            }
        }

        public void MostrarDatos(int id) {
            lbID.Text = listCargo[id].Id.ToString();
            lbNombre.Text = listCargo[id].Nombre;
            lbDept.Text = listCargo[id].Departamento;
            lbDes.Text = listCargo[id].Descripcion;
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
    }
}
