namespace Parcial02
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.buttonIngresar = new System.Windows.Forms.Button();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.cmbUser = new System.Windows.Forms.ComboBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.buttonChangePass = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonIngresar
            // 
            this.buttonIngresar.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonIngresar.Location = new System.Drawing.Point(449, 372);
            this.buttonIngresar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonIngresar.Name = "buttonIngresar";
            this.buttonIngresar.Size = new System.Drawing.Size(221, 58);
            this.buttonIngresar.TabIndex = 10;
            this.buttonIngresar.Text = "Ingresar";
            this.buttonIngresar.UseVisualStyleBackColor = true;
            this.buttonIngresar.Click += new System.EventHandler(this.buttonIngresar_Click);
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.txtPass.Location = new System.Drawing.Point(396, 254);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(250, 39);
            this.txtPass.TabIndex = 9;
            // 
            // cmbUser
            // 
            this.cmbUser.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUser.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.cmbUser.FormattingEnabled = true;
            this.cmbUser.Location = new System.Drawing.Point(396, 162);
            this.cmbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbUser.Name = "cmbUser";
            this.cmbUser.Size = new System.Drawing.Size(250, 39);
            this.cmbUser.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.passwordLabel.Location = new System.Drawing.Point(144, 246);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(218, 71);
            this.passwordLabel.TabIndex = 7;
            this.passwordLabel.Text = "Contrasena";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.usuarioLabel.Location = new System.Drawing.Point(144, 138);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(218, 62);
            this.usuarioLabel.TabIndex = 6;
            this.usuarioLabel.Text = "Usuario";
            this.usuarioLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonChangePass
            // 
            this.buttonChangePass.Font = new System.Drawing.Font("Segoe UI Semibold", 14F,
                System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonChangePass.Location = new System.Drawing.Point(115, 372);
            this.buttonChangePass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonChangePass.Name = "buttonChangePass";
            this.buttonChangePass.Size = new System.Drawing.Size(294, 58);
            this.buttonChangePass.TabIndex = 11;
            this.buttonChangePass.Text = "Actualizar contrasena";
            this.buttonChangePass.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(800, 562);
            this.Controls.Add(this.buttonChangePass);
            this.Controls.Add(this.buttonIngresar);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.cmbUser);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.usuarioLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button buttonIngresar;
        private System.Windows.Forms.Button buttonChangePass;
        private System.Windows.Forms.ComboBox cmbUser;
        private System.Windows.Forms.TextBox txtPass;
    }
}