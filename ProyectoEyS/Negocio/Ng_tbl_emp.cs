using System;
using System.Data;
using System.Text;
using Datos;
using Gtk;
using Vistas;

namespace Negocio {

    public class Ng_tbl_emp {

        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public Ng_tbl_emp() {

        }

        public int ContarEmpleados() {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];

            sb.Append("SELECT count(*) FROM BDSistemaEyS.tbl_Empleado");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                }
                return int.Parse(datos[0]);
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }

        public int EncontrarEmpleado(string cedula) {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];

            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Empleado ");
            sb.Append("where cedula = '" + cedula + "'");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                }
                return int.Parse(datos[0]);
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }

        public Tbl_Vw_Empleado VistaEmpleado(string usuario) {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];
            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            Tbl_Vw_Empleado empleado = null;
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Empleado where usuario = '" + usuario + "'");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];
                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    empleado = creacionDatos.CargarVwEmpleado(datos);
                }
                return empleado;
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }

        public bool ExisteCorreo(string correo) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.tbl_Empleado ");
            sb.Append("where emailCorporativo = '" + correo + "'");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                int i = 0;
                while (idr.Read()) {
                    i++;
                }
                if (i > 0)
                    return true;

                return false;
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }

        public bool ExisteCedula(string cedula) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.tbl_Empleado ");
            sb.Append("where cedula = '" + cedula + "'");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                int i = 0;
                while (idr.Read()) {
                    i++;
                }
                if (i > 0)
                    return true;

                return false;
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }

    }

}