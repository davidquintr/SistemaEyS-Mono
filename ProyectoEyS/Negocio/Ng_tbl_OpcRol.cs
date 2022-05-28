using System;
using System.Data;
using System.Text;
using Datos;
using Gtk;

namespace Negocio {
    public class Ng_tbl_OpcRol {

        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();
        public Ng_tbl_OpcRol() {
        }
        public bool AccesoVentana(string form, int idRol) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.Vw_OpcRol ");
            sb.Append("where idrol = '" + idRol + "'" + "and nombre = '" + form +"' ");
            sb.Append("and activo = b'1'");
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

        public bool AccesoViewAdmin(int idRol) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("Select * from BDSistemaEyS.Vw_OpcRol ");
            sb.Append("where idrol = '" + idRol + "' ");
            sb.Append("and activo = b'1'");
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
