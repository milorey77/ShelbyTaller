using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace AccesoDatos.Correo
{
    public abstract class Correo
    {
        private SmtpClient empleado;
        public static string password { get; set; }
        public static string correo { get; set; }
        public static string host { get; set; }
        public static int puerto { get; set; }
        public static bool ssl { get; set; }

        protected void inicioSmtp()
        {
            try
            {
                empleado = new SmtpClient();
            empleado.Credentials = new NetworkCredential(correo, password);
            empleado.Host = host;
            empleado.Port = puerto;
            empleado.EnableSsl = ssl;
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex);
            }
        }

        public void EnvioCorreo(string asunto, string cuerpo, string correos)
        {
            var mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(correo);
                mensaje.To.Add(new MailAddress(correos));
                
                
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.Priority = MailPriority.Normal;
                empleado.Send(mensaje);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                mensaje.Dispose();
                empleado.Dispose();
            }     
        }
    }
}
