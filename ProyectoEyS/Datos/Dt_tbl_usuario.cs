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
    public class Dt_tbl_usuario {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Usuario> ColocarUsuarios() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Usuario> listaUsuarios = new List<Tbl_Usuario>();
            Tbl_Usuario usuario;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Usuario;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    usuario = creacionDatos.CargarUsuario(datos);
                    listaUsuarios.Add(usuario);
                }//fin de while

                return listaUsuarios;
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


        public bool GuardarUsuario(Tbl_Usuario usuario) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("INSERT INTO BDSistemaEyS.tbl_Usuario");
            sb.Append("(username,password,estado,idRol)");
            sb.Append("VALUES ('" + usuario.Username + "','" + usuario.Password + "','" + usuario.Estado + "','" + usuario.IdRol + "')");

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

        public List<Tbl_Vw_Usuario> ColocarVwUsuarios() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Usuario> listaUsuarios = new List<Tbl_Vw_Usuario>();
            Tbl_Vw_Usuario usuario;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Usuario ");
            sb.Append("WHERE estado !=3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    usuario = creacionDatos.CargarVwUsuario(datos);
                    listaUsuarios.Add(usuario);
                }//fin de while

                return listaUsuarios;
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

        public List<Tbl_Vw_Usuario> ColocarVwUsuariosElim() {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Vw_Usuario> listaUsuarios = new List<Tbl_Vw_Usuario>();
            Tbl_Vw_Usuario usuario;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.Vw_Usuario ");
            sb.Append("WHERE estado = 3;");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    usuario = creacionDatos.CargarVwUsuario(datos);
                    listaUsuarios.Add(usuario);
                }//fin de while

                return listaUsuarios;
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

        public bool EditarUsuario(Tbl_Usuario user, int id) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Usuario ");
            sb.Append("SET username = '" + user.Username + "', password = '" + user.Password + "', estado = '" + user.Estado + "', idRol = '" + user.IdRol + "' ");
            sb.Append("WHERE (idUsuario = '" + id + "');");

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

        public bool RestaurarUsuario(int id) {
            bool guardado = false;
            int x = 0;
            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Usuario ");
            sb.Append("SET estado = '2' ");
            sb.Append("WHERE (idUsuario = '" + id + "');");
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
