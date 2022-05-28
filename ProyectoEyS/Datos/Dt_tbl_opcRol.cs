using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;
using System;

namespace Datos {
    public class Dt_tbl_opcRol {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();
        int idRol;

        #region metodos

        public List<Tbl_OpcRol> ColocarOpcCar() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_OpcRol> listarOpcCar = new List<Tbl_OpcRol>();
            Tbl_OpcRol opcCar;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_OpcRol;");

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

        public List<Tbl_OpcRol> EncontrarOpcRol(int idRol) {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_OpcRol> listarOpcRol = new List<Tbl_OpcRol>();
            Tbl_OpcRol opcRol;
            IDataReader idr = null;
            this.idRol = idRol;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_OpcRol ");
            sb.Append("WHERE idRol = '" + idRol + "';");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    opcRol = creacionDatos.CargarOpcRol(datos);
                    listarOpcRol.Add(opcRol);
                }//fin de while
                return listarOpcRol;
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


        public bool GuardarOpcRol(List<Tbl_OpcRol> listOr) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            for (int i = 0; i < 19; i++) {
                sb.Append("INSERT INTO BDSistemaEyS.tbl_OpcRol ");
                sb.Append("(activo, idOpcion, idRol) ");
                sb.Append("VALUES ( b'" + Convert.ToInt16(listOr[i].Activo) + "', '" + (i + 1) + "', '" + listOr[i].IdRol + "'); ");
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

        public bool EditarOpcRol(List<Tbl_OpcRol> listOr) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            for (int i = 0; i < 19; i++) {
                sb.Append("UPDATE BDSistemaEyS.tbl_OpcRol ");
                sb.Append("set activo = b'" + Convert.ToInt16(listOr[i].Activo) + "' ");
                sb.Append("WHERE idRol = '" + listOr[i].IdRol + "' ");
                sb.Append("and idOpcion = '" + listOr[i].IdOpcion + "';");
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
        #endregion
    }
}