using System;
using Datos;
using Vistas;
using System.Collections.Generic;
using Gtk;
using Entidades;
using Negocio;

namespace ProyectoEyS {
    public partial class frmListarUsr : Gtk.Window {

        Dt_tbl_emp dtEmp = new Dt_tbl_emp();
        List<Tbl_Vw_Empleado> listEmp = new List<Tbl_Vw_Empleado>();
        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();
        int id = 0;

        public frmListarUsr() : base(Gtk.WindowType.Toplevel) {
            try {
                this.Build();
                listEmp = dtEmp.ColocarVwEmpleado();
                LlenarcbxeEmp();
                MostrarDatos(id);
                Title = "Listar Empleados";
                scrolled.Visible = false;

                this.trvwListEmp.Model = dtEmp.listarEmpleado();
                string[] titulos = { "Id", "Username", "Nombre", "Apellido", "Sexo", "Cedula", "Departamento", "Cargo", "Email Corporativo", "Email Personal", "Fecha nacimiento", "Fecha ingreso", "Estado actividad", "Telefono", "Observacion" };
                for (int i = 0; i < titulos.Length; i++) {
                    this.trvwListEmp.AppendColumn(titulos[i], new CellRendererText(), "text", i);
                }


            } catch (Exception ex) {
                CuadroMensaje("No existen datos mostrar, por favor, agregue un empleado", MessageType.Error, ButtonsType.Ok);
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

        protected void LlenarcbxeEmp() {
            for (int i = 0; i < listEmp.Count; i++) {
                this.cbxEListarUsr.InsertText(i, listEmp[i].Nombres);
            }
        }

        public void MostrarDatos(int id) {

            lbCedula.Text = listEmp[id].Cedula;
            lbID.Text = listEmp[id].Id.ToString();
            lbUsername.Text = listEmp[id].Usuario == string.Empty ? "(Sin nombre de usuario)" : listEmp[id].Usuario;
            lbNombre.Text = listEmp[id].Nombres;
            lbApellido.Text = listEmp[id].Apellidos;
            lbSexo.Text = listEmp[id].Sexo;
            lbDirec.Buffer.Text = listEmp[id].Direccion;
            lbObs.Buffer.Text = listEmp[id].Observacion;
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
        }

        protected void OnBtnAntUsrClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigUsrClicked(object sender, EventArgs e) {
            if (id < listEmp.Count - 1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnCbxEListarUsrChanged(object sender, EventArgs e) {
            foreach (Tbl_Vw_Empleado emp in listEmp) {
                if (listEmp.IndexOf(emp) == cbxEListarUsr.Active) {
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
            editUser.ComprobarPermiso(selectedUser);
        }

        protected void OnButtonEventoClicked(object sender, EventArgs e) {
            frmEstablecerEventos crearEvento = new frmEstablecerEventos();
            crearEvento.CargarDatos(listEmp[id]);
            crearEvento.ComprobarPermiso(selectedUser);
        }

        protected void OnButtonFiltrarClicked(object sender, EventArgs e) {
            if (scrolled.Visible)
                scrolled.Visible = false;
            else
                scrolled.Visible = true;
        }
    }
}
