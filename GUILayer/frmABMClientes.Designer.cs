namespace LPCFacturas.GUILayer
{
    partial class frmABMClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmABMClientes));
            this.lblId = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cboBarrio = new System.Windows.Forms.ComboBox();
            this.cboContacto = new System.Windows.Forms.ComboBox();
            this.lblContacto = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razonSocial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.calle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnHabilitarBusqueda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblId.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblId.Location = new System.Drawing.Point(115, 18);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(41, 29);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.White;
            this.txtId.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtId.Location = new System.Drawing.Point(165, 15);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(123, 36);
            this.txtId.TabIndex = 1;
            // 
            // txtCuit
            // 
            this.txtCuit.BackColor = System.Drawing.Color.White;
            this.txtCuit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCuit.Location = new System.Drawing.Point(165, 60);
            this.txtCuit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(333, 36);
            this.txtCuit.TabIndex = 3;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCuit.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCuit.Location = new System.Drawing.Point(91, 64);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(66, 29);
            this.lblCuit.TabIndex = 2;
            this.lblCuit.Text = "CUIT:";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.Color.White;
            this.txtRazonSocial.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtRazonSocial.Location = new System.Drawing.Point(165, 106);
            this.txtRazonSocial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(333, 36);
            this.txtRazonSocial.TabIndex = 5;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRazonSocial.Location = new System.Drawing.Point(7, 110);
            this.lblRazonSocial.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(145, 29);
            this.lblRazonSocial.TabIndex = 4;
            this.lblRazonSocial.Text = "Razón Social:";
            // 
            // txtCalle
            // 
            this.txtCalle.BackColor = System.Drawing.Color.White;
            this.txtCalle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtCalle.Location = new System.Drawing.Point(715, 60);
            this.txtCalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(351, 36);
            this.txtCalle.TabIndex = 7;
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCalle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCalle.Location = new System.Drawing.Point(615, 64);
            this.lblCalle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(69, 29);
            this.lblCalle.TabIndex = 6;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNumero.Location = new System.Drawing.Point(715, 110);
            this.txtNumero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(351, 36);
            this.txtNumero.TabIndex = 9;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNumero.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNumero.Location = new System.Drawing.Point(580, 110);
            this.lblNumero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(103, 29);
            this.lblNumero.TabIndex = 8;
            this.lblNumero.Text = "Número:";
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFechaAlta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFechaAlta.Location = new System.Drawing.Point(528, 155);
            this.lblFechaAlta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(151, 29);
            this.lblFechaAlta.TabIndex = 10;
            this.lblFechaAlta.Text = "Fecha de alta:";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.CalendarForeColor = System.Drawing.Color.White;
            this.dtpFechaAlta.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.dtpFechaAlta.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.dtpFechaAlta.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtpFechaAlta.CalendarTrailingForeColor = System.Drawing.Color.White;
            this.dtpFechaAlta.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.dtpFechaAlta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaAlta.Location = new System.Drawing.Point(715, 151);
            this.dtpFechaAlta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.Size = new System.Drawing.Size(351, 36);
            this.dtpFechaAlta.TabIndex = 11;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblBarrio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBarrio.Location = new System.Drawing.Point(601, 18);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(82, 29);
            this.lblBarrio.TabIndex = 12;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cboBarrio
            // 
            this.cboBarrio.BackColor = System.Drawing.Color.White;
            this.cboBarrio.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboBarrio.FormattingEnabled = true;
            this.cboBarrio.Location = new System.Drawing.Point(715, 15);
            this.cboBarrio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboBarrio.Name = "cboBarrio";
            this.cboBarrio.Size = new System.Drawing.Size(351, 37);
            this.cboBarrio.TabIndex = 13;
            // 
            // cboContacto
            // 
            this.cboContacto.BackColor = System.Drawing.Color.White;
            this.cboContacto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.cboContacto.FormattingEnabled = true;
            this.cboContacto.Location = new System.Drawing.Point(165, 151);
            this.cboContacto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboContacto.Name = "cboContacto";
            this.cboContacto.Size = new System.Drawing.Size(333, 37);
            this.cboContacto.TabIndex = 15;
            this.cboContacto.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cboContactoFormat);
            // 
            // lblContacto
            // 
            this.lblContacto.AutoSize = true;
            this.lblContacto.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblContacto.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblContacto.Location = new System.Drawing.Point(43, 155);
            this.lblContacto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContacto.Name = "lblContacto";
            this.lblContacto.Size = new System.Drawing.Size(110, 29);
            this.lblContacto.TabIndex = 14;
            this.lblContacto.Text = "Contacto:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToAddRows = false;
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.cuit,
            this.razonSocial,
            this.calle,
            this.numero});
            this.dgvClientes.EnableHeadersVisualStyles = false;
            this.dgvClientes.Location = new System.Drawing.Point(16, 209);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1051, 444);
            this.dgvClientes.TabIndex = 16;
            this.dgvClientes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellContentClick_1);
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 50;
            // 
            // cuit
            // 
            this.cuit.HeaderText = "CUIT";
            this.cuit.MinimumWidth = 6;
            this.cuit.Name = "cuit";
            this.cuit.ReadOnly = true;
            this.cuit.Width = 125;
            // 
            // razonSocial
            // 
            this.razonSocial.HeaderText = "Razón Social";
            this.razonSocial.MinimumWidth = 6;
            this.razonSocial.Name = "razonSocial";
            this.razonSocial.ReadOnly = true;
            this.razonSocial.Width = 200;
            // 
            // calle
            // 
            this.calle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.calle.HeaderText = "Calle";
            this.calle.MinimumWidth = 6;
            this.calle.Name = "calle";
            this.calle.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número";
            this.numero.MinimumWidth = 6;
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            this.numero.Width = 125;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnSalir.Image = global::LPCFacturas.Properties.Resources.Salir;
            this.btnSalir.Location = new System.Drawing.Point(981, 661);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 69);
            this.btnSalir.TabIndex = 23;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnCancelar.Image = global::LPCFacturas.Properties.Resources.firewall_off2;
            this.btnCancelar.Location = new System.Drawing.Point(715, 661);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 69);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnGuardar.Image = global::LPCFacturas.Properties.Resources.firewallcheck2;
            this.btnGuardar.Location = new System.Drawing.Point(621, 661);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(85, 69);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEliminar.Image = global::LPCFacturas.Properties.Resources.Error_X2;
            this.btnEliminar.Location = new System.Drawing.Point(204, 661);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(85, 69);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnEditar.Image = global::LPCFacturas.Properties.Resources.Mono_Pen2;
            this.btnEditar.Location = new System.Drawing.Point(109, 661);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(85, 69);
            this.btnEditar.TabIndex = 19;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.btnNuevo.FlatAppearance.BorderSize = 0;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnNuevo.Image = global::LPCFacturas.Properties.Resources.AddPrueba2;
            this.btnNuevo.Location = new System.Drawing.Point(16, 661);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(85, 69);
            this.btnNuevo.TabIndex = 18;
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnHabilitarBusqueda
            // 
            this.btnHabilitarBusqueda.FlatAppearance.BorderSize = 0;
            this.btnHabilitarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHabilitarBusqueda.Image = ((System.Drawing.Image)(resources.GetObject("btnHabilitarBusqueda.Image")));
            this.btnHabilitarBusqueda.Location = new System.Drawing.Point(312, 662);
            this.btnHabilitarBusqueda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHabilitarBusqueda.Name = "btnHabilitarBusqueda";
            this.btnHabilitarBusqueda.Size = new System.Drawing.Size(80, 68);
            this.btnHabilitarBusqueda.TabIndex = 38;
            this.btnHabilitarBusqueda.UseVisualStyleBackColor = true;
            this.btnHabilitarBusqueda.Click += new System.EventHandler(this.btnHabilitarBusqueda_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Image = global::LPCFacturas.Properties.Resources.Search;
            this.btnBuscar.Location = new System.Drawing.Point(480, 661);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(64, 68);
            this.btnBuscar.TabIndex = 37;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Visible = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmABMClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(2)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1083, 745);
            this.Controls.Add(this.btnHabilitarBusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.cboContacto);
            this.Controls.Add(this.lblContacto);
            this.Controls.Add(this.cboBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Controls.Add(this.dtpFechaAlta);
            this.Controls.Add(this.lblFechaAlta);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.txtCalle);
            this.Controls.Add(this.lblCalle);
            this.Controls.Add(this.txtRazonSocial);
            this.Controls.Add(this.lblRazonSocial);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.lblCuit);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.lblId);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmABMClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "A B M Clientes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmABMClientes_FormClosing);
            this.Load += new System.EventHandler(this.frmABMClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cboBarrio;
        private System.Windows.Forms.ComboBox cboContacto;
        private System.Windows.Forms.Label lblContacto;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn razonSocial;
        private System.Windows.Forms.DataGridViewTextBoxColumn calle;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.Button btnHabilitarBusqueda;
        private System.Windows.Forms.Button btnBuscar;
    }
}