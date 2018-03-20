namespace Control_de_Gastos
{
    partial class Form5
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
            this.comboBIdioma = new System.Windows.Forms.ComboBox();
            this.lblIdioma = new System.Windows.Forms.Label();
            this.lblTitleProduct = new System.Windows.Forms.Label();
            this.lblRegistro = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblNombreAr = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCanti = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblArticle = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblQua = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.comboBIdioma.TabIndex = 31;
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
            this.lblIdioma.TabIndex = 30;
            this.lblIdioma.Text = "Idioma";
            this.lblIdioma.Click += new System.EventHandler(this.lblIdioma_Click);
            // 
            // lblTitleProduct
            // 
            this.lblTitleProduct.AutoSize = true;
            this.lblTitleProduct.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleProduct.Location = new System.Drawing.Point(380, 67);
            this.lblTitleProduct.Name = "lblTitleProduct";
            this.lblTitleProduct.Size = new System.Drawing.Size(354, 55);
            this.lblTitleProduct.TabIndex = 33;
            this.lblTitleProduct.Text = "List of Products\r\n";
            this.lblTitleProduct.Visible = false;
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.BackColor = System.Drawing.Color.Transparent;
            this.lblRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegistro.Location = new System.Drawing.Point(380, 45);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(422, 55);
            this.lblRegistro.TabIndex = 32;
            this.lblRegistro.Text = "Lista de Productos";
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(53, 641);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(207, 56);
            this.btnReturn.TabIndex = 36;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Visible = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.Location = new System.Drawing.Point(53, 603);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(207, 56);
            this.btnRegresar.TabIndex = 35;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Control_de_Gastos.Properties.Resources._4_11;
            this.pictureBox2.Location = new System.Drawing.Point(176, 162);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(929, 365);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 38;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lblNombreAr
            // 
            this.lblNombreAr.AutoSize = true;
            this.lblNombreAr.BackColor = System.Drawing.Color.White;
            this.lblNombreAr.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreAr.Location = new System.Drawing.Point(188, 193);
            this.lblNombreAr.Name = "lblNombreAr";
            this.lblNombreAr.Size = new System.Drawing.Size(225, 26);
            this.lblNombreAr.TabIndex = 39;
            this.lblNombreAr.Text = "Nombre de Articulo";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.Location = new System.Drawing.Point(494, 193);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 26);
            this.lblPrecio.TabIndex = 40;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCanti
            // 
            this.lblCanti.AutoSize = true;
            this.lblCanti.BackColor = System.Drawing.Color.White;
            this.lblCanti.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCanti.Location = new System.Drawing.Point(704, 193);
            this.lblCanti.Name = "lblCanti";
            this.lblCanti.Size = new System.Drawing.Size(109, 26);
            this.lblCanti.TabIndex = 41;
            this.lblCanti.Text = "Cantidad";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(952, 193);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(76, 26);
            this.lblFecha.TabIndex = 42;
            this.lblFecha.Text = "Fecha";
            // 
            // lblArticle
            // 
            this.lblArticle.AutoSize = true;
            this.lblArticle.BackColor = System.Drawing.Color.White;
            this.lblArticle.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArticle.Location = new System.Drawing.Point(221, 204);
            this.lblArticle.Name = "lblArticle";
            this.lblArticle.Size = new System.Drawing.Size(154, 26);
            this.lblArticle.TabIndex = 43;
            this.lblArticle.Text = "Article Name";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.BackColor = System.Drawing.Color.White;
            this.lblPrice.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(494, 204);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(66, 26);
            this.lblPrice.TabIndex = 44;
            this.lblPrice.Text = "Price";
            // 
            // lblQua
            // 
            this.lblQua.AutoSize = true;
            this.lblQua.BackColor = System.Drawing.Color.White;
            this.lblQua.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQua.Location = new System.Drawing.Point(704, 204);
            this.lblQua.Name = "lblQua";
            this.lblQua.Size = new System.Drawing.Size(97, 26);
            this.lblQua.TabIndex = 45;
            this.lblQua.Text = "Amount";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.White;
            this.lblDate.Font = new System.Drawing.Font("MS Reference Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(952, 204);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(63, 26);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "Date";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.Color.White;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(188, 284);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(68, 24);
            this.lbl1.TabIndex = 48;
            this.lbl1.Text = "Precio";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.White;
            this.lbl2.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(494, 284);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(68, 24);
            this.lbl2.TabIndex = 49;
            this.lbl2.Text = "Precio";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.White;
            this.lbl3.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(704, 284);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(68, 24);
            this.lbl3.TabIndex = 50;
            this.lbl3.Text = "Precio";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.BackColor = System.Drawing.Color.White;
            this.lbl4.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(952, 284);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(68, 24);
            this.lbl4.TabIndex = 51;
            this.lbl4.Text = "Precio";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Control_de_Gastos.Properties.Resources._51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1364, 749);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.lblQua);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblArticle);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblCanti);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreAr);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.lblTitleProduct);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.comboBIdioma);
            this.Controls.Add(this.lblIdioma);
            this.Name = "Form5";
            this.Text = "v";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBIdioma;
        private System.Windows.Forms.Label lblIdioma;
        private System.Windows.Forms.Label lblTitleProduct;
        private System.Windows.Forms.Label lblRegistro;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblNombreAr;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCanti;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblArticle;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblQua;
        private System.Windows.Forms.Label lblDate;
        public System.Windows.Forms.Label lbl1;
        public System.Windows.Forms.Label lbl2;
        public System.Windows.Forms.Label lbl3;
        public System.Windows.Forms.Label lbl4;
        public System.Windows.Forms.PictureBox pictureBox2;
    }
}