using System;
using System.Data;
using System.Text;
using Datos;
using Gtk;

namespace Negocio {
    public class Ng_tbl_departamento {

        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public Ng_tbl_departamento() {
        }

        public int ContarDepts() {
            IDataReader idr = null;
            sb.Clear();
            string[] datos;

            sb.Append("SELECT count(*) FROM BDSistemaEyS.tbl_Departamento");
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

        public bool ExisteCorreo(string correo, int idDept) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.tbl_Departamento ");
            sb.Append("where email = '" + correo + "' and idDepartamento <> " + idDept);
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
