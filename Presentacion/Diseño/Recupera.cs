using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Dominio;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using Dominio;
using comuun;

namespace Presentacion.Diseño
{
    public partial class Recupera : Form
    {
        public Recupera()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btncer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Recupera_Load(object sender, EventArgs e)
        {

        }

        private void Recupera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

                Dlogin login = new Dlogin();
                string mesa = login.recuperarcontra(txtuser.Text);
                System.Windows.Forms.MessageBox.Show(mesa);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
                
                
            }
            
        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "CORREO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;

            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if (txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormLogin llamar = new FormLogin();
            llamar.Show();
            this.Hide();
        }
    }
}
