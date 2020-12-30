using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Dllantas
    {
        private Llantas llantas = new Llantas();

        public DataSet mostrarllantas()
        {
            return llantas.mostrarllantas();
        }

        public void insertarllantas(string idll, string medi, string marc, string prec, string stoc)
        {
            llantas.insertarllantas(idll, medi, marc, prec, stoc);
        }

        public string[] buscarllantas(string idll)
        {
            return llantas.buscarllantas(idll);
        }

        public void actualizarllantas(string idll, string medi, string marc, string prec, string stoc)
        {
            llantas.actualizarllantas(idll, medi, marc, prec, stoc);
        }

        public void eliminarllantas(string idll)
        {
            llantas.eliminarllantas(idll);
        }

        public DataTable frmreportellantas()
        {
            return llantas.informe();
        }
    }
}
