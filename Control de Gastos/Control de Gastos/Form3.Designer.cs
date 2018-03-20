namespace Control_de_Gastos
{
    partial class Form3
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
            this.lblNuevaCuenta = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblConfirmarContraseña = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.comboBSexo = new System.Windows.Forms.ComboBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtConfirmacionContra = new System.Windows.Forms.TextBox();
            this.lblTitleCount = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.comboBSex = new System.Windows.Forms.ComboBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.comboBIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNuevaCuenta
            // 
            this.lblNuevaCuenta.AutoSize = true;
            this.lblNuevaCuenta.BackColor = System.Drawing.Color.Transparent;
            this.lblNuevaCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNuevaCuenta.Location = new System.Drawing.Point(444, 34);
            this.lblNuevaCuenta.Name = "lblNuevaCuenta";
            this.lblNuevaCuenta.Size = new System.Drawing.Size(443, 73);
            this.lblNuevaCuenta.TabIndex = 3;
            this.lblNuevaCuenta.Text = "Nueva Cuenta";
            this.lblNuevaCuenta.Click += new System.EventHandler(this.lblNuevaCuenta_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(227, 169);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(341, 42);
            this.lblNombreUsuario.TabIndex = 4;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            this.lblNombreUsuario.Click += new System.EventHandler(this.lblNombreUsuario_Click);
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(227, 251);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(327, 42);
            this.lblCorreo.TabIndex = 5;
            this.lblCorreo.Text = "Correo Electronico";
            this.lblCorreo.Click += new System.EventHandler(this.lblCorreo_Click);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(227, 338);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(212, 42);
            this.lblContraseña.TabIndex = 7;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblConfirmarContraseña
            // 
            this.lblConfirmarContraseña.AutoSize = true;
            this.lblConfirmarContraseña.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmarContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmarContraseña.Location = new System.Drawing.Point(227, 418);
            this.lblConfirmarContraseña.Name = "lblConfirmarContraseña";
            this.lblConfirmarContraseña.Size = new System.Drawing.Size(384, 42);
            this.lblConfirmarContraseña.TabIndex = 8;
            this.lblConfirmarContraseña.Text = "Confirmar Contraseña";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.BackColor = System.Drawing.Color.Transparent;
            this.lblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexo.Location = new System.Drawing.Point(227, 505);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(104, 42);
            this.lblSexo.TabIndex = 9;
            this.lblSexo.Text = "Sexo";
            // 
            // comboBSexo
            // 
            this.comboBSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBSexo.FormattingEnabled = true;
            this.comboBSexo.Items.AddRange(new object[] {
            "Masculino",
            "Femenino",
            "Sin especificar"});
            this.comboBSexo.Location = new System.Drawing.Point(616, 502);
            this.comboBSexo.Name = "comboBSexo";
            this.comboBSexo.Size = new System.Drawing.Size(344, 45);
            this.comboBSexo.TabIndex = 10;
            this.comboBSexo.Text = "Seleccione una opcion";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(473, 631);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(207, 56);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1056, 631);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(207, 56);
            this.btnSalir.TabIndex = 13;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(616, 166);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(344, 49);
            this.txtNombreUsuario.TabIndex = 14;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(616, 251);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(344, 49);
            this.txtCorreo.TabIndex = 15;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(616, 331);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(344, 49);
            this.txtContraseña.TabIndex = 16;
            // 
            // txtConfirmacionContra
            // 
            this.txtConfirmacionContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmacionContra.Location = new System.Drawing.Point(617, 411);
            this.txtConfirmacionContra.Name = "txtConfirmacionContra";
            this.txtConfirmacionContra.Size = new System.Drawing.Size(343, 49);
            this.txtConfirmacionContra.TabIndex = 17;
            // 
            // lblTitleCount
            // 
            this.lblTitleCount.AutoSize = true;
            this.lblTitleCount.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCount.Location = new System.Drawing.Point(471, 59);
            this.lblTitleCount.Name = "lblTitleCount";
            this.lblTitleCount.Size = new System.Drawing.Size(378, 73);
            this.lblTitleCount.TabIndex = 18;
            this.lblTitleCount.Text = "New Acount";
            this.lblTitleCount.Visible = false;
            this.lblTitleCount.Click += new System.EventHandler(this.lblTitleCount_Click);
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.BackColor = System.Drawing.Color.Transparent;
            this.lblNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(227, 194);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(341, 42);
            this.lblNameUser.TabIndex = 19;
            this.lblNameUser.Text = "Nombre de Usuario";
            this.lblNameUser.Visible = false;
            this.lblNameUser.Click += new System.EventHandler(this.lblNameUser_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(241, 269);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(110, 42);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "Email";
            this.lblEmail.Visible = false;
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(227, 354);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(183, 42);
            this.lblPass.TabIndex = 21;
            this.lblPass.Text = "Password";
            this.lblPass.Visible = false;
            this.lblPass.Click += new System.EventHandler(this.lblPass_Click);
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.Location = new System.Drawing.Point(227, 433);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(322, 42);
            this.lblConfirmPass.TabIndex = 22;
            this.lblConfirmPass.Text = "Confirm Password";
            this.lblConfirmPass.Visible = false;
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSex.Location = new System.Drawing.Point(247, 505);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(83, 42);
            this.lblSex.TabIndex = 23;
            this.lblSex.Text = "Sex";
            this.lblSex.Visible = false;
            // 
            // comboBSex
            // 
            this.comboBSex.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBSex.FormattingEnabled = true;
            this.comboBSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Unspecified"});
            this.comboBSex.Location = new System.Drawing.Point(616, 488);
            this.comboBSex.Name = "comboBSex";
            this.comboBSex.Size = new System.Drawing.Size(344, 45);
            this.comboBSex.TabIndex = 24;
            this.comboBSex.Text = "Select an Option";
            this.comboBSex.Visible = false;
            // 
            // btnLogIn
            // 
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.Location = new System.Drawing.Point(459, 669);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(207, 56);
            this.btnLogIn.TabIndex = 26;
            this.btnLogIn.Text = "Acept";
            this.btnLogIn.UseVisualStyleBackColor = true;
            this.btnLogIn.Visible = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(43, 669);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(207, 56);
            this.btnReturn.TabIndex = 25;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1056, 669);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(207, 56);
            this.btnExit.TabIndex = 27;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Visible = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // comboBIdioma
            // 
            this.comboBIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBIdioma.FormattingEnabled = true;
            this.comboBIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.comboBIdioma.Location = new System.Drawing.Point(12, 45);
            this.comboBIdioma.Name = "comboBIdioma";
            this.comboBIdioma.Size = new System.Drawing.Size(186, 28);
            this.comboBIdioma.TabIndex = 29;
            this.comboBIdioma.Text = "Seleccione una opcion";
            this.comboBIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBIdioma_SelectedIndexChanged);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.Location = new System.Drawing.Point(12, 9);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(109, 33);
            this.lblIdioma.TabIndex = 28;
            this.lblIdioma.Text = "Idioma";
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(43, 631);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(207, 56);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_de_Gastos.Properties.Resources._9;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.comboBIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.comboBSex);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblNameUser);
            this.Controls.Add(this.lblTitleCount);
            this.Controls.Add(this.txtConfirmacionContra);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.comboBSexo);
            this.Controls.Add(this.lblSexo);
            this.Controls.Add(this.lblConfirmarContraseña);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblCorreo);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.lblNuevaCuenta);
            this.Name = "Form3";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNuevaCuenta;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblConfirmarContraseña;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.ComboBox comboBSexo;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtConfirmacionContra;
        private System.Windows.Forms.Label lblTitleCount;
        private System.Windows.Forms.Label lblNameUser;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox comboBSex;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ComboBox comboBIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Button btnRegresar;
    }
}