using System;
using Gtk;
using ProyectoEyS;
using Datos;
using Entidades;
using Negocio;
using Vistas;

public partial class MainWindow : Gtk.Window {

    private vistaAdmin vistaAdmin;
    private vistaUsuario vistaUsuario = new vistaUsuario();

    private Tbl_Usuario selectedUser;
    private Tbl_Vw_Empleado selectedEmp;
    private Tbl_Vw_Usuario selectedVwUser;

    private Ng_tbl_usuario ngUsuario = new Ng_tbl_usuario();
    private Ng_tbl_emp ngEmp = new Ng_tbl_emp();
    private Ng_tbl_OpcRol ngOpRol = new Ng_tbl_OpcRol();
    private Ng_tbl_evento ngEvento = new Ng_tbl_evento();

    private Dt_tbl_usuario dtUsuario = new Dt_tbl_usuario();


    public MainWindow() : base(Gtk.WindowType.Toplevel) {
        vistaUsuario.Hide();
        Build();
    }

    private void Evaluar() {
        selectedUser = null;
        selectedUser = dtUsuario.EncontrarSesion(entryID.Text, entryPin.Text);

        if (selectedUser == null) {
            CuadroMensaje("Credenciales incorrectas, verifique sus credenciales o consulte a un administrador.", MessageType.Error, ButtonsType.Ok);
            return;
        }

        selectedEmp = ngEmp.VistaEmpleado(selectedUser.Username);

        if (!ngOpRol.AccesoViewAdmin(selectedUser.IdRol)) {
            AccederUser();
            return;
        }else {
            AccederAdmin();
        }

    }
    private void AccederAdmin() {
        if (CuadroMensaje("¿Quieres iniciar como administrador?", MessageType.Question, ButtonsType.YesNo)) {
            selectedVwUser = dtUsuario.EncontrarVwUsuario(entryID.Text);
            vistaAdmin = new vistaAdmin();
            vistaAdmin.CallMainWindow = this;
            vistaAdmin.ConfigurarInicio(selectedUser, selectedEmp, selectedVwUser);
            this.Hide();
        } else {
            AccederUser();
        }
    }

    private void AccederUser() {
        if (selectedEmp == null) {
            CuadroMensaje("No hay empleado asociado a su usuario, contacte con el soporte técnico.", MessageType.Error, ButtonsType.Ok);
            return;
        }

        if (ngEvento.ExisteEvento(selectedEmp.Id)) {
            CuadroMensaje("Este usuario tiene un evento activo, consulte al administrador.", MessageType.Warning, ButtonsType.Ok);
            return;
        }

        vistaUsuario = new vistaUsuario();
        vistaUsuario.ConfigurarInicio(selectedEmp);
        vistaUsuario.CallMainWindow = this;
        this.Hide();
    }

    protected void OnButtonCerrarClicked(object sender, EventArgs e) {
        Application.Quit();
    }

    protected void OnEntryPinActivated(object sender, EventArgs e) {
        Evaluar();
    }


    protected void OnButtonAdminClicked(object sender, EventArgs e) {
        Evaluar();
    }

    bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
        Gtk.MessageDialog msgEliminar;
        msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
        ResponseType respuesta = ( ResponseType )msgEliminar.Run();
        msgEliminar.Destroy();
        return respuesta == ResponseType.Yes ? true : false;
    }

    protected void OnButton41Clicked(object sender, EventArgs e) {
        Application.Quit();
    }
}