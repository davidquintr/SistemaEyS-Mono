using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;
using Vistas;

namespace Datos 
{
    public class Dt_tbl_evento {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Vw_Evento> colocarVwEventos() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Evento> listarEventos = new List<Tbl_Vw_Evento>();
            Tbl_Vw_Evento evento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Evento;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    evento = creacionDatos.CargarVwEvento(datos);
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

        }

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


        public bool GuardarEvento(Tbl_Evento eve) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("INSERT INTO BDSistemaEyS.tbl_Evento ");
            sb.Append("(fechaInicio, fechaFin, razon, descripcion, estado, idEmpleado) ");
            sb.Append("VALUES ('" + eve.FechaInicio.ToString("yy-MM-dd") + "','" + eve.FechaFin.ToString("yy-MM-dd") + "','" + eve.Razon + "','" + eve.Descripcion + "','" + eve.Estado + "','" + eve.IdEmp + "')");

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
    }
}