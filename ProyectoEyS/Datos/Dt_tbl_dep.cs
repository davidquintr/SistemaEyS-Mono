using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;
using Vistas;

namespace Datos {
    public class Dt_tbl_dep {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region rellenarDepartamento
        public List<Tbl_Vw_Departamento> CbxDepartamentos() {

            List<Tbl_Vw_Departamento> departamentos = new List<Tbl_Vw_Departamento>();
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT id, nombre FROM BDSistemaEyS.Vw_Departamento WHERE estado<>3");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());

                while (idr.Read()) {
                    Tbl_Vw_Departamento tbDept = new Tbl_Vw_Departamento() {
                        Id = int.Parse(idr["id"].ToString()),
                        Nombre = idr["nombre"].ToString(),
                    };
                    departamentos.Add(tbDept);
                }
                idr.Close();
                return departamentos;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            } finally {
                con.CerrarConexion();
            }
        }

        public List<Tbl_Departamento> ColocarDepart() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Departamento> listaDepart = new List<Tbl_Departamento>();
            Tbl_Departamento departamento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Departamento;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    departamento = creacionDatos.CargarDepartamento(datos);
                    listaDepart.Add(departamento);
                }//fin de while
                return listaDepart;
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
            #endregion
        }


        public List<Tbl_Vw_Departamento> ColocarVwDepart() {
            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Departamento> listaDepart = new List<Tbl_Vw_Departamento>();
            Tbl_Vw_Departamento departamento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Departamento ");
            sb.Append("WHERE estado <> 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    departamento = creacionDatos.CargarVwDepartamento(datos);
                    listaDepart.Add(departamento);
                }//fin de while
                return listaDepart;
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

        public List<Tbl_Vw_Departamento> ColocarVwDepartElim() {
            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Departamento> listaDepart = new List<Tbl_Vw_Departamento>();
            Tbl_Vw_Departamento departamento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Departamento ");
            sb.Append("WHERE estado = 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    departamento = creacionDatos.CargarVwDepartamento(datos);
                    listaDepart.Add(departamento);
                }//fin de while
                return listaDepart;
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

        public bool GuardarDepartamento(Tbl_Departamento dep) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("INSERT INTO BDSistemaEyS.tbl_Departamento ");
            sb.Append("(nombre, ext, email, descripcion, estado) ");
            sb.Append("VALUES ('" + dep.Nombre + "','" + dep.Ext + "','" + dep.Email + "','" + dep.Descripcion + "','" + 1 + "')");

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


        public bool EditarDepartamento(Tbl_Departamento dep, int id) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Departamento ");
            sb.Append("SET nombre = '" + dep.Nombre + "', ext = '" + dep.Ext + "', email = '" + dep.Email + "', descripcion = '" + dep.Descripcion + "', estado = '" + dep.Estado + "' ");
            sb.Append("WHERE (idDepartamento = '" + id + "');");

            if (dep.Estado == 3) {
                sb.Append("UPDATE BDSistemaEyS.tbl_Cargo ");
                sb.Append("SET estado = '3'");
                sb.Append("WHERE idDepartamento = '" + id + "';");
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

        public bool RestaurarDept(int id) {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("update BDSistemaEyS.tbl_Departamento ");
            sb.Append("SET estado = '2' ");
            sb.Append("where idDepartamento = '" + id + "' ");
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

        public ListStore listarDepartamento() {
            ListStore datos = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string), typeof(string));


            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT id, nombre, email, ext, descripcion FROM BDSistemaEyS.Vw_Departamento where estado <> 3;");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read()) {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString(),
                        idr[2].ToString(), idr[3].ToString(), idr[4].ToString());
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


    }
}