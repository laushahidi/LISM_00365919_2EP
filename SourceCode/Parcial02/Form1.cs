using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void poblarControles()
        {
            comboBox1.DataSource = null;
            comboBox1.ValueMember = "password";
            comboBox1.DisplayMember = "username";
            comboBox1.DataSource = UsuariosConsulta.getLista();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            poblarControles();
        }

        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.Equals(textBox1.Text))
            {
                Usuario u = (Usuario) comboBox1.SelectedItem;
                //Usuario u = new Usuario();
                //u.username = comboBox1.SelectedText;

                                 
                MessageBox.Show("¡Bienvenido!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                MenuPrincipal ventana = new MenuPrincipal(u);
                ventana.Show();
                this.Hide();
               
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }


        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonIngresar_Click(sender, e);
        }


        private void buttonChangePass_Click(object sender, EventArgs e)
        {
            CambiarContrasena unaVentana = new CambiarContrasena();
            unaVentana.ShowDialog();
            poblarControles();
        }
    }
}