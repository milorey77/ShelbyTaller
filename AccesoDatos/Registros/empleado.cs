using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AccesoDatos
{
    public class empleado
    {

        MySqlConnection cn;

        public DataSet mostrarempleado()
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand("Select * from USUARIO ", cn);
                MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                DataSet ds = new DataSet();

                datos.Fill(ds);

                return ds;


            }
            catch (MySqlException ex)
            {
                Console.WriteLine("" + ex);
                return null;
            }
            finally
            {
                cn.Close();
            }
        }


        public void insertarempleado(string usua, string pass, string nomb, string apel, string carg, string idem)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"INSERT INTo USUARIO values('{usua}','{pass}','{nomb}','{apel}','{carg}','{idem}')", cn);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }


        public string[] buscarempleado(string usua)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"select * from USUARIO where usuario='{usua}'", cn);
                MySqlDataReader reader = comando.ExecuteReader();

                String[] datos = new String[6];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetString(1);
                        datos[2] = reader.GetString(2);
                        datos[3] = reader.GetString(3);
                        datos[4] = reader.GetString(4);
                        datos[5] = reader.GetString(5);


                    }

                    reader.Close();
                }

                return datos;

            }
            catch (MySqlException ex)
            {
                return null;
                throw;
            }
        }

        public void actualizarempleado(string usua, string pass, string nomb, string apel, string carg, string idem)
        {

            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"Update USUARIO set password='{pass}', nombre='{nomb}', apellido='{apel}', cargo='{carg}', id_empleado='{idem}'  where usuario='{usua}'", cn);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }

        }

        public void eliminarempleado(string usua)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"delete from USUARIO where usuario='{usua}'", cn);
                comando.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {

                throw;
            }
            finally
            {
                cn.Close();
            }
        }
    }
}
