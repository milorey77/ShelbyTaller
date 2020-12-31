using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Llantas
    {
        MySqlConnection cn;

        public DataSet mostrarllantas()
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand("Select * from LLANTAS ", cn);
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


        public void insertarllantas(string idll, string medi, string marc, string prec, string stoc)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"INSERT INTo LLANTAS values('{idll}','{medi}','{marc}',{prec},{stoc})", cn);
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


        public string[] buscarllantas(string idll)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"select * from LLANTAS where codigo='{idll}'", cn);
                MySqlDataReader reader = comando.ExecuteReader();

                String[] datos = new String[5];

                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        datos[0] = reader.GetString(0);
                        datos[1] = reader.GetString(1);
                        datos[2] = reader.GetString(2);
                        datos[3] = reader.GetString(3);
                        datos[4] = reader.GetString(4);


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

        public void actualizarllantas(string idll, string medi, string marc, string prec, string stoc)
        {

            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"Update LLANTAS set medida='{medi}', marca='{marc}', precio={prec}, disponibles={stoc}  where codigo='{idll}'", cn);
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

        public void eliminarllantas(string idll)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"delete from LLANTAS where codigo='{idll}'", cn);
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

        public DataTable informe()
        {
            try
            {
                using (cn = new Conexion().IniciarConexion())
                {
                    string consulta = "select * from llantas";
                    MySqlCommand comando = new MySqlCommand(consulta, cn);
                    MySqlDataAdapter datos = new MySqlDataAdapter(comando);
                    DataTable ds = new DataTable();
                    datos.Fill(ds);
                    return ds;
                }
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

    }
}
