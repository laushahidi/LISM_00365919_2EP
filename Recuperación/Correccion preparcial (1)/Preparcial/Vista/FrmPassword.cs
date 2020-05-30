﻿using Preparcial.Controlador;
using Preparcial.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Preparcial.Vista
{
    public partial class FrmPassword : Form
    {
        public FrmPassword()
        {
            InitializeComponent();
        }

        private void FrmPassword_Load(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = Image.FromFile("../../Recursos/UCA.png");
            // Correccion: alinear las lineas a la posicion correcta con tab
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            ActualizarControlers();
        }

        private void ActualizarControlers()
        {
        comboBox1.ValueMember = "Contrasena";
        comboBox1.DataSource = ControladorUsuario.GetUsuarios();
        comboBox1.DisplayMember = "NombreUsuario";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            // Correccion: la nueva contrasena no puede quedar vacia
            if (txtOldPassword.Text.Equals(comboBox1.SelectedValue.ToString()) && txtNewPassword.Text.Length > 0)
            {       
                var obtenerUsuario = (Usuario)comboBox1.SelectedItem;

                ActualizarControlers();
                                
                ControladorUsuario.ActualizarContrasena(obtenerUsuario.IdUsuario,
                txtNewPassword.Text);
            }
            else
            // Correccion: cambiar mensaje de error por si la old password esta bien pero el length no
                MessageBox.Show("Por favor verifique que los datos sean correctos");
        }
    } 
}
