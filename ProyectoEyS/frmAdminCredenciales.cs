using System;
using System.Collections.Generic;
using Datos;
using Entidades;
using Gtk;
using Negocio;
using Vistas;

namespace ProyectoEyS {
    public partial class frmAdminCredenciales : Gtk.Window {
    
        private int mode;
        Dt_tbl_rol dtRol = new Dt_tbl_rol();
        Dt_tbl_emp dtEmp = new Dt_tbl_emp();
        Dt_tbl_usuario dtUsr = new Dt_tbl_usuario();

        List<Tbl_Empleado> empleados = new List<Tbl_Empleado>();
        List<string> formatoEmpleado = new List<string>();
        Tbl_Vw_Usuario usuario = null;

        List<Tbl_Vw_Rol> roles = new List<Tbl_Vw_Rol>();
        Ng_tbl_usuario ngUsuario = new Ng_tbl_usuario();
        Ng_tbl_emp ngEmp = new Ng_tbl_emp();

        public frmAdminCredenciales() : base(Gtk.WindowType.Toplevel) {
            this.Build();

            entryID.Text = (ngUsuario.ContarUsuarios() + 1).ToString();

            roles = dtRol.ColocarVwRol();
            empleados = dtEmp.ColocarCboxVwEmp();
            LlenarCombos();
            entryNombre.GrabFocus();
            buttonEliminar.Visible = false;
        }

        private void LlenarCombos() {
            for (int i = 0; i < roles.Count; i++) {
                this.cbeRol.InsertText(i + 1, roles[i].Nombre);
            }

            for (int i = 0; i < empleados.Count; i++) {
                formatoEmpleado.Add(empleados[i].PrimerNombre + " " + empleados[i].PrimerApellido + " - " + empleados[i].Cedula);
                this.cbeEmpleado.InsertText(i + 1, formatoEmpleado[i]);
            }
 
            empleados = null;
        }

        public void CambiarModo(Tbl_Vw_Usuario usuario) {
            mode = 1;
            labelTitulo.Text = "Seguridad: Editar Usuario";
            this.usuario = usuario;
            buttonEliminar.Visible = true;

            entryID.Text = usuario.Id.ToString();
            entryNombre.Text = usuario.Username;
            entryContraseña.Text = usuario.Clave;

            if (usuario.Empleado != string.Empty) {
                cbeEmpleado.AppendText(usuario.Empleado);
                formatoEmpleado.Add(usuario.Empleado);
            }

            SeleccionarRol();
            SeleccionarEmp();
        }

        private void SeleccionarRol() { 
            for(int i = 0; i < roles.Count; i++) {
                if (usuario.Rol == roles[i].Nombre) {
                    cbeRol.Active = i + 1;
                    return;
                }
            }
            cbeRol.Active = 0;
        }

        private void SeleccionarEmp() {
            for(int i = 0; i < formatoEmpleado.Count; i++) { 
                if(usuario.Empleado == formatoEmpleado[i]) {
                    cbeEmpleado.Active = i + 1;
                    return;
                }
            }
            cbeEmpleado.Active = 0;
        }


        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }

        protected void OnButtonGuardarClicked(object sender, EventArgs e) {
            if (mode == 0)
                GuardarUsuario();
            else
                GuardarCambios();

        }

        private Tbl_Usuario OrdenarDatos() {
            Tbl_Usuario usuario = new Tbl_Usuario();
            usuario.Username = entryNombre.Text;
            usuario.Password = entryContraseña.Text;
            usuario.IdRol = cbeRol.Active;
            return usuario;
        }

