using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;

namespace Datos 
{
    public class Dt_tbl_opcion {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Opcion> ColocarOpciones() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Opcion> listarOpciones = new List<Tbl_Opcion>();
            Tbl_Opcion opcion;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Opcion;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    opcion = creacionDatos.CargarOpcion(datos);
                    listarOpciones.Add(opcion);
                }//fin de while
                return listarOpciones;
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
