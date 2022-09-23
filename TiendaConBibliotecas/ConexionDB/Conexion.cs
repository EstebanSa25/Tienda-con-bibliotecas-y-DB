using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConexionDB
{
    public class Conexion
    {
        SqlConnection cnn = null;
        public bool AbrirConexion()
        {
            try
            {
                string connetionString = "Data Source=DESKTOP-4BRCSFK\\SQLEXPRESS;Initial Catalog=Prueba;Integrated Security=SSPI;";
                cnn = new SqlConnection(connetionString);
                cnn.Open();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool CerrarConexion()
        {
            try
            {
                cnn.Close();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public DataTable Obtener(string select)
        {
            try
            {
                AbrirConexion();
                SqlCommand command = new SqlCommand(select, cnn);
                SqlDataReader dataReader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(dataReader);
                dataReader.Close();
                command.Dispose();
                CerrarConexion();
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }

        }
        public bool EjecutarComando(string comando)
        {
            try
            {
                AbrirConexion();
                SqlCommand command = new SqlCommand(comando, cnn);
                bool inserto = command.ExecuteNonQuery() == 1 ? true : false; //Esto es un if              
                command.Dispose();
                CerrarConexion();
                return inserto;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
