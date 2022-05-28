using System;
using System.Data;
using MySql.Data.MySqlClient;
using Gtk;

namespace Datos
{
    public class Conexion {

        //atributos 
        private String cadena = String.Empty;
        private MySqlConnection con { get; set; }
        private MySqlCommand sqlcomand { get; set;}
        private IDataReader idr { get; set; }
        MessageDialog ms = null;

        #region metodos
        public String CadenaConexion() {

            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.Database = "BDSistemaEyS";
            sb.UserID = "root";
            sb.Password = "Usuario123.";
            return sb.ConnectionString;
        }//fin del metodo


        public void AbrirConexion() {

            if (con.State == ConnectionState.Open) {
                return;
            } 
            else {
                con.ConnectionString = cadena;
                try {
                    con.Open();                  
                }
                catch (Exception e) {
                    ms = new MessageDialog(null, DialogFlags.Modal,
                        MessageType.Error, ButtonsType.Ok, e.Message);
                    ms.Run();
                    ms.Destroy();
                    Console.WriteLine("ERROR: " + e);
                }//fin try-catch
            }//fin if-else
        }//fin del metodo


        public void CerrarConexion(){

            if (con.State == ConnectionState.Closed) {
                return;
            } 
            else {
                con.Close();
            }
        }//fin del metodo


        public IDataReader Leer(CommandType ct, string consulta) {

            idr = null;
            sqlcomand.Connection = con;
            sqlcomand.CommandType = ct;
            sqlcomand.CommandText = consulta;

            try {
                idr = sqlcomand.ExecuteReader();
            } 
            catch {
                throw;
            }
            return idr;
        }//fin del metodo


        public Int32 Ejecutar(CommandType ct, string consulta) {

            int retorno = 0;
            sqlcomand.Connection = con;
            sqlcomand.CommandType = ct;
            sqlcomand.CommandText = consulta;

            try {
                retorno = sqlcomand.ExecuteNonQuery();
            }
            catch {
                throw;
            }//fin try-catch
            return retorno;
        }//fin del metodo
        #endregion

        #region constructor 
        public Conexion() {

            cadena = CadenaConexion();
            con = new MySqlConnection();
            sqlcomand = new MySqlCommand();
        }
        #endregion
    }
}
