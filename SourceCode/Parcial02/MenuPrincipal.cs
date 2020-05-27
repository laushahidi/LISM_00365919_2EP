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
        
        
    }
}