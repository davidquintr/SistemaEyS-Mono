using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;

namespace Datos {
    public class Dt_tbl_config {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public Tbl_Config colocarConfig() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            Tbl_Config cfg = new Tbl_Config();
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Config;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    cfg = creacionDatos.CargarConfig(datos);
                }//fin de while
                return cfg;
            }
            catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                throw;
            }
            finally {
                idr.Close();
                con.CerrarConexion();
            }

        }

        public bool EditarConfig(Tbl_Config cfg) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Config ");
            sb.Append("SET nombreEmpresa = '" + cfg.NombreEmpresa + "', hAlmuerzoIn = '" + cfg.HAlmuerzoIn.ToString("yyyy-MM-dd H:mm:ss") + "', hAlmuerzoOut = '" + cfg.HAlmuerzoOut.ToString("yyyy-MM-dd H:mm:ss") + "', tiempoGracia = '" + cfg.TiempoGracia + "', emailEmpresa = '" + cfg.EmailEmpresa + "' where idConfig = 1");

            try {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0) {
                    guardado = true;
                }
                return guardado;
            }
            catch (Exception e) {
                Console.WriteLine("Error jiji " + e.ToString());
            }
            finally {
                con.CerrarConexion();
            }
            return guardado;
        }
        #endregion

        public bool GuardarOpcion(Tbl_Config opc) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("INSERT INTO BDSistemaEyS.tbl_Config ");
            sb.Append("(nombreEmpresa, hAlmuerzoIn, hAlmuerzoOut, tiempoGracia, emailEmpresa) ");
            sb.Append("VALUES ('" + opc.NombreEmpresa + "','" + opc.HAlmuerzoIn.ToString("yyyy-MM-dd H:mm:ss") +"','" + opc.HAlmuerzoOut.ToString("yyyy-MM-dd H:mm:ss") + "','" + opc.TiempoGracia + "','" + opc.EmailEmpresa + "')");
                
            try {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0) {
                    guardado = true;
                }
                return guardado;
            } catch (Exception e) {
                Console.WriteLine("Error jiji " + e.ToString());
            } finally {
                con.CerrarConexion();
            }
            return guardado;
        }
    }


}
