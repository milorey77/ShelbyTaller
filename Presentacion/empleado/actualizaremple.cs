﻿using Dominio;
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
    public partial class actualizaremple : Form
    {
        public actualizaremple()
        {
            InitializeComponent();
            mostrar();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void actualizaremple_Load(object sender, EventArgs e)
        {

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

        private void button2_Click(object sender, EventArgs e)
        {
            Dempleado emple = new Dempleado();

            emple.actualizarempleado(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text);
            MessageBox.Show("Registro Actualizado Correctamente");
            mostrar();
        }

        private void btning_Click(object sender, EventArgs e)
        {
            Dempleado emple = new Dempleado();

            String[] datos = new String[6];

            datos = emple.buscarempleado(textBox1.Text);

            textBox1.Text = datos[0];
            textBox2.Text = datos[1];
            textBox3.Text = datos[2];
            textBox4.Text = datos[3];
            textBox5.Text = datos[4];
            textBox6.Text = datos[5];
           
        }
    }
}
