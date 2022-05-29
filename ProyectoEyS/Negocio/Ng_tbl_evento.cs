using System;
using System.Data;
using System.Text;
using Datos;
using Gtk;

namespace Negocio {
    public class Ng_tbl_evento {

        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public Ng_tbl_evento() {
        }

        public bool ExisteEvento(int idEmp) {
            IDataReader idr = null;
            sb.Clear();

            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Evento ");
            sb.Append("where fechaFin > '" + DateTime.Now.ToString("yy-MM-dd") + "' and idEmpleado = '" + idEmp + "'");
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
