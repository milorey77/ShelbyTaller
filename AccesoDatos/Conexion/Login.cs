using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using comuun;
using AccesoDatos.Correo;

namespace AccesoDatos
{
    public class Login
    {
        MySqlConnection cn;
        public bool loginpagina(string user, string pass)
        {
         

            using (cn = new Conexion().IniciarConexion())
            using (var command = new MySqlCommand()) { 
                command.Connection = cn;
            command.CommandText = "select *from USUARIO where usuario=@user and password=@pass";
            command.Parameters.AddWithValue("@user", user);
            command.Parameters.AddWithValue("@pass", pass);
            command.CommandType = CommandType.Text;
            MySqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cacherol.usuario = reader.GetString(0);
                        cacherol.password = reader.GetString(1);
                        cacherol.nombre = reader.GetString(2);
                        cacherol.apellido = reader.GetString(3);
                        cacherol.cargo = reader.GetString(4);
                        cacherol.id_empleado = reader.GetString(5);
                      
                    }
                    return true;
                }
                else
                    return false;
            }
        }
        public string recuperarcontra(string correo)
        {
            using (cn = new Conexion().IniciarConexion())
            
            {
                MySqlCommand comando = new MySqlCommand($"select * from USUARIO where correo ='{correo}'", cn);
                MySqlDataReader datos = comando.ExecuteReader();
           
                if (datos.HasRows)
                {
                    string correou = "";
                    string contrau = "";
                    string nombreu = "";


                    if (datos.Read())
                    {
                         correou = datos.GetString(6);
                         contrau = datos.GetString(1);
                         nombreu = datos.GetString(2);

                        var servicio = new SistemaCorreo();

                        servicio.EnvioCorreo("Recuperacion de Cuenta | Aros y Llantas Reynoso", $"Estimad@ {nombreu}, hemos procesado su solicitud.  Su contraseña es: {contrau}", correou);
                    }
                    return $"Hemos enviado un mensaje al correo: {correo}";
                }
                else
                {
                    return "NO SE PUDO REALIZAR DICHA SOLICITUD";
            }
            }
        }
    }
}
