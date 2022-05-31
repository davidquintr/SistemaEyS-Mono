using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;
using Vistas;

namespace Datos {
    public class Dt_tbl_cargo {
        //Atrbituos 
        Conexion con = new Conexion();
        //MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();
        MessageDialog ms = null;

        #region metodos
        public List<Tbl_Cargo> CbxCargo() {

            List<Tbl_Cargo> listaRol = new List<Tbl_Cargo>();
            IDataReader idr = null;
            sb.Clear();
            /*sb.Append("USE Seguridad");
            sb.Clear();*/
            sb.Append("SELECT idCargo, nombre, idDepartamento FROM BDSistemaEyS.tbl_Cargo WHERE estado<>3");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());

                while (idr.Read()) {
                    Tbl_Cargo tCar = new Tbl_Cargo() {
                        Nombre = idr["nombre"].ToString(),
                        IdDept = int.Parse(idr["idDepartamento"].ToString())
                    };
                    listaRol.Add(tCar);
                }
                idr.Close();
                return listaRol;
            } catch (Exception e) {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
                throw;
            } finally {
                con.CerrarConexion();
            }
        }

        public List<Tbl_Cargo> ColocarCargos() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Cargo> listaCargo = new List<Tbl_Cargo>();
            Tbl_Cargo cargo;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Cargo;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    cargo = creacionDatos.CargarCargo(datos);
                    listaCargo.Add(cargo);
                }//fin de while
                return listaCargo;
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


        public List<Tbl_Vw_Cargo> ColocarVwCargos() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Cargo> listaCargo = new List<Tbl_Vw_Cargo>();
            Tbl_Vw_Cargo cargo;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Cargo ");
            sb.Append("WHERE estado != 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    cargo = creacionDatos.CargarVwCargo(datos);
                    listaCargo.Add(cargo);
                }//fin de while
                return listaCargo;
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

        public List<Tbl_Vw_Cargo> ColocarVwCargosElim() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Cargo> listaCargo = new List<Tbl_Vw_Cargo>();
            Tbl_Vw_Cargo cargo;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Cargo ");
            sb.Append("WHERE estado = 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    cargo = creacionDatos.CargarVwCargo(datos);
                    listaCargo.Add(cargo);
                }//fin de while
                return listaCargo;
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


        public bool GuardarCargo(Tbl_Cargo crg) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("INSERT INTO BDSistemaEyS.tbl_Cargo");
            sb.Append("(nombre, descripcion, estado, idDepartamento)");
            sb.Append("VALUES ('" + crg.Nombre + "','" + crg.Descripcion + "','" + 1 + "','" + crg.IdDept + "')");

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

        public List<Tbl_Vw_Departamento> ColocarVwDepart() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Departamento> listaDepart = new List<Tbl_Vw_Departamento>();
            Tbl_Vw_Departamento departamento;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Departamento ");
            sb.Append("WHERE estado !=3;");

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



        public bool EditarCargo(Tbl_Cargo crg, int id) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Cargo ");
            sb.Append("SET nombre = '" + crg.Nombre + "', descripcion = '" + crg.Descripcion + "', estado = '" + crg.Estado + "', idDepartamento = '" + crg.IdDept + "' ");
            sb.Append("WHERE (idCargo = '" + id + "');");

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

        public bool RestaurarCargo(int id) {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("update BDSistemaEyS.tbl_Cargo ");
            sb.Append("SET estado = '2' ");
            sb.Append("where idCargo = '" + id + "' ");
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


        public ListStore listarCargos() {
            ListStore datos = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string));


            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT id,nombre,departamento,descripcion FROM BDSistemaEyS.Vw_Cargo where estado <> 3;");
            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read()) {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString(),
                        idr[2].ToString(), idr[3].ToString());
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

        public ListStore buscarCargo(String cadena) {
            ListStore datos = new ListStore(typeof(string),
                typeof(string), typeof(string), typeof(string));

            IDataReader idr = null;
            sb.Clear();
            sb.Append("USE BDSistemaEyS;");
            sb.Append("SELECT id,nombre,departamento,descripcion FROM BDSistemaEyS.Vw_Cargo ");
            sb.Append("WHERE nombre like '%" + cadena + "%' ");
            sb.Append("OR departamento like '%" + cadena + "%' and estado <> 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                while (idr.Read()) {
                    datos.AppendValues(idr[0].ToString(), idr[1].ToString(),
                        idr[2].ToString(), idr[3].ToString());
                    //dr.Close();
                }//fin de while
                return datos;
            } catch (Exception e) {
                ms = new MessageDialog(null, DialogFlags.Modal, MessageType.Error,
                    ButtonsType.Ok, e.Message);
                ms.Run();
                ms.Destroy();
                Console.WriteLine("Error: " + e.Message);
                Console.WriteLine("Error: " + e.StackTrace);
                throw;
            } finally {
                idr.Close();
                con.CerrarConexion();
            }
        }//fin del metodo

    }
}