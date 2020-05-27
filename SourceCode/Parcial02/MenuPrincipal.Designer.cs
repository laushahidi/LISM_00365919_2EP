using System.ComponentModel;

namespace Parcial02
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.txtNuevoUsername = new System.Windows.Forms.TextBox();
            this.AdminRad = new System.Windows.Forms.RadioButton();
            this.userrad = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNuevoFullname = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbUserDelete = new System.Windows.Forms.ComboBox();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.dataGridViewNegocios = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonNegocioDelete = new System.Windows.Forms.Button();
            this.cmbNegociosDelete = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNegocioName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAddNegocio = new System.Windows.Forms.Button();
            this.txtNegocioDesc = new System.Windows.Forms.TextBox();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteProd = new System.Windows.Forms.Button();
            this.cmbProdDelete = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonAgregarProd = new System.Windows.Forms.Button();
            this.txtProductoName = new System.Windows.Forms.TextBox();
            this.cmbNegAddProd = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewNegocios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(912, 594);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewUsers);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(904, 561);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Mantenimiento usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewNegocios);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(904, 561);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento negocios";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewProducts);
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(904, 561);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Mantenimiento productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(792, 529);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ver ordenes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(792, 529);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Grafica";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 29);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(792, 529);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Ordenes";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 29);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(904, 561);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Mis direcciones";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNuevoFullname);
            this.groupBox1.Controls.Add(this.AdminRad);
            this.groupBox1.Controls.Add(this.userrad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonCreateUser);
            this.groupBox1.Controls.Add(this.txtNuevoUsername);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox1.Location = new System.Drawing.Point(23, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(405, 251);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear usuarios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonEliminar);
            this.groupBox2.Controls.Add(this.cmbUserDelete);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox2.Location = new System.Drawing.Point(470, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 251);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eliminar usuarios";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(3, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 49);
            this.label1.TabIndex = 29;
            this.label1.Text = "Usuario:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonCreateUser.Location = new System.Drawing.Point(211, 171);
            this.buttonCreateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(167, 45);
            this.buttonCreateUser.TabIndex = 28;
            this.buttonCreateUser.Text = "Crear usuario";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.buttonCreateUser_Click);
            // 
            // txtNuevoUsername
            // 
            this.txtNuevoUsername.Location = new System.Drawing.Point(142, 83);
            this.txtNuevoUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuevoUsername.MaxLength = 25;
            this.txtNuevoUsername.Name = "txtNuevoUsername";
            this.txtNuevoUsername.Size = new System.Drawing.Size(236, 30);
            this.txtNuevoUsername.TabIndex = 27;
            // 
            // AdminRad
            // 
            this.AdminRad.Location = new System.Drawing.Point(17, 184);
            this.AdminRad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AdminRad.Name = "AdminRad";
            this.AdminRad.Size = new System.Drawing.Size(173, 42);
            this.AdminRad.TabIndex = 31;
            this.AdminRad.Text = "Administrador";
            this.AdminRad.UseVisualStyleBackColor = true;
            // 
            // userrad
            // 
            this.userrad.Checked = true;
            this.userrad.Location = new System.Drawing.Point(17, 131);
            this.userrad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userrad.Name = "userrad";
            this.userrad.Size = new System.Drawing.Size(117, 46);
            this.userrad.TabIndex = 30;
            this.userrad.TabStop = true;
            this.userrad.Text = "Usuario";
            this.userrad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 49);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nombre:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNuevoFullname
            // 
            this.txtNuevoFullname.Location = new System.Drawing.Point(142, 45);
            this.txtNuevoFullname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNuevoFullname.MaxLength = 25;
            this.txtNuevoFullname.Name = "txtNuevoFullname";
            this.txtNuevoFullname.Size = new System.Drawing.Size(236, 30);
            this.txtNuevoFullname.TabIndex = 32;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Location = new System.Drawing.Point(40, 300);
            this.dataGridViewUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowTemplate.Height = 24;
            this.dataGridViewUsers.Size = new System.Drawing.Size(820, 235);
            this.dataGridViewUsers.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(19, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 49);
            this.label3.TabIndex = 30;
            this.label3.Text = "Usuario:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbUserDelete
            // 
            this.cmbUserDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUserDelete.FormattingEnabled = true;
            this.cmbUserDelete.Location = new System.Drawing.Point(158, 43);
            this.cmbUserDelete.Name = "cmbUserDelete";
            this.cmbUserDelete.Size = new System.Drawing.Size(198, 31);
            this.cmbUserDelete.TabIndex = 31;
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.ForeColor = System.Drawing.Color.Red;
            this.buttonEliminar.Location = new System.Drawing.Point(193, 171);
            this.buttonEliminar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(163, 45);
            this.buttonEliminar.TabIndex = 32;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // dataGridViewNegocios
            // 
            this.dataGridViewNegocios.AllowUserToAddRows = false;
            this.dataGridViewNegocios.AllowUserToDeleteRows = false;
            this.dataGridViewNegocios.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNegocios.Location = new System.Drawing.Point(43, 301);
            this.dataGridViewNegocios.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewNegocios.Name = "dataGridViewNegocios";
            this.dataGridViewNegocios.ReadOnly = true;
            this.dataGridViewNegocios.RowTemplate.Height = 24;
            this.dataGridViewNegocios.Size = new System.Drawing.Size(820, 235);
            this.dataGridViewNegocios.TabIndex = 27;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonNegocioDelete);
            this.groupBox3.Controls.Add(this.cmbNegociosDelete);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox3.Location = new System.Drawing.Point(473, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 251);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Eliminar negocio";
            // 
            // buttonNegocioDelete
            // 
            this.buttonNegocioDelete.ForeColor = System.Drawing.Color.Red;
            this.buttonNegocioDelete.Location = new System.Drawing.Point(193, 171);
            this.buttonNegocioDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonNegocioDelete.Name = "buttonNegocioDelete";
            this.buttonNegocioDelete.Size = new System.Drawing.Size(163, 45);
            this.buttonNegocioDelete.TabIndex = 32;
            this.buttonNegocioDelete.Text = "Eliminar";
            this.buttonNegocioDelete.UseVisualStyleBackColor = true;
            this.buttonNegocioDelete.Click += new System.EventHandler(this.buttonNegocioDelete_Click);
            // 
            // cmbNegociosDelete
            // 
            this.cmbNegociosDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegociosDelete.FormattingEnabled = true;
            this.cmbNegociosDelete.Location = new System.Drawing.Point(158, 43);
            this.cmbNegociosDelete.Name = "cmbNegociosDelete";
            this.cmbNegociosDelete.Size = new System.Drawing.Size(198, 31);
            this.cmbNegociosDelete.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(19, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 49);
            this.label4.TabIndex = 30;
            this.label4.Text = "Negocio:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txtNegocioName);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.buttonAddNegocio);
            this.groupBox4.Controls.Add(this.txtNegocioDesc);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox4.Location = new System.Drawing.Point(26, 24);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(405, 251);
            this.groupBox4.TabIndex = 25;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Agregar negocio";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label5.Location = new System.Drawing.Point(3, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 49);
            this.label5.TabIndex = 33;
            this.label5.Text = "Nombre:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNegocioName
            // 
            this.txtNegocioName.Location = new System.Drawing.Point(142, 45);
            this.txtNegocioName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNegocioName.MaxLength = 25;
            this.txtNegocioName.Name = "txtNegocioName";
            this.txtNegocioName.Size = new System.Drawing.Size(236, 30);
            this.txtNegocioName.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 49);
            this.label6.TabIndex = 29;
            this.label6.Text = "Descripcion:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAddNegocio
            // 
            this.buttonAddNegocio.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAddNegocio.Location = new System.Drawing.Point(211, 171);
            this.buttonAddNegocio.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAddNegocio.Name = "buttonAddNegocio";
            this.buttonAddNegocio.Size = new System.Drawing.Size(167, 45);
            this.buttonAddNegocio.TabIndex = 28;
            this.buttonAddNegocio.Text = "Agregar negocio";
            this.buttonAddNegocio.UseVisualStyleBackColor = true;
            this.buttonAddNegocio.Click += new System.EventHandler(this.buttonAddNegocio_Click);
            // 
            // txtNegocioDesc
            // 
            this.txtNegocioDesc.Location = new System.Drawing.Point(142, 110);
            this.txtNegocioDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNegocioDesc.MaxLength = 25;
            this.txtNegocioDesc.Name = "txtNegocioDesc";
            this.txtNegocioDesc.Size = new System.Drawing.Size(236, 30);
            this.txtNegocioDesc.TabIndex = 27;
            this.txtNegocioDesc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNegocioDesc_KeyDown);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(43, 301);
            this.dataGridViewProducts.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowTemplate.Height = 24;
            this.dataGridViewProducts.Size = new System.Drawing.Size(820, 235);
            this.dataGridViewProducts.TabIndex = 30;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonDeleteProd);
            this.groupBox5.Controls.Add(this.cmbProdDelete);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox5.Location = new System.Drawing.Point(473, 24);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(406, 251);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Eliminar producto";
            // 
            // buttonDeleteProd
            // 
            this.buttonDeleteProd.ForeColor = System.Drawing.Color.Red;
            this.buttonDeleteProd.Location = new System.Drawing.Point(193, 171);
            this.buttonDeleteProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(163, 45);
            this.buttonDeleteProd.TabIndex = 32;
            this.buttonDeleteProd.Text = "Eliminar";
            this.buttonDeleteProd.UseVisualStyleBackColor = true;
            this.buttonDeleteProd.Click += new System.EventHandler(this.buttonDeleteProd_Click);
            // 
            // cmbProdDelete
            // 
            this.cmbProdDelete.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProdDelete.FormattingEnabled = true;
            this.cmbProdDelete.Location = new System.Drawing.Point(158, 43);
            this.cmbProdDelete.Name = "cmbProdDelete";
            this.cmbProdDelete.Size = new System.Drawing.Size(198, 31);
            this.cmbProdDelete.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label7.Location = new System.Drawing.Point(19, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 49);
            this.label7.TabIndex = 30;
            this.label7.Text = "Producto:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cmbNegAddProd);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.buttonAgregarProd);
            this.groupBox6.Controls.Add(this.txtProductoName);
            this.groupBox6.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.groupBox6.Location = new System.Drawing.Point(26, 24);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(405, 251);
            this.groupBox6.TabIndex = 28;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Agregar producto";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(6, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 49);
            this.label8.TabIndex = 33;
            this.label8.Text = "Nombre:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(6, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 49);
            this.label9.TabIndex = 29;
            this.label9.Text = "Negocio:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonAgregarProd
            // 
            this.buttonAgregarProd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonAgregarProd.Location = new System.Drawing.Point(183, 171);
            this.buttonAgregarProd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonAgregarProd.Name = "buttonAgregarProd";
            this.buttonAgregarProd.Size = new System.Drawing.Size(195, 45);
            this.buttonAgregarProd.TabIndex = 28;
            this.buttonAgregarProd.Text = "Agregar producto";
            this.buttonAgregarProd.UseVisualStyleBackColor = true;
            this.buttonAgregarProd.Click += new System.EventHandler(this.buttonAgregarProd_Click);
            // 
            // txtProductoName
            // 
            this.txtProductoName.Location = new System.Drawing.Point(142, 110);
            this.txtProductoName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductoName.MaxLength = 25;
            this.txtProductoName.Name = "txtProductoName";
            this.txtProductoName.Size = new System.Drawing.Size(236, 30);
            this.txtProductoName.TabIndex = 27;
            // 
            // cmbNegAddProd
            // 
            this.cmbNegAddProd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNegAddProd.FormattingEnabled = true;
            this.cmbNegAddProd.Location = new System.Drawing.Point(142, 45);
            this.cmbNegAddProd.Name = "cmbNegAddProd";
            this.cmbNegAddProd.Size = new System.Drawing.Size(236, 31);
            this.cmbNegAddProd.TabIndex = 34;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 594);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon) (resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewNegocios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewProducts)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonCreateUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton userrad;
        private System.Windows.Forms.RadioButton AdminRad;
        private System.Windows.Forms.TextBox txtNuevoFullname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNuevoUsername;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbUserDelete;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.TextBox txtNegocioDesc;
        private System.Windows.Forms.Button buttonAddNegocio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNegocioName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbNegociosDelete;
        private System.Windows.Forms.Button buttonNegocioDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridViewNegocios;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox cmbNegAddProd;
        private System.Windows.Forms.TextBox txtProductoName;
        private System.Windows.Forms.Button buttonAgregarProd;
        private System.Windows.Forms.ComboBox cmbProdDelete;
        private System.Windows.Forms.Button buttonDeleteProd;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
    }
}