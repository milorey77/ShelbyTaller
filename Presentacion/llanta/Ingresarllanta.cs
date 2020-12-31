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
    public partial class Ingresarllanta : Form
    {
        public class Conexion
        {
            private MySqlConnection conexion = new MySqlConnection();

            public MySqlConnection IniciarConexion()
            {
                try
                {
                    String con = "Server=127.0.0.1; Database=taller; Uid=root; Pwd=";
                    conexion.ConnectionString = con;
                    conexion.Open();

                    return conexion;
                }
                catch (MySqlException ex)
                {
                    return null;
                    Console.WriteLine("" + ex);
                }
            }
        }

        public Ingresarllanta()
        {
            InitializeComponent();
            mostrar();
        }


        private void btning_Click(object sender, EventArgs e)
        {

            try
            {
                Dllantas llantas = new Dllantas();
                llantas.insertarllantas(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text);

                MessageBox.Show("Registro Insertado Correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
                mostrar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al insertar");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox5.Text = "";
                textBox4.Text = "";
            }

        }
        void mostrar()
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

        private void l1_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Ingresarllanta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {




        }


        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
