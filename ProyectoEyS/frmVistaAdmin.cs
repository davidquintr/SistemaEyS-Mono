using System;
using Entidades;
using Gtk;
using Datos;
using Negocio;
using Vistas;
using System.Collections.Generic;

namespace ProyectoEyS {

    public partial class vistaAdmin : Gtk.Window {

        Dt_tbl_emp dtus = new Dt_tbl_emp();
        Dt_tbl_evento dtEvento = new Dt_tbl_evento();

        Tbl_Usuario selectedUser;
        Tbl_Vw_Empleado selectedEmp;
        Tbl_Vw_Usuario selectedVwUser;
        private int idRolAct;

        private Gtk.Window callMainWindow;
        public Window CallMainWindow { get => callMainWindow; set => callMainWindow = value; }
        public int IdRolAct { get => idRolAct; set => idRolAct = value; }

        WatchClock clock;


        public vistaAdmin() : base(Gtk.WindowType.Toplevel) {
            try {
                this.Build();

                this.trvwEmpleado.Model = dtus.listarEntradas();
                string[] titulos = { "Nombres", "Apellidos", "Cedula", "Departamento", "Cargo", "Fecha", "Hora entrada", "Hora salida" };
                for (int i = 0; i < titulos.Length; i++)
                {
                    this.trvwEmpleado.AppendColumn(titulos[i], new CellRendererText(), "text", i);
                }

                //Creamos un objeto de la clase WatchClock
                clock = new WatchClock();
                clock.ObtenerDimensiones(137, 137);
                ClockStart();
                TextoEvento();




            } catch (Exception ex) { }
        }

        private void TextoEvento() {
            List<Tbl_Vw_Evento> eventos = new List<Tbl_Vw_Evento>();
            eventos = dtEvento.colocarVwEventos();
            tvEvento.Buffer.Text = "";

            for(int i = 0; i < eventos.Count; i++) {
                tvEvento.Buffer.Text += "Evento # " + (i + 1) + "\n" +
                                     "Empleado: " + eventos[i].EmpleadoSel + "\n" +
                                     "Fecha de Inicio: " + eventos[i].FechaInicio.ToString("d") + "\n" +
                                     "Fecha de Fin: " + eventos[i].FechaFin.ToString("d") + "\n" + 
                                     "Razon: " + eventos[i].Razon + "\n" + 
                                     "Descripcion: " + eventos[i].Descripcion + "\n\n";
            }
        }

        public void ConfigurarInicio(Tbl_Usuario selectedUser, Tbl_Vw_Empleado selectedEmp, Tbl_Vw_Usuario SelectedVwUser) {
            this.selectedUser = selectedUser;
            this.selectedEmp = selectedEmp;
            this.selectedVwUser = SelectedVwUser;

            if (selectedEmp != null) {
                labelCargo.Text = selectedEmp.Cargo + " / " + selectedVwUser.Rol;
                labelEmp.Text = selectedEmp.Nombres.Split(' ')[0] + " " + selectedEmp.Apellidos.Split(' ')[0] + " / " + selectedUser.Username;
            } else {
                labelCargo.Text = selectedVwUser.Rol;
                labelEmp.Text = selectedUser.Username;
            }
        }

        void ClockStart() {
            GLib.Timeout.Add(100, new GLib.TimeoutHandler(Update));
        }

        //Dibujamos la hora y las lineas de las horas
        bool Update() {
            drawingarea1.GdkWindow.Clear();
            labelHora.Text = DateTime.Now.ToString("HH:mm:ss");

            clock.DrawRing(drawingarea1.GdkWindow);
            clock.HourLine(drawingarea1.GdkWindow);
            clock.MinuteLine(drawingarea1.GdkWindow);
            clock.SecondsLine(drawingarea1.GdkWindow);
            return true;
        }

        protected void OnCerrarSesinAction2Activated(object sender, EventArgs e) {
            callMainWindow.Show();
            this.Hide();
        }

        protected void OnDepartamentoAction1Activated(object sender, EventArgs e) { // valido
            frmListarDept listarDept = new frmListarDept();
            listarDept.ComprobarPermiso(selectedUser);

        }

        protected void OnEmpleadoListarActivated(object sender, EventArgs e) { // valido
            frmListarUsr listarUsr = new frmListarUsr();
            listarUsr.ComprobarPermiso(selectedUser);

        }

        protected void OnCargoListarActivated(object sender, EventArgs e) { //valido
            frmListarCargo listarCargo = new frmListarCargo();
            listarCargo.ComprobarPermiso(selectedUser);
        }

        protected void OnDepartamentoAddActivated(object sender, EventArgs e) { //valido
            frmAddDept addDept = new frmAddDept();
            addDept.ComprobarPermiso(selectedUser);
        }

        protected void OnCargoAddActivated(object sender, EventArgs e) { // valido
            frmAddCargo addCargo = new frmAddCargo();
            addCargo.ComprobarPermiso(selectedUser);
        }

        protected void OnEmpleadoAddActivated(object sender, EventArgs e) { // valido
            frmAddUsuario addUsuario = new frmAddUsuario();
            addUsuario.ComprobarPermiso(selectedUser);
        }

        protected void OnRolActionActivated(object sender, EventArgs e) { //valido
            frmAddRol addRol = new frmAddRol(); // Campo para añadir rol
            addRol.ComprobarPermiso(selectedUser);
        }

        protected void OnUsuarioActionActivated(object sender, EventArgs e) { //valido
            frmAdminCredenciales adminCredenciales = new frmAdminCredenciales();
            adminCredenciales.ComprobarPermiso(selectedUser);
        }

        protected void OnPermisosAction1Activated(object sender, EventArgs e) {
            frmSeguridadPermisos seguridadPermisos = new frmSeguridadPermisos();
        }

        protected void OnRolAction3Activated(object sender, EventArgs e) { // Listar rol
            frmListarRoles listarRoles = new frmListarRoles();
            listarRoles.ComprobarPermiso(selectedUser);
        }

        protected void OnUsuarioAction3Activated(object sender, EventArgs e) { // valido
            frmListarCredenciales listarCredenciales = new frmListarCredenciales();
            listarCredenciales.ComprobarPermiso(selectedUser);
        }

        protected void OnRestaurarDeptActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(1);
            restauracionEntidades.ComprobarPermiso(selectedUser);

        }

        protected void OnRestaurarCargoActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(2);
            restauracionEntidades.ComprobarPermiso(selectedUser);
        }

        protected void OnRestaurarEmpActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(3);
            restauracionEntidades.ComprobarPermiso(selectedUser);
        }

        protected void OnParamGenButtActivated(object sender, EventArgs e) {
            frmParametrosGen parametrosGen = new frmParametrosGen();
            parametrosGen.ComprobarPermiso(selectedUser);
        }

        protected void OnRestaurarUserActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(4);
            restauracionEntidades.ComprobarPermiso(selectedUser);
        }
    }
}
