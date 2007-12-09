namespace GestionMiembros
{
    partial class MainControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbApellidos = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblApellidos = new System.Windows.Forms.Label();
            this.btnAñadir = new System.Windows.Forms.Button();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbDni = new System.Windows.Forms.TextBox();
            this.lblDNI = new System.Windows.Forms.Label();
            this.tbTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.CheckBox();
            this.grbPersonalData = new System.Windows.Forms.GroupBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.grbSocio = new System.Windows.Forms.GroupBox();
            this.tbProvincia = new System.Windows.Forms.TextBox();
            this.tbLocalidad = new System.Windows.Forms.TextBox();
            this.tbDomicilio = new System.Windows.Forms.TextBox();
            this.lblProvincia = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.grbMiembro = new System.Windows.Forms.GroupBox();
            this.dtpFechaAlta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAlta = new System.Windows.Forms.Label();
            this.grbPersona = new System.Windows.Forms.GroupBox();
            this.tcGrids = new System.Windows.Forms.TabControl();
            this.tpPersonas = new System.Windows.Forms.TabPage();
            this.btnBuscarPersonas = new System.Windows.Forms.Button();
            this.tbBuscarPersonas = new System.Windows.Forms.TextBox();
            this.gvPersonas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpMiembros = new System.Windows.Forms.TabPage();
            this.btnBuscarMiembros = new System.Windows.Forms.Button();
            this.tbBuscarMiembros = new System.Windows.Forms.TextBox();
            this.gvMiembros = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpSocios = new System.Windows.Forms.TabPage();
            this.btnBuscarSocios = new System.Windows.Forms.Button();
            this.tbBuscarSocios = new System.Windows.Forms.TextBox();
            this.gvSocios = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbPersonasMiembros = new System.Windows.Forms.CheckBox();
            this.cbPersonasSocios = new System.Windows.Forms.CheckBox();
            this.cbMiembrosSocios = new System.Windows.Forms.CheckBox();
            this.grbPersonalData.SuspendLayout();
            this.grbSocio.SuspendLayout();
            this.grbMiembro.SuspendLayout();
            this.grbPersona.SuspendLayout();
            this.tcGrids.SuspendLayout();
            this.tpPersonas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonas)).BeginInit();
            this.tpMiembros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiembros)).BeginInit();
            this.tpSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(65, 65);
            this.tbEmail.MaxLength = 50;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbEmail.Size = new System.Drawing.Size(306, 20);
            this.tbEmail.TabIndex = 3;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 4;
            this.lblNombre.Text = "Nombre";
            // 
            // tbApellidos
            // 
            this.tbApellidos.Location = new System.Drawing.Point(65, 39);
            this.tbApellidos.MaxLength = 50;
            this.tbApellidos.Name = "tbApellidos";
            this.tbApellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbApellidos.Size = new System.Drawing.Size(306, 20);
            this.tbApellidos.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblApellidos
            // 
            this.lblApellidos.AutoSize = true;
            this.lblApellidos.Location = new System.Drawing.Point(6, 42);
            this.lblApellidos.Name = "lblApellidos";
            this.lblApellidos.Size = new System.Drawing.Size(49, 13);
            this.lblApellidos.TabIndex = 6;
            this.lblApellidos.Text = "Apellidos";
            // 
            // btnAñadir
            // 
            this.btnAñadir.Location = new System.Drawing.Point(6, 216);
            this.btnAñadir.Name = "btnAñadir";
            this.btnAñadir.Size = new System.Drawing.Size(75, 23);
            this.btnAñadir.TabIndex = 12;
            this.btnAñadir.Text = "Añadir";
            this.btnAñadir.UseVisualStyleBackColor = true;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(65, 13);
            this.tbNombre.MaxLength = 50;
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbNombre.Size = new System.Drawing.Size(306, 20);
            this.tbNombre.TabIndex = 1;
            // 
            // tbDni
            // 
            this.tbDni.Location = new System.Drawing.Point(65, 13);
            this.tbDni.MaxLength = 8;
            this.tbDni.Name = "tbDni";
            this.tbDni.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDni.Size = new System.Drawing.Size(306, 20);
            this.tbDni.TabIndex = 5;
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(6, 16);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(26, 13);
            this.lblDNI.TabIndex = 8;
            this.lblDNI.Text = "DNI";
            // 
            // tbTelefono
            // 
            this.tbTelefono.Location = new System.Drawing.Point(65, 117);
            this.tbTelefono.MaxLength = 9;
            this.tbTelefono.Name = "tbTelefono";
            this.tbTelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbTelefono.Size = new System.Drawing.Size(306, 20);
            this.tbTelefono.TabIndex = 10;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(6, 120);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(49, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Telefono";
            // 
            // cbPago
            // 
            this.cbPago.AutoSize = true;
            this.cbPago.Location = new System.Drawing.Point(6, 154);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(146, 17);
            this.cbPago.TabIndex = 11;
            this.cbPago.Text = "Entregada Carta de Pago";
            this.cbPago.UseVisualStyleBackColor = true;
            // 
            // grbPersonalData
            // 
            this.grbPersonalData.Controls.Add(this.btnLimpiar);
            this.grbPersonalData.Controls.Add(this.btnBorrar);
            this.grbPersonalData.Controls.Add(this.btnModificar);
            this.grbPersonalData.Controls.Add(this.grbSocio);
            this.grbPersonalData.Controls.Add(this.grbMiembro);
            this.grbPersonalData.Controls.Add(this.btnAñadir);
            this.grbPersonalData.Controls.Add(this.grbPersona);
            this.grbPersonalData.Location = new System.Drawing.Point(3, 3);
            this.grbPersonalData.MinimumSize = new System.Drawing.Size(700, 245);
            this.grbPersonalData.Name = "grbPersonalData";
            this.grbPersonalData.Size = new System.Drawing.Size(806, 245);
            this.grbPersonalData.TabIndex = 10;
            this.grbPersonalData.TabStop = false;
            this.grbPersonalData.Text = "Datos personales";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(376, 216);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(168, 216);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 14;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(87, 216);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 13;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // grbSocio
            // 
            this.grbSocio.Controls.Add(this.tbProvincia);
            this.grbSocio.Controls.Add(this.tbLocalidad);
            this.grbSocio.Controls.Add(this.tbDomicilio);
            this.grbSocio.Controls.Add(this.lblProvincia);
            this.grbSocio.Controls.Add(this.lblLocalidad);
            this.grbSocio.Controls.Add(this.lblDomicilio);
            this.grbSocio.Controls.Add(this.tbDni);
            this.grbSocio.Controls.Add(this.lblDNI);
            this.grbSocio.Controls.Add(this.cbPago);
            this.grbSocio.Controls.Add(this.tbTelefono);
            this.grbSocio.Controls.Add(this.lblTelefono);
            this.grbSocio.Location = new System.Drawing.Point(405, 20);
            this.grbSocio.Name = "grbSocio";
            this.grbSocio.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbSocio.Size = new System.Drawing.Size(395, 190);
            this.grbSocio.TabIndex = 14;
            this.grbSocio.TabStop = false;
            this.grbSocio.Text = "Socio";
            // 
            // tbProvincia
            // 
            this.tbProvincia.Location = new System.Drawing.Point(65, 91);
            this.tbProvincia.MaxLength = 50;
            this.tbProvincia.Name = "tbProvincia";
            this.tbProvincia.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbProvincia.Size = new System.Drawing.Size(306, 20);
            this.tbProvincia.TabIndex = 8;
            // 
            // tbLocalidad
            // 
            this.tbLocalidad.Location = new System.Drawing.Point(65, 65);
            this.tbLocalidad.MaxLength = 50;
            this.tbLocalidad.Name = "tbLocalidad";
            this.tbLocalidad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbLocalidad.Size = new System.Drawing.Size(306, 20);
            this.tbLocalidad.TabIndex = 7;
            // 
            // tbDomicilio
            // 
            this.tbDomicilio.Location = new System.Drawing.Point(65, 39);
            this.tbDomicilio.MaxLength = 100;
            this.tbDomicilio.Name = "tbDomicilio";
            this.tbDomicilio.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tbDomicilio.Size = new System.Drawing.Size(306, 20);
            this.tbDomicilio.TabIndex = 6;
            // 
            // lblProvincia
            // 
            this.lblProvincia.AutoSize = true;
            this.lblProvincia.Location = new System.Drawing.Point(6, 94);
            this.lblProvincia.Name = "lblProvincia";
            this.lblProvincia.Size = new System.Drawing.Size(51, 13);
            this.lblProvincia.TabIndex = 14;
            this.lblProvincia.Text = "Provincia";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(6, 68);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(53, 13);
            this.lblLocalidad.TabIndex = 13;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Location = new System.Drawing.Point(6, 42);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(49, 13);
            this.lblDomicilio.TabIndex = 12;
            this.lblDomicilio.Text = "Domicilio";
            // 
            // grbMiembro
            // 
            this.grbMiembro.Controls.Add(this.dtpFechaAlta);
            this.grbMiembro.Controls.Add(this.lblFechaAlta);
            this.grbMiembro.Location = new System.Drawing.Point(6, 136);
            this.grbMiembro.Name = "grbMiembro";
            this.grbMiembro.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbMiembro.Size = new System.Drawing.Size(393, 73);
            this.grbMiembro.TabIndex = 13;
            this.grbMiembro.TabStop = false;
            this.grbMiembro.Text = "Miembro";
            // 
            // dtpFechaAlta
            // 
            this.dtpFechaAlta.Checked = false;
            this.dtpFechaAlta.Location = new System.Drawing.Point(85, 19);
            this.dtpFechaAlta.Name = "dtpFechaAlta";
            this.dtpFechaAlta.ShowCheckBox = true;
            this.dtpFechaAlta.Size = new System.Drawing.Size(286, 20);
            this.dtpFechaAlta.TabIndex = 4;
            // 
            // lblFechaAlta
            // 
            this.lblFechaAlta.AutoSize = true;
            this.lblFechaAlta.Location = new System.Drawing.Point(6, 25);
            this.lblFechaAlta.Name = "lblFechaAlta";
            this.lblFechaAlta.Size = new System.Drawing.Size(73, 13);
            this.lblFechaAlta.TabIndex = 6;
            this.lblFechaAlta.Text = "Fecha de Alta";
            // 
            // grbPersona
            // 
            this.grbPersona.Controls.Add(this.tbApellidos);
            this.grbPersona.Controls.Add(this.tbEmail);
            this.grbPersona.Controls.Add(this.lblNombre);
            this.grbPersona.Controls.Add(this.lblEmail);
            this.grbPersona.Controls.Add(this.lblApellidos);
            this.grbPersona.Controls.Add(this.tbNombre);
            this.grbPersona.Location = new System.Drawing.Point(6, 19);
            this.grbPersona.Name = "grbPersona";
            this.grbPersona.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbPersona.Size = new System.Drawing.Size(393, 98);
            this.grbPersona.TabIndex = 12;
            this.grbPersona.TabStop = false;
            this.grbPersona.Text = "Persona";
            // 
            // tcGrids
            // 
            this.tcGrids.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcGrids.Controls.Add(this.tpPersonas);
            this.tcGrids.Controls.Add(this.tpMiembros);
            this.tcGrids.Controls.Add(this.tpSocios);
            this.tcGrids.Location = new System.Drawing.Point(4, 254);
            this.tcGrids.MinimumSize = new System.Drawing.Size(700, 256);
            this.tcGrids.Name = "tcGrids";
            this.tcGrids.SelectedIndex = 0;
            this.tcGrids.Size = new System.Drawing.Size(809, 343);
            this.tcGrids.TabIndex = 11;
            // 
            // tpPersonas
            // 
            this.tpPersonas.Controls.Add(this.cbPersonasSocios);
            this.tpPersonas.Controls.Add(this.cbPersonasMiembros);
            this.tpPersonas.Controls.Add(this.btnBuscarPersonas);
            this.tpPersonas.Controls.Add(this.tbBuscarPersonas);
            this.tpPersonas.Controls.Add(this.gvPersonas);
            this.tpPersonas.Location = new System.Drawing.Point(4, 22);
            this.tpPersonas.Name = "tpPersonas";
            this.tpPersonas.Padding = new System.Windows.Forms.Padding(3);
            this.tpPersonas.Size = new System.Drawing.Size(801, 317);
            this.tpPersonas.TabIndex = 0;
            this.tpPersonas.Text = "Personas";
            this.tpPersonas.UseVisualStyleBackColor = true;
            // 
            // btnBuscarPersonas
            // 
            this.btnBuscarPersonas.Location = new System.Drawing.Point(297, 4);
            this.btnBuscarPersonas.Name = "btnBuscarPersonas";
            this.btnBuscarPersonas.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarPersonas.TabIndex = 17;
            this.btnBuscarPersonas.Text = "Buscar";
            this.btnBuscarPersonas.UseVisualStyleBackColor = true;
            // 
            // tbBuscarPersonas
            // 
            this.tbBuscarPersonas.Location = new System.Drawing.Point(7, 6);
            this.tbBuscarPersonas.MaxLength = 50;
            this.tbBuscarPersonas.Name = "tbBuscarPersonas";
            this.tbBuscarPersonas.Size = new System.Drawing.Size(284, 20);
            this.tbBuscarPersonas.TabIndex = 16;

            // 
            // gvPersonas
            // 
            this.gvPersonas.AllowUserToAddRows = false;
            this.gvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPersonas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvPersonas.Location = new System.Drawing.Point(7, 41);
            this.gvPersonas.Name = "gvPersonas";
            this.gvPersonas.Size = new System.Drawing.Size(788, 273);
            this.gvPersonas.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idPersona";
            this.Column1.HeaderText = "identification";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // tpMiembros
            // 
            this.tpMiembros.Controls.Add(this.cbMiembrosSocios);
            this.tpMiembros.Controls.Add(this.btnBuscarMiembros);
            this.tpMiembros.Controls.Add(this.tbBuscarMiembros);
            this.tpMiembros.Controls.Add(this.gvMiembros);
            this.tpMiembros.Location = new System.Drawing.Point(4, 22);
            this.tpMiembros.Name = "tpMiembros";
            this.tpMiembros.Padding = new System.Windows.Forms.Padding(3);
            this.tpMiembros.Size = new System.Drawing.Size(801, 317);
            this.tpMiembros.TabIndex = 1;
            this.tpMiembros.Text = "Miembros";
            this.tpMiembros.UseVisualStyleBackColor = true;
            // 
            // btnBuscarMiembros
            // 
            this.btnBuscarMiembros.Location = new System.Drawing.Point(296, 4);
            this.btnBuscarMiembros.Name = "btnBuscarMiembros";
            this.btnBuscarMiembros.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarMiembros.TabIndex = 20;
            this.btnBuscarMiembros.Text = "Buscar";
            this.btnBuscarMiembros.UseVisualStyleBackColor = true;
            // 
            // tbBuscarMiembros
            // 
            this.tbBuscarMiembros.Location = new System.Drawing.Point(6, 6);
            this.tbBuscarMiembros.MaxLength = 50;
            this.tbBuscarMiembros.Name = "tbBuscarMiembros";
            this.tbBuscarMiembros.Size = new System.Drawing.Size(284, 20);
            this.tbBuscarMiembros.TabIndex = 19;
            // 
            // gvMiembros
            // 
            this.gvMiembros.AllowUserToAddRows = false;
            this.gvMiembros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMiembros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMiembros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1});
            this.gvMiembros.Location = new System.Drawing.Point(6, 41);
            this.gvMiembros.Name = "gvMiembros";
            this.gvMiembros.Size = new System.Drawing.Size(788, 273);
            this.gvMiembros.TabIndex = 18;

            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPersona";
            this.dataGridViewTextBoxColumn1.HeaderText = "identification";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // tpSocios
            // 
            this.tpSocios.Controls.Add(this.btnBuscarSocios);
            this.tpSocios.Controls.Add(this.tbBuscarSocios);
            this.tpSocios.Controls.Add(this.gvSocios);
            this.tpSocios.Location = new System.Drawing.Point(4, 22);
            this.tpSocios.Name = "tpSocios";
            this.tpSocios.Size = new System.Drawing.Size(801, 317);
            this.tpSocios.TabIndex = 2;
            this.tpSocios.Text = "Socios";
            this.tpSocios.UseVisualStyleBackColor = true;
            // 
            // btnBuscarSocios
            // 
            this.btnBuscarSocios.Location = new System.Drawing.Point(296, 4);
            this.btnBuscarSocios.Name = "btnBuscarSocios";
            this.btnBuscarSocios.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarSocios.TabIndex = 20;
            this.btnBuscarSocios.Text = "Buscar";
            this.btnBuscarSocios.UseVisualStyleBackColor = true;

            // 
            // tbBuscarSocios
            // 
            this.tbBuscarSocios.Location = new System.Drawing.Point(6, 6);
            this.tbBuscarSocios.MaxLength = 50;
            this.tbBuscarSocios.Name = "tbBuscarSocios";
            this.tbBuscarSocios.Size = new System.Drawing.Size(284, 20);
            this.tbBuscarSocios.TabIndex = 19;

            // 
            // gvSocios
            // 
            this.gvSocios.AllowUserToAddRows = false;
            this.gvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.gvSocios.Location = new System.Drawing.Point(6, 41);
            this.gvSocios.Name = "gvSocios";
            this.gvSocios.Size = new System.Drawing.Size(788, 273);
            this.gvSocios.TabIndex = 18;
            
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idPersona";
            this.dataGridViewTextBoxColumn2.HeaderText = "identification";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // cbPersonasMiembros
            // 
            this.cbPersonasMiembros.AutoSize = true;
            this.cbPersonasMiembros.Location = new System.Drawing.Point(508, 8);
            this.cbPersonasMiembros.Name = "cbPersonasMiembros";
            this.cbPersonasMiembros.Size = new System.Drawing.Size(130, 17);
            this.cbPersonasMiembros.TabIndex = 18;
            this.cbPersonasMiembros.Text = "Ver también Miembros";
            this.cbPersonasMiembros.UseVisualStyleBackColor = true;
            
            // 
            // cbPersonasMiembrosSocios
            // 
            this.cbPersonasSocios.AutoSize = true;
            this.cbPersonasSocios.Location = new System.Drawing.Point(665, 8);
            this.cbPersonasSocios.Name = "cbPersonasMiembrosSocios";
            this.cbPersonasSocios.Size = new System.Drawing.Size(117, 17);
            this.cbPersonasSocios.TabIndex = 19;
            this.cbPersonasSocios.Text = "Ver también Socios";
            this.cbPersonasSocios.UseVisualStyleBackColor = true;

            // 
            // cbMiembrosSocios
            // 
            this.cbMiembrosSocios.AutoSize = true;
            this.cbMiembrosSocios.Location = new System.Drawing.Point(664, 8);
            this.cbMiembrosSocios.Name = "cbMiembrosSocios";
            this.cbMiembrosSocios.Size = new System.Drawing.Size(117, 17);
            this.cbMiembrosSocios.TabIndex = 21;
            this.cbMiembrosSocios.Text = "Ver también Socios";
            this.cbMiembrosSocios.UseVisualStyleBackColor = true;

            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcGrids);
            this.Controls.Add(this.grbPersonalData);
            this.MinimumSize = new System.Drawing.Size(816, 600);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(816, 600);
            this.grbPersonalData.ResumeLayout(false);
            this.grbSocio.ResumeLayout(false);
            this.grbSocio.PerformLayout();
            this.grbMiembro.ResumeLayout(false);
            this.grbMiembro.PerformLayout();
            this.grbPersona.ResumeLayout(false);
            this.grbPersona.PerformLayout();
            this.tcGrids.ResumeLayout(false);
            this.tpPersonas.ResumeLayout(false);
            this.tpPersonas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPersonas)).EndInit();
            this.tpMiembros.ResumeLayout(false);
            this.tpMiembros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMiembros)).EndInit();
            this.tpSocios.ResumeLayout(false);
            this.tpSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbApellidos;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblApellidos;
        private System.Windows.Forms.Button btnAñadir;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbDni;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.TextBox tbTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.CheckBox cbPago;
        private System.Windows.Forms.GroupBox grbPersonalData;
        private System.Windows.Forms.GroupBox grbMiembro;
        private System.Windows.Forms.Label lblFechaAlta;
        private System.Windows.Forms.GroupBox grbPersona;
        private System.Windows.Forms.DateTimePicker dtpFechaAlta;
        private System.Windows.Forms.GroupBox grbSocio;
        private System.Windows.Forms.Label lblProvincia;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.TextBox tbProvincia;
        private System.Windows.Forms.TextBox tbLocalidad;
        private System.Windows.Forms.TextBox tbDomicilio;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TabControl tcGrids;
        private System.Windows.Forms.TabPage tpPersonas;
        private System.Windows.Forms.TabPage tpMiembros;
        private System.Windows.Forms.TabPage tpSocios;
        private System.Windows.Forms.Button btnBuscarPersonas;
        private System.Windows.Forms.TextBox tbBuscarPersonas;
        private System.Windows.Forms.DataGridView gvPersonas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBuscarMiembros;
        private System.Windows.Forms.TextBox tbBuscarMiembros;
        private System.Windows.Forms.DataGridView gvMiembros;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button btnBuscarSocios;
        private System.Windows.Forms.TextBox tbBuscarSocios;
        private System.Windows.Forms.DataGridView gvSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.CheckBox cbPersonasSocios;
        private System.Windows.Forms.CheckBox cbPersonasMiembros;
        private System.Windows.Forms.CheckBox cbMiembrosSocios;
    }
}
