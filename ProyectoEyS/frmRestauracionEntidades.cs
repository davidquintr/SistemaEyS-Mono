﻿using System;
using System.Collections.Generic;
using Datos;
using Entidades;
using Gtk;
using Negocio;
using Vistas;

namespace ProyectoEyS {
    public partial class frmRestauracionEntidades : Gtk.Window {

        private int mode;
        Dt_tbl_dep dtDep = new Dt_tbl_dep();
        List<Tbl_Vw_Departamento> listDep = new List<Tbl_Vw_Departamento>();

        Dt_tbl_cargo dtr = new Dt_tbl_cargo();
        List<Tbl_Vw_Cargo> listCargo = new List<Tbl_Vw_Cargo>();

        Dt_tbl_emp dtEmp = new Dt_tbl_emp();
        List<Tbl_Vw_Empleado> listEmp = new List<Tbl_Vw_Empleado>();

        Dt_tbl_usuario dtUsr = new Dt_tbl_usuario();
        List<Tbl_Vw_Usuario> listUsuarios = new List<Tbl_Vw_Usuario>();

        Tbl_Usuario selectedUser;
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        int idIndex;
        int limSup;

        public frmRestauracionEntidades() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            Title = "Restauración de Entidades";
        }

        public void CambiarModo(int mode) {
            try {
                this.mode = mode;
                switch (mode) {
                    case 1:
                        listDep = dtDep.ColocarVwDepartElim();
                        LlenarDepartamentoCbx();
                        this.limSup = listDep.Count;
                        labelTitulo.Text = "Seguridad: Restauración de Departamentos";
                        break;
                    case 2:
                        listCargo = dtr.ColocarVwCargosElim();
                        LlenarCargoCbx();
                        this.limSup = listCargo.Count;
                        labelTitulo.Text = "Seguridad: Restauración de Cargos";

                        break;
                    case 3:
                        listEmp = dtEmp.ColocarVwEmpleadoElim();
                        LlenarEmpCbx();
                        this.limSup = listEmp.Count;
                        labelTitulo.Text = "Seguridad: Restauración de Empleados";
                        break;
                    case 4:
                        listUsuarios = dtUsr.ColocarVwUsuariosElim();
                        LlenarUsrCbc();
                        this.limSup = listUsuarios.Count;
                        labelTitulo.Text = "Seguridad: Restauración de Usuarios";
                        break;
                }

                if (limSup < 1) {
                    CuadroMensaje("No hay elementos eliminados", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                }
                MostrarDatos();
            }catch(Exception ex) { };
        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        protected void LlenarDepartamentoCbx() {
            for (int i = 0; i < listDep.Count; i++) {
                this.cbxDyn.InsertText(i, listDep[i].Nombre);
            }
        }

        protected void LlenarCargoCbx() {
            for (int i = 0; i < listCargo.Count; i++) {
                this.cbxDyn.InsertText(i, listCargo[i].Nombre);
            }
        }

        protected void LlenarEmpCbx() {
            for (int i = 0; i < listEmp.Count; i++) {
                this.cbxDyn.InsertText(i, listEmp[i].Nombres.Split(' ')[0] + " " + listEmp[i].Apellidos.Split(' ')[0] + " - " + listEmp[i].Cedula);
            }
        }
        protected void LlenarUsrCbc() {
            for (int i = 0; i < listUsuarios.Count; i++) {
                this.cbxDyn.InsertText(i, listUsuarios[i].Username);
            }
        }

        public void MostrarDatos() {
            lbCount.Text = (idIndex + 1) + "/" + limSup.ToString();
            switch (mode) {
                case 1:
                    EntryID.Text = listDep[idIndex].Id.ToString();
                    EntryUser.Text = listDep[idIndex].Nombre;
                    break;
                case 2:
                    EntryID.Text = listCargo[idIndex].Id.ToString();
                    EntryUser.Text = listCargo[idIndex].Nombre;
                    break;
                case 3:
                    EntryID.Text = listEmp[idIndex].Id.ToString();
                    EntryUser.Text = listEmp[idIndex].Nombres + " " + listEmp[idIndex].Apellidos + " " + listEmp[idIndex].Cedula;
                    break;
                case 4:
                    EntryID.Text = listUsuarios[idIndex].Id.ToString();
                    EntryUser.Text = listUsuarios[idIndex].Username;
                   break;
            }
            cbxDyn.Active = idIndex;
        }

        protected void OnBtnAntUsrClicked(object sender, EventArgs e) {
            if (idIndex > 0) {
                idIndex--;
                MostrarDatos();
            }
        }

        protected void OnBtnSigUsrClicked(object sender, EventArgs e) {
            if (idIndex < limSup - 1) {
                idIndex++;
                MostrarDatos();
            }
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnButtonRestaurarClicked(object sender, EventArgs e) {
            if(!CuadroMensaje("¿Deseas restaurar la entidad: " + EntryUser.Text + "?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }

            bool guardado = false;
            switch (mode) {
                case 1:
                    guardado = dtDep.RestaurarDept(listDep[idIndex].Id);
                    break;
                case 2:
                    guardado = dtr.RestaurarCargo(listCargo[idIndex].Id);
                    break;
                case 3:
                    guardado = dtEmp.RestaurarEmp(listEmp[idIndex].Id);
                    break;
                case 4:
                    guardado = dtUsr.RestaurarUsuario(listUsuarios[idIndex].Id);
                    break;
            }
            if (guardado)
                CuadroMensaje("Se ha restaurado con éxito",MessageType.Info,ButtonsType.Ok);
            else
                CuadroMensaje("Ha ocurrido un error...", MessageType.Error, ButtonsType.Ok);

            this.Destroy();
        }
    }
}