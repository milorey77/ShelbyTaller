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

namespace Presentacion.aros
{
    public partial class ingresararo : Form
    {

        public ingresararo()
        {
            InitializeComponent();
            mostrar();
        }

        private void ingresararo_Load(object sender, EventArgs e)
        {

        }

        private void btning_Click(object sender, EventArgs e)
        {

            try
            {
                Daros aros = new Daros();
                aros.insertararos(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

                MessageBox.Show("Registro Insertado Correctamente");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                mostrar();
            }
            catch (Exception)
            {

                MessageBox.Show("Error al insertar");
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";

            }

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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
