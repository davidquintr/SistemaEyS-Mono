using System;
using Gtk;
using Entidades;
using Datos;
using System.Collections.Generic;
using Negocio;
using Vistas;
using System.Text.RegularExpressions;

namespace ProyectoEyS {
    public partial class frmAddUsuario : Gtk.Window {

        Ng_tbl_emp ngEmp = new Ng_tbl_emp();
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();
        Tbl_Usuario selectedUser;

        Tbl_Config cfg;
        Dt_tbl_config dtCfg = new Dt_tbl_config();

        Dt_tbl_emp dtEmp = new Dt_tbl_emp();
        Dt_tbl_cargo dtCargo = new Dt_tbl_cargo();
        Dt_tbl_dep dtDept = new Dt_tbl_dep();
        private int mode = 0;
        private int cantCarg;

        List<Tbl_Cargo> listCargo = new List<Tbl_Cargo>();
        List<Tbl_Departamento> listDept = new List<Tbl_Departamento>();

        Tbl_Vw_Empleado emp;


        public frmAddUsuario() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            cfg = dtCfg.colocarConfig();
            this.Title = "Agregar Empleado";
            listCargo = dtCargo.ColocarCargos();
            listDept = dtDept.ColocarDepart();
            LlenarComboDept();
            this.buttonBaja.Visible = false;
            entryID.Text = (ngEmp.ContarEmpleados() + 1).ToString();
            entryNombre.GrabFocus();
            entryEmailcorp.Text = cfg.EmailEmpresa;
            cbxEDep.HasFrame = true;
            cbxEDep.FocusOnClick = true;
            emp = new Tbl_Vw_Empleado();
        }

        public void CambiarModo(Tbl_Vw_Empleado emp) {
            this.Title = "Administrar Empleado";
            mode = 1;
            this.emp = emp;
            this.buttonBaja.Visible = true;
            SeleccionarCbx();
            LlenarCampos();
        }

