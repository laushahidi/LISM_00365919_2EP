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
            
            //label17.Text = "Bienvenido " + usuario.username + " [" + (usuario.userType ? "Administrador" : "Usuario") + "]";
            
            if (usuario.userType)
            {

                actualizarControles();
                actualizarControlesB();
                actualizarControlesP();
                tabControl1.TabPages.Remove(tabPage6);
                tabControl1.TabPages.Remove(tabPage7);
                configuarGrafico();
            }
            else
            {
                actualizarControlesA();
                ActualizarControlesUserO();
                tabControl1.TabPages.Remove(tabPage1);
                tabControl1.TabPages.Remove(tabPage2);
                tabControl1.TabPages.Remove(tabPage3);
                tabControl1.TabPages.Remove(tabPage4);
                tabControl1.TabPages.Remove(tabPage5);

            }
        }
        private void actualizarControles()
        {

            List<Usuario> lista = UsuariosConsulta.getLista();

            dataGridViewUsers.DataSource = null;
            dataGridViewUsers.DataSource = lista;
            
            cmbUserDelete.DataSource = null;
            cmbUserDelete.ValueMember = "password";
            cmbUserDelete.DisplayMember = "username";
            cmbUserDelete.DataSource = lista;
        }
        private void actualizarControlesB()
        {

            List<Negocio> lista = NegociosConsulta.getLista();

            dataGridViewNegocios.DataSource = null;
            dataGridViewNegocios.DataSource = lista;
            
            cmbNegociosDelete.DataSource = null;
            cmbNegociosDelete.ValueMember = "idbusiness";
            cmbNegociosDelete.DisplayMember = "name";
            cmbNegociosDelete.DataSource = lista;
            
            cmbProdDelete.DataSource = null;
            cmbProdDelete.ValueMember = "idproduct";
            cmbProdDelete.DisplayMember = "name";
            cmbProdDelete.DataSource = ProductosConsulta.getLista();
            
            cmbNegAddProd.DataSource = null;
            cmbNegAddProd.ValueMember = "idbusiness";
            cmbNegAddProd.DisplayMember = "name";
            cmbNegAddProd.DataSource = NegociosConsulta.getLista(); 
        }
        
        private void actualizarControlesP()
        {
            List<Producto> lista = ProductosConsulta.getLista();
            
            cmbProdDelete.DataSource = null;
            cmbProdDelete.ValueMember = "idproduct";
            cmbProdDelete.DisplayMember = "name";
            cmbProdDelete.DataSource = lista;
            
            dataGridViewProducts.DataSource = null;
            dataGridViewProducts.DataSource = lista;
            
            cmbNegAddProd.DataSource = null;
            cmbNegAddProd.ValueMember = "idbusiness";
            cmbNegAddProd.DisplayMember = "name";
            cmbNegAddProd.DataSource = NegociosConsulta.getLista(); 
            
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = OrdenesConsulta.adminVerPedidos();
        }

        
        private void actualizarControlesA()
        {
            dataGridViewMyAddresses.DataSource = null;
            dataGridViewMyAddresses.DataSource = DireccionesConsulta.userVerDirecciones(usuario);
            
            cmbDeleteAddress.DataSource = null;
            cmbDeleteAddress.ValueMember = "idaddress";
            cmbDeleteAddress.DisplayMember = "address";
            cmbDeleteAddress.DataSource = DireccionesConsulta.userVerDirecciones(usuario);
            
            cmbAddressMod.DataSource = null;
            cmbAddressMod.ValueMember = "idaddress";
            cmbAddressMod.DisplayMember = "address";
            cmbAddressMod.DataSource = DireccionesConsulta.userVerDirecciones(usuario);
        }

        private void ActualizarControlesUserO()
        {
            cmbProdOrden.DataSource = null;
            cmbProdOrden.ValueMember = "idproducto";
            cmbProdOrden.DisplayMember = "name";
            cmbProdOrden.DataSource = ProductosConsulta.getLista(); 
            
            cmbAddressOrder.DataSource = null;
            cmbAddressOrder.ValueMember = "idaddress";
            cmbAddressOrder.DisplayMember = "address";
            cmbAddressOrder.DataSource = DireccionesConsulta.userVerDirecciones(usuario);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = OrdenesConsulta.verMisOrdenes(usuario);
            
            cmbNumOrder.DataSource = null;
            cmbNumOrder.DataSource = OrdenesConsulta.verMisOrdenes(usuario);
            cmbNumOrder.DisplayMember = "idorder";


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
                if (txtNuevoUsername.Text.Length >= 4 && txtNuevoFullname.Text.Length >= 5)
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
                    MessageBox.Show("Por favor digite el nombre completo y el usuario (longitud minima, nombre 5 y usuario 4 caracteres)",
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

        private void buttonAddNegocio_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNegocioName.Text.Length >= 3)
                {
                    NegociosConsulta.agregarNegocio(txtNegocioName.Text, txtNegocioDesc.Text);

                    MessageBox.Show("¡Negocio agregado exitosamente!",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtNegocioName.Clear();
                    txtNegocioDesc.Clear();
                    actualizarControlesB();
                }
                else
                    MessageBox.Show("Por favor digite un negocio valido (longitud minima, 3 caracteres)",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("El negocio que ha digitado, no se encuentra disponible.",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonNegocioDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el negocio " + cmbNegociosDelete.Text + "?",
                "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                NegociosConsulta.eliminarNegocio(cmbNegociosDelete.Text);

                MessageBox.Show("¡Negocio eliminado exitosamente!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControlesB();
            }
        }

        private void txtNegocioDesc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonAddNegocio_Click(sender, e);
        }

        private void buttonAgregarProd_Click(object sender, EventArgs e)
        {
            try
            {
                Negocio b = new Negocio();
                b.name = cmbNegAddProd.Text;

                
                Producto p = new Producto();
                p.name = txtProductoName.Text;

                ProductosConsulta.AgregarProducto(p, b);

                MessageBox.Show("Producto agregado exitosamente", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtProductoName.Clear();
                actualizarControlesP();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDeleteProd_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar el producto " + cmbProdDelete.Text + "?",
                "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ProductosConsulta.eliminarProducto(cmbProdDelete.Text);

                MessageBox.Show("¡Negocio eliminado exitosamente!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControlesP();
            }
        }

        private void buttonAddAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAddAddress.Text.Length >= 6)
                {
                    DireccionesConsulta.agregarDireccion(txtAddAddress.Text, usuario.username);

                    MessageBox.Show("¡Direccion agregada exitosamente!",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtAddAddress.Clear();
                    actualizarControlesA();
                }
                else
                    MessageBox.Show("Por favor digite una direccion valida (longitud minima, 6 caracteres)",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error.",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonDeleteAddress_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la direccion " + cmbDeleteAddress.Text + "?",
                "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DireccionesConsulta.eliminarDireccion(cmbDeleteAddress.Text);

                MessageBox.Show("¡Direccion eliminada exitosamente!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                actualizarControlesA();
            }
        }

        private void buttonModAddress_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtModAddress.Text.Length >= 6)
                {
                    DireccionesConsulta.ActualizarDireccion(cmbAddressMod.Text, txtModAddress.Text);

                    MessageBox.Show("La direccion se ha actualizado de manera exitosa",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtModAddress.Clear();

                    actualizarControlesA();
                }
                else
                    MessageBox.Show("Por favor digite una direccion valida (longitud minima, 6 caracteres)",
                        "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message, "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = DateTime.Now;
                string fecha2 = Convert.ToString(fecha);

                Producto pro = (Producto) cmbProdOrden.SelectedItem;
                Direccion ad  = (Direccion) cmbAddressOrder.SelectedItem;
                
                OrdenesConsulta.CrearOrden(fecha2, pro, ad);

                MessageBox.Show("La orden ha sido creada exitosamente", "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarControlesUserO();

            }
            catch (Exception exception)
            {
                MessageBox.Show("Error: " + exception.Message, "Hugo",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDelOrder_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Seguro que desea eliminar la orden # " + cmbDeleteAddress.Text + "?",
                "Hugo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                OrdenesConsulta.eliminarOrden(Convert.ToInt32(cmbNumOrder.SelectedValue));

                MessageBox.Show("¡La orden ha sido eliminada exitosamente!",
                    "Hugo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                ActualizarControlesUserO();
            }
        }
        
        private void configuarGrafico()
        {
            graficoFilas = new CartesianChart();
            graficoFilas.Parent = tabControl1.TabPages[4];
            
            graficoFilas.Top = 10;
            graficoFilas.Left = 10;
            graficoFilas.Width = graficoFilas.Parent.Width - 10;
            graficoFilas.Height = graficoFilas.Parent.Height - 10;
            
            graficoFilas.Series = new SeriesCollection
            {
                new RowSeries{Title = "Cantidad de veces que se le ha pedido a un negocio", Values = new ChartValues<int>(), DataLabels = true}
            };
            graficoFilas.AxisY.Add(new Axis{Labels = new List<string>()});
            graficoFilas.AxisX.Add(new Axis{MaxValue = 100});
            graficoFilas.LegendLocation = LegendLocation.Bottom;

            
            foreach (Negocio negocio in NegociosConsulta.getLista())
            {
                graficoFilas.Series[0].Values.Add(negocio.idBusiness);
                graficoFilas.AxisY[0].Labels.Add(negocio.name);
            }
        }
    }
}