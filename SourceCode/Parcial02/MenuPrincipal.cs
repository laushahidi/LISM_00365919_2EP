using System;
using System.Collections.Generic;
using System.Globalization;
using System.Timers;
using System.Windows.Forms;
using LiveCharts;
using LiveCharts.Definitions.Charts;
using LiveCharts.Wpf;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace Parcial02
{
    public partial class MenuPrincipal : Form
    {
        private Usuario usuario;
        private CartesianChart graficoFilas;

        public MenuPrincipal(Usuario pUsuario)
        {
            InitializeComponent();
            usuario = pUsuario;

        }

        private void actualizarControles()
        {

            List<Usuario> lista = UsuariosConsulta.getLista();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lista;
            
            cmbUserDelete.DataSource = null;
            cmbUserDelete.ValueMember = "password";
            cmbUserDelete.DisplayMember = "username";
            cmbUserDelete.DataSource = UsuariosConsulta.getLista();
        }
        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            //bienvenidoLabel.Text =
                            //"Bienvenido " + usuario.usuario + " [" + (usuario.admin ? "Administrador" : "Usuario") + "]";
            
            //labelClientePedido.Text = usuario.usuario;
            
            if (usuario.userType)
            {

                /*actualizarControles();
                actualizarControlesP();
                actualizarControlesNonAdminToo();
                configuarGrafico();*/
            }
            else
            {
                /*actualizarControlesNonAdminToo();
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages[1].Parent = null;
                tabControl1.TabPages.Remove(tabPage8);*/

            }
        }


        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea salir, " + usuario.username + "?",
                            "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        e.Cancel = true;
                    }
                    else
                    {
                        e.Cancel = false;
                    }
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNuevoUsername.Text.Length >= 4)
                {
                    UsuariosConsulta.crearNuevo(txtNuevoFullname.Text, txtNuevoUsername.Text, AdminRad.Checked);

                    MessageBox.Show("¡Usuario agregado exitosamente! Valores por defecto: " +
                                    "contrasena igual a usuario.",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNuevoUsername.Clear();
                    txtNuevoFullname.Clear();
                    actualizarControles();
                }
                else
                    MessageBox.Show("Por favor digite un usuario (longitud minima, 4 caracteres)",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El usuario que ha digitado, no se encuentra disponible.",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar al usuario " + cmbUserDelete.Text + "?",
                "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                UsuariosConsulta.eliminar(cmbUserDelete.Text);

                MessageBox.Show("¡Usuario eliminado exitosamente!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControles();
            }
        }
    }
}