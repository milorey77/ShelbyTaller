using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using Dominio;

namespace Presentacion.DAtaset
{
    public partial class frmreportellantas : Form
    {
        public frmreportellantas()
        {
            InitializeComponent();
        }

        private void frmreportellantas_Load(object sender, EventArgs e)
        {


            Dllantas llanta = new Dllantas();
            DataTable da = llanta.frmreportellantas();


            rptllantas.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("llantas", da);
            rptllantas.LocalReport.DataSources.Add(rds);
            rptllantas.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
