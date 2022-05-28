using System;
using System.Data;
using Gtk;
using System.Text;
using System.Collections.Generic;
using Entidades;
using Negocio;

namespace Datos {
    public class Dt_tbl_horario {

        //Atributos
        Conexion con = new Conexion();
        MessageDialog ms = null;
        StringBuilder sb = new StringBuilder();

        #region metodos

        public List<Tbl_Horario> colocarHorarios(int idCargo) {

            Ng_creacionDatos creacionDatos = new Ng_creacionDatos();
            List<Tbl_Horario> listarHorarios = new List<Tbl_Horario>();
            Tbl_Horario horario;
            IDataReader idr = null;
            sb.Clear();
            sb.Append("SELECT * FROM BDSistemaEyS.tbl_Horario where idCargo = '" + idCargo + "';");

            try {
                con.AbrirConexion();
                idr = con.Leer(CommandType.Text, sb.ToString());
                string[] datos = new string[idr.FieldCount];

                while (idr.Read()) {
                    for (int i = 0; i < idr.FieldCount; i++) {
                        datos[i] = idr[i].ToString();
                    }
                    horario = creacionDatos.CargarHorario(datos);
                    listarHorarios.Add(horario);
                }//fin de while
                return listarHorarios;
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

        public bool GuardarHorario(Tbl_Horario horario) {
            bool guardado = false;
            int x = 0;

            sb.Clear();
            sb.Append("INSERT INTO BDSistemaEyS.tbl_Horario");
            sb.Append("(horarioIn,horarioOut,tipoHorario,activo,idCargo)");
            sb.Append("VALUES ('" + horario.HorarioIn.ToString("yyyy-MM-dd H:mm:ss") + "','" + horario.HorarioOut.ToString("yyyy-MM-dd H:mm:ss") + "','" + horario.TipoHor + "', b'" + Convert.ToInt16(horario.Activo) + "','" + horario.IdCargo + "')");

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

        public bool EditarHorario(Tbl_Horario horario) {
            bool guardado = false;
            int x = 0;

            sb.Clear();

            sb.Append("UPDATE BDSistemaEyS.tbl_Horario ");
            sb.Append("SET horarioIn = '" + horario.HorarioIn.ToString("yyyy-MM-dd H:mm:ss") + "', ");
            sb.Append("horarioOut = '" + horario.HorarioOut.ToString("yyyy-MM-dd H:mm:ss") + "', ");
            sb.Append("activo = b'" + Convert.ToInt16(horario.Activo) + "'\t ");
            sb.Append("WHERE (idCargo = '" + horario.IdCargo + "' and tipoHorario = '" + horario.TipoHor + "');");

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
    }
}