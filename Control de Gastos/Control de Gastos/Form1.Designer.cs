namespace Control_de_Gastos
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnComenzar = new System.Windows.Forms.Button();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.comboBIdioma = new System.Windows.Forms.ComboBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.Transparent;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitulo.Location = new System.Drawing.Point(323, 440);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(790, 73);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "CONTROL DEL GASTOS";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // btnComenzar
            // 
            this.btnComenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComenzar.Location = new System.Drawing.Point(547, 552);
            this.btnComenzar.Name = "btnComenzar";
            this.btnComenzar.Size = new System.Drawing.Size(356, 93);
            this.btnComenzar.TabIndex = 1;
            this.btnComenzar.Text = "Empezar";
            this.btnComenzar.UseVisualStyleBackColor = true;
            this.btnComenzar.Click += new System.EventHandler(this.btnComenzar_Click);
            // 
            // lblIdioma
            // 
            this.lblIdioma.AutoSize = true;
            this.lblIdioma.BackColor = System.Drawing.Color.Transparent;
            this.lblIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdioma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblIdioma.Location = new System.Drawing.Point(12, 18);
            this.lblIdioma.Name = "lblIdioma";
            this.lblIdioma.Size = new System.Drawing.Size(109, 33);
            this.lblIdioma.TabIndex = 2;
            this.lblIdioma.Text = "Idioma";
            // 
            // comboBIdioma
            // 
            this.comboBIdioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBIdioma.FormattingEnabled = true;
            this.comboBIdioma.Items.AddRange(new object[] {
            "Español",
            "Ingles"});
            this.comboBIdioma.Location = new System.Drawing.Point(12, 54);
            this.comboBIdioma.Name = "comboBIdioma";
            this.comboBIdioma.Size = new System.Drawing.Size(186, 28);
            this.comboBIdioma.TabIndex = 3;
            this.comboBIdioma.Text = "Seleccione una opcion";
            this.comboBIdioma.SelectedIndexChanged += new System.EventHandler(this.comboBIdioma_SelectedIndexChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTitle.Location = new System.Drawing.Point(357, 466);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(681, 73);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "EXPENSE CONTROL";
            this.lblTitle.Visible = false;
            this.lblTitle.Click += new System.EventHandler(this.lblTitle_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(547, 587);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(356, 93);
            this.btnStart.TabIndex = 5;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Visible = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::Control_de_Gastos.Properties.Resources._38726276_sales_wallpapers;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1302, 749);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.comboBIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Controls.Add(this.btnComenzar);
            this.Controls.Add(this.lblTitulo);
            this.Name = "Form1";
            this.Text = "c ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnComenzar;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.ComboBox comboBIdioma;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnStart;
    }
}

