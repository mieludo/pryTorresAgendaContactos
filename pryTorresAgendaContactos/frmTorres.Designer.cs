namespace pryTorresAgendaContactos
{
    partial class frmAgendaContactos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgendaContactos));
            this.dgvColumna = new System.Windows.Forms.DataGridView();
            this.dgvNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTelefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoría = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbDatos = new System.Windows.Forms.GroupBox();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.tboNombre = new System.Windows.Forms.TextBox();
            this.tboApellido = new System.Windows.Forms.TextBox();
            this.tboCorreo = new System.Windows.Forms.TextBox();
            this.mtbTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.gbBotones = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumna)).BeginInit();
            this.gbDatos.SuspendLayout();
            this.gbBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvColumna
            // 
            this.dgvColumna.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvColumna.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColumna.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvNombre,
            this.dgvApellido,
            this.dgvTelefono,
            this.dgvCorreo,
            this.dgvCategoría});
            this.dgvColumna.Location = new System.Drawing.Point(294, 12);
            this.dgvColumna.Name = "dgvColumna";
            this.dgvColumna.Size = new System.Drawing.Size(517, 396);
            this.dgvColumna.TabIndex = 0;
            // 
            // dgvNombre
            // 
            this.dgvNombre.HeaderText = "Nombre";
            this.dgvNombre.Name = "dgvNombre";
            // 
            // dgvApellido
            // 
            this.dgvApellido.HeaderText = "Apellido";
            this.dgvApellido.Name = "dgvApellido";
            // 
            // dgvTelefono
            // 
            this.dgvTelefono.HeaderText = "Nº de Teléfono";
            this.dgvTelefono.Name = "dgvTelefono";
            // 
            // dgvCorreo
            // 
            this.dgvCorreo.HeaderText = "Correo Electrónico";
            this.dgvCorreo.Name = "dgvCorreo";
            // 
            // dgvCategoría
            // 
            this.dgvCategoría.HeaderText = "Categoría";
            this.dgvCategoría.Name = "dgvCategoría";
            // 
            // gbDatos
            // 
            this.gbDatos.Controls.Add(this.cboCategoria);
            this.gbDatos.Controls.Add(this.tboNombre);
            this.gbDatos.Controls.Add(this.tboApellido);
            this.gbDatos.Controls.Add(this.tboCorreo);
            this.gbDatos.Controls.Add(this.mtbTelefono);
            this.gbDatos.Controls.Add(this.lblCategoria);
            this.gbDatos.Controls.Add(this.lblCorreo);
            this.gbDatos.Controls.Add(this.lblTelefono);
            this.gbDatos.Controls.Add(this.lblApellido);
            this.gbDatos.Controls.Add(this.lblNombre);
            this.gbDatos.Location = new System.Drawing.Point(13, 12);
            this.gbDatos.Name = "gbDatos";
            this.gbDatos.Size = new System.Drawing.Size(275, 257);
            this.gbDatos.TabIndex = 1;
            this.gbDatos.TabStop = false;
            this.gbDatos.Enter += new System.EventHandler(this.gbDatos_Enter);
            // 
            // cboCategoria
            // 
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "Familia",
            "Trabajo",
            "Amigos"});
            this.cboCategoria.Location = new System.Drawing.Point(136, 219);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(109, 21);
            this.cboCategoria.TabIndex = 4;
            // 
            // tboNombre
            // 
            this.tboNombre.Location = new System.Drawing.Point(137, 19);
            this.tboNombre.Name = "tboNombre";
            this.tboNombre.Size = new System.Drawing.Size(108, 20);
            this.tboNombre.TabIndex = 0;
            // 
            // tboApellido
            // 
            this.tboApellido.Location = new System.Drawing.Point(137, 67);
            this.tboApellido.Name = "tboApellido";
            this.tboApellido.Size = new System.Drawing.Size(108, 20);
            this.tboApellido.TabIndex = 1;
            // 
            // tboCorreo
            // 
            this.tboCorreo.Location = new System.Drawing.Point(137, 166);
            this.tboCorreo.Name = "tboCorreo";
            this.tboCorreo.Size = new System.Drawing.Size(108, 20);
            this.tboCorreo.TabIndex = 3;
            // 
            // mtbTelefono
            // 
            this.mtbTelefono.Location = new System.Drawing.Point(137, 118);
            this.mtbTelefono.Mask = "(999)999-9999";
            this.mtbTelefono.Name = "mtbTelefono";
            this.mtbTelefono.Size = new System.Drawing.Size(108, 20);
            this.mtbTelefono.TabIndex = 2;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(7, 219);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(65, 17);
            this.lblCategoria.TabIndex = 4;
            this.lblCategoria.Text = "Categoría:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.Location = new System.Drawing.Point(7, 166);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(112, 17);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo electrónico:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(7, 118);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(92, 17);
            this.lblTelefono.TabIndex = 2;
            this.lblTelefono.Text = "Nº de Teléfono:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.Location = new System.Drawing.Point(7, 67);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(56, 17);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(7, 20);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(55, 17);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(20, 28);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(99, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(158, 28);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(99, 23);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(89, 77);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(99, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // gbBotones
            // 
            this.gbBotones.Controls.Add(this.btnAgregar);
            this.gbBotones.Controls.Add(this.btnEditar);
            this.gbBotones.Controls.Add(this.btnEliminar);
            this.gbBotones.Location = new System.Drawing.Point(13, 276);
            this.gbBotones.Name = "gbBotones";
            this.gbBotones.Size = new System.Drawing.Size(275, 132);
            this.gbBotones.TabIndex = 5;
            this.gbBotones.TabStop = false;
            // 
            // frmAgendaContactos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(822, 417);
            this.Controls.Add(this.gbBotones);
            this.Controls.Add(this.gbDatos);
            this.Controls.Add(this.dgvColumna);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgendaContactos";
            this.Text = "Agenda de Contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvColumna)).EndInit();
            this.gbDatos.ResumeLayout(false);
            this.gbDatos.PerformLayout();
            this.gbBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvColumna;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvTelefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCorreo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoría;
        private System.Windows.Forms.GroupBox gbDatos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.MaskedTextBox mtbTelefono;
        private System.Windows.Forms.TextBox tboNombre;
        private System.Windows.Forms.TextBox tboApellido;
        private System.Windows.Forms.TextBox tboCorreo;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.GroupBox gbBotones;
    }
}

