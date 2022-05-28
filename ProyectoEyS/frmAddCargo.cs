using System;
using Gtk;
using Entidades;
using Datos;
using System.Collections.Generic;
using Vistas;
using Negocio;

namespace ProyectoEyS {
    public partial class frmAddCargo : Gtk.Window {

        private int mode = 0;
        Ng_tbl_cargo ngCargo = new Ng_tbl_cargo();

        Dt_tbl_cargo dtCrg = new Dt_tbl_cargo();
        Dt_tbl_dep dtDept = new Dt_tbl_dep();
        Dt_tbl_horario dtHorario = new Dt_tbl_horario();

        Tbl_Cargo crg = new Tbl_Cargo();
        Tbl_Vw_Cargo crgVw = new Tbl_Vw_Cargo();

        List<Tbl_Vw_Departamento> depList = new List<Tbl_Vw_Departamento>();
        List<Tbl_Horario> horaList;


        public frmAddCargo() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            this.buttonEliminar.Visible = false;
            depList = dtDept.CbxDepartamentos();
            entryID.Text = (ngCargo.ContarCargos() + 1).ToString();
            entryNombre.GrabFocus();
            LlenarComboDept();
        }

        public void CambiarModo(Tbl_Vw_Cargo crgVw) {
            mode = 1;
            labelTitulo.Text = "Editar cargo: Cargo";
            this.buttonEliminar.Visible = true;
            this.horaList = dtHorario.colocarHorarios(crgVw.Id);
            this.crgVw = crgVw;
            LlenarCampos();
        }


        public void LlenarCampos() {
            entryID.Text = crgVw.Id.ToString();
            entryNombre.Text = crgVw.Nombre;
            cbxEDep.Active = EncontrarDepartamento(crgVw.Departamento);
            textvDesc.Buffer.Text = crgVw.Descripcion;
        }


        public int EncontrarDepartamento(String dep) {
            foreach (Tbl_Vw_Departamento dpt in depList)
                if (dpt.Nombre == dep)
                    return depList.IndexOf(dpt);
            return -1;
        }


        protected void LlenarComboDept() {
            for (int i = 0; i < depList.Count; i++) {
                this.cbxEDep.InsertText(i, depList[i].Nombre);
            }
        }


        private Tbl_Cargo OrganizarDatos() {
            crg.Nombre = entryNombre.Text;
            crg.IdDept = ComprobarDepartamento();
            crg.Descripcion = textvDesc.Buffer.Text;

            return crg;
        }


        private int ComprobarDepartamento() {
            foreach (Tbl_Vw_Departamento dep in depList)
                if (cbxEDep.ActiveText == dep.Nombre)
                    return dep.Id;
            return -1;
        }


        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }


        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            int conteoError = 0;

            if (!CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }
            if (horaList == null) {
                    CuadroMensaje("Debes establecer los horarios antes de guardar", MessageType.Error, ButtonsType.Ok);
                    return;
                }

            for (int i = 0; i < horaList.Count; i++) {
                horaList[i].IdCargo = Convert.ToInt16(entryID.Text);
            }

            if (mode == 0) {
                if (dtCrg.GuardarCargo(OrganizarDatos()))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado", MessageType.Error, ButtonsType.Ok);
                this.Destroy();

                for(int i = 0; i < horaList.Count; i++) {
                    if (dtHorario.GuardarHorario(horaList[i]))
                        conteoError++;
                }

            } else {
                crg.Estado = 2;
                if (dtCrg.EditarCargo(OrganizarDatos(), crgVw.Id))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado", MessageType.Error, ButtonsType.Ok);
                    this.Destroy();

                for (int i = 0; i < horaList.Count; i++) {
                    if (!dtHorario.EditarHorario(horaList[i]))
                        conteoError++;
                }
            }
            //if (conteoError > 0) CuadroMensaje("Han ocurrido " + conteoError + " errores", MessageType.Error, ButtonsType.Ok);
            this.Destroy();
        }


        protected void OnButtonEliminarClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas eliminar este cargo?", MessageType.Question, ButtonsType.YesNo)) {
                crg.Estado = 3;
                if (dtCrg.EditarCargo(OrganizarDatos(), crgVw.Id))
                    CuadroMensaje("Se ha eliminado el cargo", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            }
        }

        protected void OnButtonHorarioClicked(object sender, EventArgs e) {
            if (mode == 1) {
                frmEstablecerHorarios establecerHorarios = new frmEstablecerHorarios();
                establecerHorarios.CallAddCargo = this;
                establecerHorarios.CambiarModo(horaList);
            } else {
                frmEstablecerHorarios establecerHorarios = new frmEstablecerHorarios();
                establecerHorarios.CallAddCargo = this;
            }
        }

        public void EstablecerHorarios(List<Tbl_Horario> horaList) {
            this.horaList = horaList;

        }

    }
}