        private void GuardarUsuario() {
            try {
                if (ngUsuario.ExisteUsername(entryNombre.Text)) {
                    CuadroMensaje("Ya existe un usuario", MessageType.Error, ButtonsType.Ok);
                    return;
                }

                if (entryContraseña.Text != entryContraseñaConf.Text) {
                    CuadroMensaje("¡Las contraseñas deben ser iguales!", MessageType.Error, ButtonsType.Ok);
                    return;
                }

                if(cbeRol.ActiveText == "Sin rol asignado") {
                    CuadroMensaje("Debe asignar un rol", MessageType.Error, ButtonsType.Ok);
                    return;
                }

                Tbl_Usuario usuario = OrdenarDatos();
                usuario.Estado = 1;
                dtUsr.GuardarUsuario(usuario);

                string[] datos = cbeEmpleado.ActiveText.Split(' ');

                if (cbeEmpleado.ActiveText != "Sin empleado Asignado" && cbeEmpleado.ActiveText != this.usuario.Empleado) {
                    int idEmp = ngEmp.EncontrarEmpleado(datos[3]);
                    int idUsr = ngUsuario.EncontrarUsuario(usuario.Username);
                    dtEmp.AsignarUsuario(idUsr,idEmp);

                    CuadroMensaje("Se ha agregado y asignado correctamente",MessageType.Info,ButtonsType.Ok);
                } else
                    CuadroMensaje("Se ha agregado correctamente", MessageType.Info, ButtonsType.Ok);

                this.Destroy();

            } catch (Exception ex) {
                CuadroMensaje(ex.Message, MessageType.Error, ButtonsType.Ok);
            }
        }

        private void GuardarCambios() {
            try {
                if (entryNombre.Text != this.usuario.Username) {
                    if (ngUsuario.ExisteUsername(entryNombre.Text)) {
                        CuadroMensaje("Ya existe un usuario", MessageType.Error, ButtonsType.Ok);
                        return;
                    }
                }

                if (entryContraseña.Text != entryContraseñaConf.Text) {
                    CuadroMensaje("¡Las contraseñas deben ser iguales!", MessageType.Error, ButtonsType.Ok);
                    return;
                }

                if (cbeRol.ActiveText == "Sin rol asignado") {
                    CuadroMensaje("Debe asignar un rol", MessageType.Error, ButtonsType.Ok);
                    return;
                }

                Tbl_Usuario usuario = OrdenarDatos();
                usuario.Estado = 2;
                dtUsr.EditarUsuario(usuario, this.usuario.Id);


                if (this.usuario.Empleado == string.Empty) this.usuario.Empleado = "Sin empleado asignado";

                if (cbeEmpleado.ActiveText == this.usuario.Empleado) {
                    CuadroMensaje("Se ha guardado correctamente", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                    return;
                }

                string[] datos;
                int idEmpAnt;
                int idEmp;

                if (cbeEmpleado.Active == 0) {
                    if (this.usuario.Empleado != "Sin empleado asignado") {
                        datos = this.usuario.Empleado.Split(' ');
                        idEmpAnt = ngEmp.EncontrarEmpleado(datos[3]);
                        dtEmp.AsignarUsuario(0, idEmpAnt);
                    }
                    CuadroMensaje("Se ha guardado y reasignado correctamente", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                }

                datos = cbeEmpleado.ActiveText.Split(' ');
                idEmp = ngEmp.EncontrarEmpleado(datos[3]);
                dtEmp.AsignarUsuario(this.usuario.Id, idEmp);
                CuadroMensaje("Se ha guardado y reasignado correctamente", MessageType.Info, ButtonsType.Ok);
                this.Destroy();
            } catch (Exception ex) { }
        }


        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }


        protected void OnbuttonVerContra1Released(object sender, EventArgs e) {

        }

        protected void OnButtonVerContra1Pressed(object sender, EventArgs e) {
            entryContraseña.Visibility = true;
            buttonVerContra1.Name = "A";
        }

        protected void OnButtonVerContra2Pressed(object sender, EventArgs e) {
            entryContraseñaConf.Visibility = true;
            buttonVerContra2.Name = "A";
        }

        protected void OnButtonVerContra2Released(object sender, EventArgs e) {
            entryContraseñaConf.Visibility = false;
            buttonVerContra2.Name = "*";
        }

        protected void OnButtonVerContra1Released(object sender, EventArgs e) {
            entryContraseña.Visibility = false;
            buttonVerContra1.Name = "*";
        }

    }
}
