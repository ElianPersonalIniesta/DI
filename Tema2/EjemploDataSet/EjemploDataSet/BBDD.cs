using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace EjemploDataSet
{
    public class BBDD
    {
        /// Atributos para la conexión a la base de datos MySQL
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet miDataset = new DataSet();

        public void AbrirConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            miConexion.Open();
            miConexion.Close();
        }
        public void CerrarConexion()
        {
            miConexion.Close();
        }
        public bool Conectar ( string servidor, string puerto, string usuario, string password)
        {
            try
            {
                string cadenaDeConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database=world;Allow Zero Datetime = True;Charset=utf8;";
                miConexion = new MySqlConnection(cadenaDeConexion);
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch(MySqlException e)
            {
                return false;
            }
        }

        public DataTable obtenerGrid()
        {
            try
            {
                AbrirConexion();
                /*miComando = new MySqlCommand("SELECT * FROM COUNTRY");
                miComando.Connection = miConexion;
                
                Esta era la forma antigua saes
                 */

                miComando = new MySqlCommand("SELECT * FROM country", miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                miAdaptador.Fill(miDataset,"country");
                DataTable tabla= miDataset.Tables["country"];
                CerrarConexion();

                return tabla;

            }
            catch(MySqlException e)
            {
                return null;
            }
        }
        public DataTable obtenerDatos(String codigo)
        {
            try
            {
                miDataset = new DataSet();
                AbrirConexion();
                miComando = new MySqlCommand($"Select * FROM COUNTRY WHERE Code='{codigo}'", miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                miAdaptador.Fill(miDataset, "country");
                DataTable tabla = miDataset.Tables["country"];
                CerrarConexion();

                return tabla;
            }
            catch(MySqlException e)
            {
                return null;
            }
        }
    }
}
