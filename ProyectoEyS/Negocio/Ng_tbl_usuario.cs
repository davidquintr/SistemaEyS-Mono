using System;
using System.Data;
using System.Text;
using Datos;
using Entidades;
using Gtk;

namespace Negocio {

    public class Ng_tbl_usuario {

        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public Ng_tbl_usuario() {
        }

        public bool ExisteUsername(string username) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.tbl_Usuario ");
            sb.Append("where username = '" + username + "'");
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

        public Tbl_Usuario EncontrarSesion(string username, string password) {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];
            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            Tbl_Usuario usuario = null;

            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Usuario ");
            sb.Append("where username = '" + username + "' and password = '" + password + "';");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    usuario = creacionDatos.CargarUsuario(datos);
                }
                return usuario;
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


        public int EncontrarUsuario(string username) {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];

            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Usuario ");
            sb.Append("where username = '" + username + "'");
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

        public int ContarUsuarios() {
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];

            sb.Append("SELECT count(*) FROM BDSistemaEyS.tbl_Usuario");
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
    }

}