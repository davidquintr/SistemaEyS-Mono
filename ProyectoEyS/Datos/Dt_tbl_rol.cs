using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Datos;
using Entidades;
using Gtk;
using Negocio;
using Vistas;

namespace Datos {

    public class Dt_tbl_rol {
        public Dt_tbl_rol() {
        }
        //Atrbituos 
        Conexion con = new Conexion();
        //MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();
        MessageDialog ms = null;

        public List<Tbl_Rol> ColocarRol() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Rol> listaRol = new List<Tbl_Rol>();
            Tbl_Rol rol;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Rol ");
            sb.Append("WHERE estado !=3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    rol = creacionDatos.CargarRol(datos);
                    listaRol.Add(rol);
                }//fin de while
                return listaRol;
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


        public List<Tbl_Vw_Rol> ColocarVwRol() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Rol> listaRol = new List<Tbl_Vw_Rol>();
            Tbl_Vw_Rol rol;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Rol ");
            sb.Append("WHERE estado !=3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    rol = creacionDatos.CargarVwRol(datos);
                    listaRol.Add(rol);
                }//fin de while
                return listaRol;
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

        public bool GuardarRol(Tbl_Rol rol) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("INSERT INTO BDSistemaEyS.tbl_Rol ");
            sb.Append("(nombre, estado) ");
            sb.Append("VALUES ('" + rol.Nombre + "','" + 1 + "')");

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

        public bool EditarRol(Tbl_Rol rol, int id) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("UPDATE BDSistemaEyS.tbl_Rol ");
            sb.Append("SET nombre = '" + rol.Nombre + "', estado = '" + rol.Estado + "' ");
            sb.Append("WHERE (idRol = '" + id + "');");

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

        public ListStore listarRoles() {
            ListStore datos = new ListStore(typeof(string),
                typeof(string));


            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT id, nombre FROM BDSistemaEyS.Vw_Rol where estado <> 3;");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read()) {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString());
                    //dr.Close();
                }//fin de while
                return datos;
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
        }//fin del metodo


        public ListStore buscarRol(String cadena)
        {
            ListStore datos = new ListStore(typeof(string),
                typeof(string));

            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE BDSistemaEyS;");
            sb.Append("SELECT id, nombre FROM BDSistemaEyS.Vw_Rol ");
            sb.Append("WHERE nombre like '%" + cadena + "%' and estado <> 3");
           

            try
            {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read())
                {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString());
                    //dr.Close();
                }//fin de while
                return datos;
            }
            catch (Exception e)
            {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Error: " + e.StackTrace);
                throw;
            }
            finally
            {
                idr.Close();
                con.CerrarConexion();
            }
        }//fin del metodo


    }

}
