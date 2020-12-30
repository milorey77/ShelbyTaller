using Dominio;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion.aros
{
    public partial class buscararo : Form
    {
        public buscararo()
        {
            InitializeComponent();
            mostrar();
        }

        private void buscararo_Load(object sender, EventArgs e)
        {

        }

        private void btning_Click(object sender, EventArgs e)
        {
            Daros aros = new Daros();

            String[] datos = new String[7];

            datos = aros.buscararos(textBox1.Text);

            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];
            textBox4.Text = datos[3];
            textBox5.Text = datos[4];
            textBox6.Text = datos[5];
            textBox7.Text = datos[6];

        }
        void mostrar()
        {

            try
            {
                Daros aros = new Daros();
                dataGridView1.DataSource = aros.mostrararos().Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Daros aros = new Daros();
            aros.eliminararos(textBox1.Text);
            MessageBox.Show("Registro Eliminado Correctamente");
            mostrar();
        }
    }
}
