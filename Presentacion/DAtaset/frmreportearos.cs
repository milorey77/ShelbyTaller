using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;
using Dominio;
namespace Presentacion.DAtaset
{
    public partial class frmreportearos : Form
    {
        
        public frmreportearos()
        {
            InitializeComponent();
            rptaros.LocalReport.DataSources.Clear();

        }

        private void frmreportearos_Load(object sender, EventArgs e)
        {


            Daros aro = new Daros();
            DataTable da = aro.frmreportearos();


            rptaros.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("aros", da);
            rptaros.LocalReport.DataSources.Add(rds);
            rptaros.RefreshReport();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Daros aro = new Daros();
            DataTable da = aro.frmreportearos();
           

            rptaros.LocalReport.DataSources.Clear();
            ReportDataSource rds = new ReportDataSource("aros", da);
            rptaros.LocalReport.DataSources.Add(rds);
            rptaros.RefreshReport();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
