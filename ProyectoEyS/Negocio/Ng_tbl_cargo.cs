using System;
using System.Data;
using System.Text;
using Datos;
using Gtk;

namespace Negocio {
    public class Ng_tbl_cargo {


        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        public Ng_tbl_cargo() {
        }

        public int ContarCargos() {
            IDataReader idr = null;
            sb.Clear();
            string[] datos;

            sb.Append("SELECT count(*) FROM BDSistemaEyS.tbl_Cargo");
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
