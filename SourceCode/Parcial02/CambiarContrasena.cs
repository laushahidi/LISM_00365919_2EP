using System;
using System.Windows.Forms;

namespace Parcial02
{
    public partial class CambiarContrasena : Form
    {
        public CambiarContrasena()
        {
            InitializeComponent();
        }

        private void CambiarContrasena_Load(object sender, EventArgs e)
        {
            cmbUsuario1.DataSource = null;
            cmbUsuario1.ValueMember = "password";
            cmbUsuario1.DisplayMember = "username";
            cmbUsuario1.DataSource = UsuariosConsulta.getLista();
        }

        private void buttonCambiarContra_Click(object sender, EventArgs e)
        {
            bool actualIgual = cmbUsuario1.SelectedValue.Equals(txtActual.Text);
            bool nuevaIgual = txtNueva.Text.Equals(txtRepetir.Text);
            bool nuevaValida = txtNueva.Text.Length > 0;

            if (actualIgual && nuevaIgual && nuevaValida)
            {
                try
                {
                    UsuariosConsulta.actualizarContra(cmbUsuario1.Text, txtNueva.Text);
                    
                    MessageBox.Show("¡Contraseña actualizada exitosamente!", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    this.Close();
                }
                catch (Exception)
                {
                    MessageBox.Show("¡La contraseña no se actualizo! Por favor intente mas tarde.", 
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("¡Por favor verifique que los datos sean correctos!", 
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}