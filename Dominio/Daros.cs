using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Daros
    {
        private Aros aros = new Aros();

        public DataSet mostrararos()
        {
            return aros.mostrararos();
        }

        public void insertararos(string idar, string esta, string colo, string hoyo, string rina, string prec, string stoc)
        {
            aros.insertararos(idar, esta, colo, hoyo, rina, prec,stoc);
        }

        public string[] buscararos(string idar)
        {
            return aros.buscararos(idar);
        }

        public void actualizararos(string idar, string esta, string colo, string hoyo, string rina, string prec, string stoc)
        {
            aros.actualizararos(idar, esta, colo, hoyo, rina, prec, stoc);
        }

        public void eliminararos(string idar)
        {
            aros.eliminararos(idar);
        }
    
        public DataTable frmreportearos()
        {
            return aros.informe();
        }
    }
}
