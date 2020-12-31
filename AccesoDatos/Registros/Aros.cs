using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccesoDatos
{
    public class Aros
    {
        MySqlConnection cn;


        public DataSet mostrararos()
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand("Select * from AROS ", cn);
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


        public void insertararos(string idar, string esta, string colo, string hoyo, string rina, string prec, string stoc)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"INSERT INTo AROS values('{idar}','{esta}','{colo}',{hoyo},{rina},{prec},{stoc})", cn);
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

        public string[] buscararos(string idar)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"select * from aros where codigo='{idar}'", cn);
                MySqlDataReader reader = comando.ExecuteReader();

                String[] datos = new String[7];

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
                        datos[6] = reader.GetString(6);


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


        public void actualizararos(string idar, string esta, string colo, string hoyo, string rina, string prec, string stoc)
        {

            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"Update AROS set estado='{esta}', color='{colo}', hoyos={hoyo}, rin={rina}, precio={prec}, disponibles={stoc}  where codigo='{idar}'", cn);
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

        public void eliminararos(string idar)
        {
            try
            {
                cn = new Conexion().IniciarConexion();

                MySqlCommand comando = new MySqlCommand($"delete from AROS where codigo='{idar}'", cn);
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
                    string consulta = "select * from aros";
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
