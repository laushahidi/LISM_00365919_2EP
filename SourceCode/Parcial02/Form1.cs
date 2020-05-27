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
            cmbUser.DataSource = null;
            cmbUser.ValueMember = "contrasena";
            cmbUser.DisplayMember = "usuario";
            cmbUser.DataSource = UsuariosConsulta.getLista();
        }


        private void buttonIngresar_Click(object sender, EventArgs e)
        {
            if (cmbUser.SelectedValue.Equals(txtPass.Text))
            {
                Usuario u = (Usuario) cmbUser.SelectedItem;
                                 
                MessageBox.Show("¡Bienvenido!", 
                    "Fruteria frescura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                MenuPrincipal ventana = new MenuPrincipal(u);
                ventana.Show();
                this.Hide();
               
            }
            else
                MessageBox.Show("¡Contraseña incorrecta!", "Fruteria Frescura",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonIngresar_Click(sender, e);
        }
        }
    }
}