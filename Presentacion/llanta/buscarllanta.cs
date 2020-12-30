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

namespace Presentacion
{
    public partial class buscarllanta : Form
    {
        public buscarllanta()
        {
            InitializeComponent();
            mostrar();
        }
       
      

        private void btning_Click(object sender, EventArgs e)
        {
            Dllantas llantas = new Dllantas();

            String[] datos = new String[5];

            datos = llantas.buscarllantas(textBox1.Text);

            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];
            textBox4.Text = datos[3];
            textBox5.Text = datos[4];
           

        }

        private void buscarllanta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dllantas usuario = new Dllantas();
            usuario.eliminarllantas(textBox1.Text);
            MessageBox.Show("Registro Eliminado Correctamente");
            mostrar();

        }
        private void mostrar()
        {
            try
            {
                Dllantas llantas = new Dllantas();
                dataGridView1.DataSource = llantas.mostrarllantas().Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);

            }
        }
    }
}
