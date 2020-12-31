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
    public partial class actualizarllanta : Form
    {

        public actualizarllanta()
        {
            InitializeComponent();
            mostrar();
        }



        private void btning_Click(object sender, EventArgs e)
        {


            try
            {
                Dllantas usuario = new Dllantas();

                usuario.actualizarllantas(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);
                MessageBox.Show("Registro Actualizado Correctamente");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                mostrar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al actualizar");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
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


        private void actualizarllanta_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Dllantas usuario = new Dllantas();

            String[] datos = new String[5];

            datos = usuario.buscarllantas(textBox1.Text);

            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];
            textBox4.Text = datos[3];
            textBox5.Text = datos[4];

        }
    }
}
