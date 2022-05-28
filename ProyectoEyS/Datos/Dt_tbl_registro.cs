using System;
using Gtk;
using System.Collections.Generic;
using Entidades;
using Negocio;


//Clase de conexion
using Datos;
using System.Text;
using System.Data;
using Vistas;

namespace Datos {
    public class Dt_tbl_registro {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();
        IDataReader idr = null;

        Tbl_Registro tblReg = new Tbl_Registro();

        #region metodos

        public List<Tbl_Registro> ColocarRegistros() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Registro> listaRegistros = new List<Tbl_Registro>();
            Tbl_Registro registro;
            idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Registro;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    registro = creacionDatos.CargarRegistro(datos);
                    listaRegistros.Add(registro);
                }//fin de while

                return listaRegistros;
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

        public bool GuardarRegistro(Tbl_Registro reg, int modoEjec, int idRegistro) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            switch (modoEjec) {
                case 1:
                    sb.Append("INSERT INTO BDSistemaEyS.tbl_Registro ");
                    sb.Append("(horaEntrada, idEmpleado) ");
                    sb.Append("VALUES ('" + reg.HoraEntrada.ToString("yyyy-MM-dd H:mm:ss") + "','" + reg.IdEmp + "')");
                    break;
                case 2:
                    sb.Append("UPDATE BDSistemaEyS.tbl_Registro ");
                    sb.Append("SET horaSalida = '" + reg.HoraSalida.ToString("yyyy-MM-dd H:mm:ss") + "' ");
                    sb.Append("WHERE (idRegistro = '" + idRegistro + "');");
                    break;
                case 3:
                    sb.Append("UPDATE BDSistemaEyS.tbl_Registro ");
                    sb.Append("SET horaAlmuerzoIn = '" + reg.HoraAlmuerzoIn.ToString("yyyy-MM-dd H:mm:ss") + "' ");
                    sb.Append("WHERE (idRegistro = '" + idRegistro + "');");
                    break;
                case 4:
                    sb.Append("UPDATE BDSistemaEyS.tbl_Registro ");
                    sb.Append("SET horaAlmuerzoOut = '" + reg.HoraAlmuerzoOut.ToString("yyyy-MM-dd H:mm:ss") + "' ");
                    sb.Append("WHERE (idRegistro = '" + idRegistro + "');");
                    break;
            }

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

        public List<Tbl_Vw_Registro> ColocarVwRegistros() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Registro> listaRegistros = new List<Tbl_Vw_Registro>();
            Tbl_Vw_Registro registro;
            idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Registro;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    registro = creacionDatos.CargarVwRegistro(datos);
                    listaRegistros.Add(registro);
                }//fin de while

                return listaRegistros;
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

        public List<Tbl_Registro> EncontrarRegistros(int id) {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Registro> listaRegistros = new List<Tbl_Registro>();
            Tbl_Registro registro;
            idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Registro ");
            sb.Append("WHERE idEmpleado = '" + id + "'; ");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    registro = creacionDatos.CargarRegistro(datos);
                    listaRegistros.Add(registro);
                }//fin de while

                return listaRegistros;
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



        #endregion

    }
}