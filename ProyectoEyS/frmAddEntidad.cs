using System;
namespace ProyectoEyS
{
    public partial class frmAddEntidad : Gtk.Window {

        private int config;

        public frmAddEntidad() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
        }

        public void ModifAccesibilidad(int config){
            this.config = config;

            if(config == 1) {
                labelTitulo.Text = "Añadir entidad";
                labelSubTitulo.Text = "Seleccione la entidad a agregar";
            } else if(config == 0){
                labelTitulo.Text = "Listar entidad";
                labelSubTitulo.Text = "Seleccione la entidad a listar";
            }
            Console.WriteLine("config: " + config);
        }

        private void Acceder() {
            if (config == 1) {
                switch (cboxEntidad.ActiveText) {
                    case "Empleado":
                        frmAddUsuario addUsuario = new frmAddUsuario();
                        break;

                    case "Cargo":
                        frmAddCargo addCargo = new frmAddCargo();
                        break;

                    case "Departamento":
                        frmAddDept addDept = new frmAddDept();
                        break;

                    default:
                        break;
                }

            } else {
                switch (cboxEntidad.ActiveText) {
                    case "Empleado":
                        frmListarUsr listarUsr = new frmListarUsr();
                        break;

                    case "Cargo":
                        frmListarCargo listarCargo = new frmListarCargo();
                        break;

                    case "Departamento":
                        frmListarDept listarDept = new frmListarDept();
                        break;

                    default:
                        break;
                }
            }
            this.Visible = false;
        }

        protected void OnAceptarClicked(object sender, EventArgs e) {
            Acceder();
        }

        protected void OnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        }
    }
}
