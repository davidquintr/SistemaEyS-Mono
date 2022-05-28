using System;
using Gtk;
using Entidades;
using Vistas;
using Datos;

namespace ProyectoEyS {
    public partial class frmEstablecerEventos : Gtk.Window {
        int idEmp = 0;
        Tbl_Evento eve = new Tbl_Evento();
        Dt_tbl_evento dtEve = new Dt_tbl_evento();

        public frmEstablecerEventos() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        public void CargarDatos(Tbl_Vw_Empleado empVw) {
            labelTitulo.Text = "Establecer evento para " + empVw.Nombres.Split(' ')[0] + " " + empVw.Apellidos.Split(' ')[0];
            idEmp = empVw.Id;
        }

        private void OrganizarDatos() {
            eve.Razon = entryRazon.Text;
            eve.FechaInicio = cldFechaInicio.GetDate();
            eve.FechaFin = cldFechaFin.GetDate();
            eve.Descripcion = textvDescripcion.Buffer.Text;
            eve.Estado = 1;
            eve.IdEmp = idEmp;
        }



        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }

        protected void OnButtonSaveClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                OrganizarDatos();
                if (dtEve.GuardarEvento(eve)) {
                    CuadroMensaje("Se han guardado los cambios", MessageType.Info, ButtonsType.Ok);
                    this.Destroy();
                }
            }
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = (ResponseType)msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }
    }
}