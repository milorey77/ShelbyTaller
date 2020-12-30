using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dempleado
    {
        private empleado emple = new empleado();

        public DataSet mostrarempleado()
        {
            return emple.mostrarempleado();
        }

        public void insertarempleado(string usua, string pass, string nomb, string apel, string carg, string idem)
        {
            emple.insertarempleado(usua, pass, nomb, apel, carg, idem);
        }

        public string[] buscarempleado(string usua)
        {
            return emple.buscarempleado(usua);
        }

        public void actualizarempleado(string usua, string pass, string nomb, string apel, string carg, string idem)
        {
            emple.actualizarempleado(usua, pass, nomb, apel, carg, idem);
        }

        public void eliminarempleado(string usua)
        {
            emple.eliminarempleado(usua);
        }
    }
}
