using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;
using System;

namespace Datos 
{
    public class Dt_tbl_opcRol {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_OpcRol> ColocarOpcCar() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_OpcRol> listarOpcCar = new List<Tbl_OpcRol>();
            Tbl_OpcRol opcCar;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_OpcCar;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    opcCar = creacionDatos.CargarOpcRol(datos);
                    listarOpcCar.Add(opcCar);
                }//fin de while
                return listarOpcCar;
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
            #endregion
        }
    }
}
