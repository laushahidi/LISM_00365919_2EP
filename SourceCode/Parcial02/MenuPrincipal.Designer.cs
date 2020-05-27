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
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewNegocios)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
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
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(792, 529);
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
            this.label6.Size = new System.Drawing.Size(119, 49);
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
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 594);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MenuPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridViewNegocios)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
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
    }
}