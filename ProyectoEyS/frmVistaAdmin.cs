using System;
using Entidades;
using Gtk;
using Datos;
using Negocio;

namespace ProyectoEyS {
    public partial class vistaAdmin : Gtk.Window {

        Dt_tbl_emp dtus = new Dt_tbl_emp();

        private Gtk.Window callMainWindow;
        public Window CallMainWindow { get => callMainWindow; set => callMainWindow = value; }

        WatchClock clock;


        public vistaAdmin() : base(Gtk.WindowType.Toplevel) {
            try {
                this.Build();
                //Creamos un objeto de la clase WatchClock
                clock = new WatchClock();
                clock.ObtenerDimensiones(123, 100);
                ClockStart();
            } catch (Exception ex) { }
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

        protected void OnDepartamentoAction1Activated(object sender, EventArgs e) {
            frmListarDept listarDept = new frmListarDept();
        }

        protected void OnEmpleadoListarActivated(object sender, EventArgs e) {
            frmListarUsr listarUsr = new frmListarUsr();
        }

        protected void OnCargoListarActivated(object sender, EventArgs e) {
            frmListarCargo listarCargo = new frmListarCargo();
        }

        protected void OnDepartamentoAddActivated(object sender, EventArgs e) {
            frmAddDept addDept = new frmAddDept();
        }

        protected void OnCargoAddActivated(object sender, EventArgs e) {
            frmAddCargo addCargo = new frmAddCargo();
        }

        protected void OnEmpleadoAddActivated(object sender, EventArgs e) {
            frmAddUsuario addUsuario = new frmAddUsuario();
        }

        protected void OnCrearUsuarioActionActivated(object sender, EventArgs e) {
            frmAdminCredenciales adminCredenciales = new frmAdminCredenciales();
        }

        protected void OnAdministrarUsuarioActionActivated(object sender, EventArgs e) {
            frmAdminCredenciales adminCredenciales = new frmAdminCredenciales();

        }

        protected void OnRolActionActivated(object sender, EventArgs e) {
            frmAddRol addRol = new frmAddRol(); // Campo para añadir rol
        }

        protected void OnUsuarioActionActivated(object sender, EventArgs e) {
            frmAdminCredenciales adminCredenciales = new frmAdminCredenciales();
        }

        protected void OnPermisosAction1Activated(object sender, EventArgs e) {
            frmSeguridadPermisos seguridadPermisos = new frmSeguridadPermisos();
        }

        protected void OnRolAction3Activated(object sender, EventArgs e) { // Listar rol
            frmListarRoles listarRoles = new frmListarRoles();

        }

        protected void OnUsuarioAction3Activated(object sender, EventArgs e) {
            frmListarCredenciales listarCredenciales = new frmListarCredenciales();
        }

        protected void OnRestaurarDeptActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(1);
        }

        protected void OnRestaurarCargoActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(2);
        }

        protected void OnRestaurarEmpActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(3);
        }

        protected void OnParamGenButtActivated(object sender, EventArgs e) {
            frmParametrosGen parametrosGen = new frmParametrosGen();
        }

        protected void OnRestaurarUserActivated(object sender, EventArgs e) {
            frmRestauracionEntidades restauracionEntidades = new frmRestauracionEntidades();
            restauracionEntidades.CambiarModo(4);

        }
    }
}
