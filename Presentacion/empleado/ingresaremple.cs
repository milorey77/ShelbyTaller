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

namespace Presentacion.empleado
{
    public partial class ingresaremple : Form
    {
        public ingresaremple()
        {
            InitializeComponent();
            mostrar();
        }

        private void btning_Click(object sender, EventArgs e)
        {
            Dempleado emple = new Dempleado();
            emple.insertarempleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);

            MessageBox.Show("Registro Insertado Correctamente");
            mostrar();
        }
        void mostrar()
        {

            try
            {
                Dempleado emple = new Dempleado();
                dataGridView1.DataSource = emple.mostrarempleado().Tables[0];
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("" + ex);

            }

        }

        private void ingresaremple_Load(object sender, EventArgs e)
        {

        }
    }
}
