using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace AccesoDatos
{
    public  class Conexion
    {
       private MySqlConnection conexion = new MySqlConnection();

        public MySqlConnection IniciarConexion()
        {
            try
            {
                String con = "Server=127.0.0.1; Database=taller; Uid=root; Pwd=";
                conexion.ConnectionString = con;
                conexion.Open();

                return conexion;
            }
            catch (MySqlException ex)
            {
                return null;
                Console.WriteLine("" + ex);
            }
        }
    }
}