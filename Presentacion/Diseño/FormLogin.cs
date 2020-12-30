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
using Presentacion.Diseño;

namespace Presentacion
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_Enter(object sender, EventArgs e)
        {
            if (txtuser.Text == "USUARIO")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.Black;
            
        }
    }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            

            }
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "CONTRASEÑA")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;

            }
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;

            }
        }

        private void btncer_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnmin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void msgError(string msg)
        {
            labelrecupera.Text = "    ";
            labelrecupera.Visible = true;
        }
        private void lblErrorMessage_Click(object sender, EventArgs e)
        {
            Recupera llamar = new Recupera();
            llamar.Show();
            this.Hide();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
           

            Dlogin login = new Dlogin();
            var validLogin = login.loginpa(txtuser.Text, txtpass.Text);
            if (validLogin == true)
            {
                MessageBox.Show("Bienvenid@"+" "+ cacherol.nombre+" "+ cacherol.apellido);
                FormPrincipal llamar = new FormPrincipal();
                llamar.Show();
                llamar.FormClosed += Logout;
                this.Hide();
                
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrectos");
                txtpass.Text = "CONTRASEÑA";
                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = false;
                txtuser.Text = "USUARIO";
                txtuser.ForeColor = Color.Black;
            }








        }
        private void Logout(object sender, FormClosedEventArgs e)
        {
            txtpass.Text = "CONTRASEÑA";
            txtpass.ForeColor = Color.Black;
            txtpass.UseSystemPasswordChar = false;
            txtuser.Text = "USUARIO";
            txtuser.ForeColor = Color.Black;
            this.Show();
        }
    }
}