        private void SeleccionarCbx() { 

            for(int i = 0; i < listDept.Count; i++) {
                cbxEDep.Active = i;
                if (cbxEDep.ActiveText == emp.Departamento) {
                    cbxEDep.Active = i;
                    break;
                }
            }

            for(int i = 0; i < cantCarg; i++) {
                cbxCargo.Active = i; 
                if(cbxCargo.ActiveText == emp.Cargo) {
                    cbxCargo.Active = i;
                    break;
                }
            }

        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        private bool Comprobaciones() {

            if (entryNombre.Text == string.Empty) {
                CuadroMensaje("Debe ingresar al menos un nombre", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (entryApell.Text == string.Empty) {
                CuadroMensaje("Debe ingresar al menos un apellido", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (entryCedu.Text == string.Empty) {
                CuadroMensaje("Debe ingresar la cédula", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (entryCedu.Text.Length < 14 || Int32.TryParse(entryCedu.Text[13].ToString(), out int result)) {
                CuadroMensaje("Ingrese una cédula válida", MessageType.Warning, ButtonsType.Ok);
                return false;
            }


            if (entryFechaNac.Text == string.Empty || entryFechaIngr.Text == string.Empty || DateTime.Parse(entryFechaNac.Text).ToString("yyyy-MM-dd") == DateTime.Now.ToString("yyyy-MM-dd")) {
                CuadroMensaje("Cambie las fechas ", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (cbxCargo.ActiveText == "") {
                CuadroMensaje("Ingrese el cargo", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if(textvDirec.Buffer.Text.Length > 100) {
                CuadroMensaje("La direccion no puede ser mayor a 100 carácteres, tienes: " + textvDirec.Buffer.Text.Length, MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (textvObservaciones.Buffer.Text.Length > 100) {
                CuadroMensaje("Las observaciones no pueden ser mayor a 100 carácteres, tienes: " + textvDirec.Buffer.Text.Length, MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (ngEmp.ExisteCorreo(entryEmailcorp.Text,emp.Id)) {
                CuadroMensaje("Este correo corporativo ya está registrado, cree una variación del mismo", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (ngEmp.ExisteCedula(entryCedu.Text,emp.Id)) {
                CuadroMensaje("Esta cédula ya existe, confirme sus datos", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            return true;
        }


        private void LlenarCampos() {
            labelTitulo.Text = "Editar usuario: " + emp.Nombres.Split(' ')[0] + " " + emp.Apellidos.Split(' ')[0];
            entryID.Text = emp.Id.ToString();
            entryNombre.Text = emp.Nombres;
            entryApell.Text = emp.Apellidos;
            entryCedu.Text = emp.Cedula;
            entryEmailcorp.Text = emp.EmailCorporativo;
            entryEmailpers.Text = emp.EmailPersonal;
            textvObservaciones.Buffer.Text = emp.Observacion;
            textvDirec.Buffer.Text = emp.Direccion;
            entryTelef.Text = emp.Telefono;
            if (emp.Sexo == "Masculino") cboxSexo.Active = 1; else cboxSexo.Active = 0;
            entryFechaNac.Text = emp.FechaNac.ToString("yyyy-MM-dd");
            entryFechaIngr.Text = emp.FechaIngreso.ToString("yyyy-MM-dd");
        }


        protected void LlenarComboCrg() {
            int count = 0;
            this.cantCarg = 0;
            cbxCargo.Clear();
            CellRendererText cell = new CellRendererText();
            cbxCargo.PackStart(cell, false);
            ListStore store = new ListStore(typeof(string));
            cbxCargo.AddAttribute(cell, "text", count);

            for (int i = 0; i < listCargo.Count; i++) {
                if (listCargo[i].IdDept == ComprobarDept()) {
                    store.AppendValues(listCargo[i].Nombre);
                    this.cantCarg++;
                }
            }

            cbxCargo.Model = store;
            cbxCargo.Entry.Completion = new EntryCompletion();
            cbxCargo.Entry.Completion.Model = store;
            cbxCargo.Entry.Completion.TextColumn = 0;
            cbxCargo.Active = 0;
        }


        protected void LlenarComboDept() {
            int count = 0;
            cbxEDep.Clear();
            CellRendererText cell = new CellRendererText();
            cbxEDep.PackStart(cell, false);
            ListStore store = new ListStore(typeof(string));
            cbxEDep.AddAttribute(cell, "text", count);

            foreach (Tbl_Departamento dept in listDept) {
                store.AppendValues(dept.Nombre);
                count++;
            }

            cbxEDep.Model = store;
            cbxEDep.Entry.Completion = new EntryCompletion();
            cbxEDep.Entry.Completion.Model = store;
            cbxEDep.Entry.Completion.TextColumn = 0;
        }

        #region acciones

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

        protected void OnButtonEliminarClicked(object sender, EventArgs e) {
            if (!CuadroMensaje("¿Deseas dar de baja a este empleado?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }
            if (dtEmp.EliminarEmp(emp.Id))
                CuadroMensaje("Se ha dado de baja al empleado", MessageType.Info, ButtonsType.Ok);
            else
                CuadroMensaje("Ha ocurrido un error...", MessageType.Info, ButtonsType.Ok);
            this.Destroy();
        }

        protected void OnCbxEDepChanged(object sender, EventArgs e) {
            LlenarComboCrg();
        }

        protected void OnCbxEDepButtonPressEvent(object o, ButtonPressEventArgs args) {
            LlenarComboCrg();
        }

        protected void OnBtFechaNacClicked(object sender, EventArgs e) {
            frmFechador fechador = new frmFechador();
            fechador.Show();
            fechador.fecha = new frmFechador.fechaPoner(this.TraerFechaNac);

        }

        private void TraerFechaNac(DateTime tiempo) {
            entryFechaNac.Text = tiempo.ToString("yyyy-MM-dd");
        }

        private void TraerFechaIngr(DateTime tiempo) {
            entryFechaIngr.Text = tiempo.ToString("yyyy-MM-dd");
        }

        protected void OnBtFechaIngrClicked(object sender, EventArgs e) {
            frmFechador fechador = new frmFechador();
            fechador.Show();
            fechador.fecha = new frmFechador.fechaPoner(this.TraerFechaIngr);
        }

        protected void OnButtonAceptarClicked(object sender, EventArgs e) {
            if (!Comprobaciones()) {
                return;
            }
            if (mode == 0) {
                if (dtEmp.GuardarEmpleado(OrganizarDatos()))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            } else {
                if (dtEmp.EditarEmpleado(OrganizarDatos(),emp.Id))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
            }
            this.Destroy();
        }

        private Tbl_Empleado OrganizarDatos() {
            Tbl_Empleado empleado = new Tbl_Empleado();
            empleado.Actividad = false;
            empleado.Cedula = entryCedu.Text;
            empleado.Direccion = textvDirec.Buffer.Text;
            empleado.Observacion = textvObservaciones.Buffer.Text;
            empleado.Telefono = entryTelef.Text;
            empleado.EmailPersonal = entryEmailpers.Text;
            empleado.EmailCorporativo = entryEmailcorp.Text;
            empleado.Sexo = cboxSexo.ActiveText == "Femenino" ? false : true;
            empleado.Actividad = false;
            empleado.Estado = 1;
            empleado.FechaAgr = DateTime.Parse(DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            empleado.FechaNac = DateTime.Parse(entryFechaNac.Text);
            empleado.FechaIngr = DateTime.Parse(entryFechaIngr.Text);
            empleado.IdCargo = ComprobarCargo();
            empleado = normalizarDatos(empleado);
            return empleado;
        }

        public Tbl_Empleado normalizarDatos(Tbl_Empleado empleado) {
            string nombres = entryNombre.Text;
            string apellidos = entryApell.Text;
            string[] corte = nombres.Split(' ');

            empleado.PrimerNombre = corte[0];
            if (corte.Length > 1) {
                for (int i = 1; i < corte.Length; i++) {
                    if (i != corte.Length - 1)
                        empleado.SegundoNombre += corte[i] + " ";
                    else
                        empleado.SegundoNombre += corte[i];
                }
            }
            corte = apellidos.Split(' ');

            empleado.PrimerApellido = corte[0];
            if (corte[1] != null) empleado.SegundoApellido = corte[1];

            return empleado;
        }

        public int ComprobarCargo() {
            foreach (Tbl_Cargo crg in listCargo)
                if (cbxCargo.ActiveText == crg.Nombre)
                    return listCargo.IndexOf(crg) + 1;
            return -1;
        }

        public int ComprobarDept() {
            foreach (Tbl_Departamento dept in listDept)
                if (cbxEDep.ActiveText == dept.Nombre)
                    return listDept.IndexOf(dept) + 1;
            return -1;
        }

        #endregion
    }
}
