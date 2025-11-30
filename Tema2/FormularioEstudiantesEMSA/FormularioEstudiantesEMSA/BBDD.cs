using FormularioEstudiantesEMSA.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//que aparezca un nuevo formulario modal con label de nombre, distrito y poblacion con unos textbox donde no se pueda escribir en el que aparazca esa información.
// se ssaca de la bbdd, A la consulta se ele pasa el nombre de la ciudad, esa bbdd nos devuelve un dataRow
namespace EjemploDataSet
{
    public class BBDD
    {
        /// Atributos para la conexión a la base de datos MySQL
        private MySqlConnection miConexion;
        private MySqlCommand miComando;
        private MySqlDataAdapter miAdaptador;
        private DataSet miDataset;


        public BBDD()
        {
            miDataset = new DataSet();    
        }
        public void AbrirConexion()
        {
            if (miConexion != null)
            {
                miConexion.Close();
            }
            else
            {
                miConexion.Open();
                miConexion.Close();
            }

        }
        public void CerrarConexion()
        {
            miConexion.Close();
        }
        public bool Conectar ( string servidor, string puerto, string usuario, string password)
        {
            try
            {
                string cadenaDeConexion = $"server={servidor};port={puerto};user id={usuario};password={password};database=test;Allow Zero Datetime = True;Charset=utf8;";
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
        /// <summary>
        /// Metodo sobrecargado(mas o menos) de Conectar, los datos de conexión están dentro del metodo
        /// OJO: NO ES LO MÁS VIABLE!!!!! PUEDEN HABER ROTURAS DE SEGURIDAD DENTRO DE LA BASE DE DATOS!!!!
        /// </summary>
        /// <returns></returns>
        public bool Conectar()
        {
            try
            {
                string cadenaDeConexion = "server=127.0.0.1;port=3306;user id=root;password=root;database=test;Allow Zero Datetime = True;Charset=utf8;";
                miConexion = new MySqlConnection(cadenaDeConexion);
                AbrirConexion();
                CerrarConexion();
                return true;
            }
            catch (MySqlException e)
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

                miComando = new MySqlCommand("SELECT * FROM ESTUDIANTES", miConexion);
                miAdaptador = new MySqlDataAdapter(miComando);
                miAdaptador.Fill(miDataset,"estudiantes");
                DataTable tabla= miDataset.Tables["ESTUDIANTES"];
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
                miComando = new MySqlCommand($"Select * FROM CITY WHERE CountryCode='{codigo}'", miConexion);
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
        public List<ModelPersona> leerBBDD()
        {
            List<ModelPersona> listaPersona = new List<ModelPersona>();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM estudiantes", miConexion);
            MySqlDataReader lector;
            AbrirConexion();
            miConexion.Open();
            lector = comando.ExecuteReader();
            //CerrarConexion();

            while (lector.Read())
            {
                ModelPersona nuevaPersona = new ModelPersona(lector[0].ToString(), lector[1].ToString(), lector[2].ToString());
                listaPersona.Add(nuevaPersona);
            }
            CerrarConexion();
            return listaPersona;
        }

        public void Agregar(string nombre, string apellidos)
        {
            AbrirConexion();
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand($"INSERT INTO ESTUDIANTES (NOMBRE, APELLIDO) VALUES ('{nombre}', '{apellidos}')",miConexion);
            comando.ExecuteNonQuery();
            CerrarConexion();
        }
    }
}//
