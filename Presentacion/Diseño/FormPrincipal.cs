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
using Presentacion.aros;
using comuun;
using Presentacion.empleado;
using Presentacion.Diseño;
using Presentacion.DAtaset;

namespace Presentacion
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
            AbrirFormEnPanel(new inicio());
            bienve();
        }
        private void hideSubMenu()
        {
            subllantas.Visible = false;
            submaros.Visible = false;
            submclientes.Visible = false;
            submempleados.Visible = false;
            submenvios.Visible = false;
            submfactura.Visible = false;
            submreportes.Visible = false;

        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        private void bienve()
        {
            label2.Text = cacherol.nombre + " " + cacherol.apellido;
            label3.Text = "Cargo: " + cacherol.cargo;

            if (cacherol.id_empleado == "aaa")
            {
                btaros.Visible = false;
                btllantas.Visible = false;
                btclientes.Visible = false;

            }
            else if (cacherol.id_empleado == "jvv")
            {
                btempleados.Visible = false;
            }
            else if (cacherol.id_empleado == "jbb")
            {
                btempleados.Visible = false;
                btclientes.Visible = false;
                btfactura.Visible = false;
                btenvios.Visible = false;
            }
            else if (cacherol.id_empleado == "ccc")
            {
                btempleados.Visible = false;
                btclientes.Visible = false;
            }
        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContene.Controls.Count > 0)
                this.panelContene.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContene.Controls.Add(fh);
            this.panelContene.Tag = fh;
            fh.Show();

        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btncer_Click(object sender, EventArgs e)
        {

        }

        private void btnmin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FormPrincipal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
           
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Ingresarllanta llamar = new Ingresarllanta();
            llamar.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Ingresarllanta llamar = new Ingresarllanta();
            llamar.Show();
            this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnllantas_Click(object sender, EventArgs e)
        {
            showSubMenu(submllantas);
        }

        private void btninglla_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new Ingresarllanta());
        }

        private void btnbuslla_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new buscarllanta());
        }

        private void btnactlla_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new actualizarllanta());
        }

        private void btnelilla_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            showSubMenu(submaros);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            showSubMenu(submclientes);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new ingresararo());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new buscararo());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new actualizararo());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void pictureBox3_Click_1(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new inicio());
        }

        private void button12_Click(object sender, EventArgs e)
        {
            showSubMenu(subllantas);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new Ingresarllanta());
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new buscarllanta());
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new actualizarllanta());
        }

        private void pictureBox3_Click_2(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new inicio());
        }

        private void button16_Click(object sender, EventArgs e)
        {
            showSubMenu(submclientes);
        }

        private void submclientes_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            showSubMenu(submempleados);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            showSubMenu(submenvios);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            showSubMenu(submfactura);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new ingresaremple());
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new eliminaremple());
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new actualizaremple());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new frmreportearos());
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesión?", "Warning",
  MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Estas seguro de cerrar sesión?", "Warning",
 MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }

        private void button24_Click_1(object sender, EventArgs e)
        {
            showSubMenu(submreportes);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new frmreportellantas());
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
            AbrirFormEnPanel(new frmreportearos());
        }
    }
}
