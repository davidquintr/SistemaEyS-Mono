using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;

namespace Datos 
{
    public class Dt_tbl_evento {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Evento> colocarEventos() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Evento> listarEventos = new List<Tbl_Evento>();
            Tbl_Evento evento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Evento;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    evento = creacionDatos.CargarEvento(datos);
                    listarEventos.Add(evento);
                }//fin de while
                return listarEventos;
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