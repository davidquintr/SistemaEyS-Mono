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
    public class Dt_tbl_emp {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Empleado> ColocarEmpleados() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Empleado> listaEmpleado = new List<Tbl_Empleado>();
            Tbl_Empleado empleado = new Tbl_Empleado();
            IDataReader idr = null;
            sb.Clear();
            string[] datos;
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Empleado;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for(int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    empleado = creacionDatos.CargarEmpleado(datos);
                    listaEmpleado.Add(empleado);
                }//fin de while

                return listaEmpleado;
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
        }//fin del metodo 


        public List<Tbl_Vw_Empleado> ColocarVwEmpleado() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Empleado> listaEmpleado = new List<Tbl_Vw_Empleado>();
            Tbl_Vw_Empleado empleado = new Tbl_Vw_Empleado();
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Empleado ");
            sb.Append("WHERE estado !=3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    empleado = creacionDatos.CargarVwEmpleado(datos);
                    listaEmpleado.Add(empleado);
                }//fin de while

                return listaEmpleado;
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
        public List<Tbl_Vw_Empleado> ColocarVwEmpleadoElim() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Empleado> listaEmpleado = new List<Tbl_Vw_Empleado>();
            Tbl_Vw_Empleado empleado = new Tbl_Vw_Empleado();
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Empleado ");
            sb.Append("WHERE estado = 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    empleado = creacionDatos.CargarVwEmpleado(datos);
                    listaEmpleado.Add(empleado);
                }//fin de while

                return listaEmpleado;
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

        public List<Tbl_Empleado> ColocarCboxVwEmp() {
            List<Tbl_Empleado> listaEmpleado = new List<Tbl_Empleado>();
            IDataReader idr = null;
            sb.Clear();
            string[] datos = new string[17];
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Empleado ");
            sb.Append("where idUsuario = 0 and estado <> 3 ;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    Tbl_Empleado empleado = new Tbl_Empleado() {
                        PrimerNombre = idr["primerNombre"].ToString(),
                        PrimerApellido = idr["primerApellido"].ToString(),
                        Cedula = idr["cedula"].ToString(),
                    };
                    listaEmpleado.Add(empleado);
                }//fin de while

                return listaEmpleado;
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


        public bool GuardarEmpleado(Tbl_Empleado emp) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("INSERT INTO BDSistemaEyS.tbl_Empleado");
            sb.Append("(cedula, primerNombre, segundoNombre, primerApellido, segundoApellido, direccion, observacion, telefono, emailPersonal, emailCorporativo, sexo, estadoActividad, estado, fechaNac, fechaIngreso, fechaAgregado, idCargo,idUsuario)");
            sb.Append("VALUES ('" + emp.Cedula + "','" + emp.PrimerNombre + "','" + emp.SegundoNombre + "','" + emp.PrimerApellido + "','" + emp.SegundoApellido + "','" + emp.Direccion + "','" + emp.Observacion + "','" + emp.Telefono + "','" + emp.EmailPersonal + "','" + emp.EmailCorporativo + "', b'" + Convert.ToInt16(emp.Sexo) + "', b'" + Convert.ToInt16(emp.Actividad)  + "','" + 1 + "','" + emp.FechaNac.ToString("yy-MM-dd") + "','" + emp.FechaIngr.ToString("yy-MM-dd") + "','" + emp.FechaAgr.ToString("yy-MM-dd") + "','" + emp.IdCargo + "','" + 0 +"')");

            try {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if(x > 0) {
                    guardado = true;
                }
                return guardado;
            } 
            catch(Exception e) {
                Console.WriteLine("Error jiji " + e.ToString());
            } 
            finally {
                con.CerrarConexion();
            }
            return guardado;
        }

        public bool AsignarUsuario(int idUsr, int idEmp) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("UPDATE BDSistemaEyS.tbl_Empleado ");
            sb.Append("Set idUsuario = '0' ");
            sb.Append("where (idUsuario = '" + idUsr + "'); ");

            sb.Append("UPDATE BDSistemaEyS.tbl_Empleado ");
            sb.Append("SET idUsuario = '" + idUsr + "' ");
            sb.Append("WHERE (idEmpleado = '" + idEmp + "'); ");

            try {
                con.AbrirConexion();
                x = con.Ejecutar(CommandType.Text, sb.ToString());

                if (x > 0) {
                    guardado = true;
                }

                return guardado;
            } catch (Exception e) {
                Console.WriteLine("Error: " + e.ToString());
            } finally {
                con.CerrarConexion();
            }
            return guardado;
        }

        public bool RestaurarEmp(int id) {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Empleado ");
            sb.Append("SET estado = '2' "); 
            sb.Append("WHERE idEmpleado = '" + id + "' ");
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

        public bool EliminarEmp(int id) {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Empleado ");
            sb.Append("SET estado = '3' ");
            sb.Append("WHERE idEmpleado = '" + id + "' ");
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
