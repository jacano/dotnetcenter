namespace GestionPrestamos
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
            this.tcPrestamos = new System.Windows.Forms.TabControl();
            this.tpPrestamo = new System.Windows.Forms.TabPage();
            this.btPrestar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbCoordinadores = new System.Windows.Forms.ComboBox();
            this.gbMateriales = new System.Windows.Forms.GroupBox();
            this.cbFiltro = new System.Windows.Forms.ComboBox();
            this.btBuscarMateriales = new System.Windows.Forms.Button();
            this.tbBuscarMateriales = new System.Windows.Forms.TextBox();
            this.gvMateriales = new System.Windows.Forms.DataGridView();
            this.gbSocios = new System.Windows.Forms.GroupBox();
            this.gvSocios = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarSocios = new System.Windows.Forms.Button();
            this.tbBuscarSocios = new System.Windows.Forms.TextBox();
            this.tpDevolucion = new System.Windows.Forms.TabPage();
            this.gbBuscarPrestamo = new System.Windows.Forms.GroupBox();
            this.gvPrestamos = new System.Windows.Forms.DataGridView();
            this.Identificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarPrestamo = new System.Windows.Forms.Button();
            this.tbBuscarPrestamo = new System.Windows.Forms.TextBox();
            this.btnRecoger = new System.Windows.Forms.Button();
            this.lbCoordinadorRecoge = new System.Windows.Forms.Label();
            this.cbCoordinadorRecoge = new System.Windows.Forms.ComboBox();
            this.tpEstado = new System.Windows.Forms.TabPage();
            this.gbHistorialPrestamos = new System.Windows.Forms.GroupBox();
            this.gvHistorialPrestamos = new System.Windows.Forms.DataGridView();
            this.btnBuscarHistorialPrestamos = new System.Windows.Forms.Button();
            this.tbBuscarHistorialPrestamos = new System.Windows.Forms.TextBox();
            this.gbPrestamosPendientes = new System.Windows.Forms.GroupBox();
            this.cbTemporal = new System.Windows.Forms.ComboBox();
            this.gvPrestamosPendientes = new System.Windows.Forms.DataGridView();
            this.btBuscarPrestamosPendientes = new System.Windows.Forms.Button();
            this.tbBuscarPrestamosPendientes = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPrestamo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcPrestamos.SuspendLayout();
            this.tpPrestamo.SuspendLayout();
            this.gbMateriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriales)).BeginInit();
            this.gbSocios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).BeginInit();
            this.tpDevolucion.SuspendLayout();
            this.gbBuscarPrestamo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).BeginInit();
            this.tpEstado.SuspendLayout();
            this.gbHistorialPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPrestamos)).BeginInit();
            this.gbPrestamosPendientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamosPendientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tcPrestamos
            // 
            this.tcPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tcPrestamos.Controls.Add(this.tpPrestamo);
            this.tcPrestamos.Controls.Add(this.tpDevolucion);
            this.tcPrestamos.Controls.Add(this.tpEstado);
            this.tcPrestamos.Location = new System.Drawing.Point(3, 3);
            this.tcPrestamos.Name = "tcPrestamos";
            this.tcPrestamos.SelectedIndex = 0;
            this.tcPrestamos.Size = new System.Drawing.Size(794, 594);
            this.tcPrestamos.TabIndex = 0;
            // 
            // tpPrestamo
            // 
            this.tpPrestamo.BackColor = System.Drawing.SystemColors.Control;
            this.tpPrestamo.Controls.Add(this.btPrestar);
            this.tpPrestamo.Controls.Add(this.label1);
            this.tpPrestamo.Controls.Add(this.cbCoordinadores);
            this.tpPrestamo.Controls.Add(this.gbMateriales);
            this.tpPrestamo.Controls.Add(this.gbSocios);
            this.tpPrestamo.Location = new System.Drawing.Point(4, 22);
            this.tpPrestamo.Name = "tpPrestamo";
            this.tpPrestamo.Padding = new System.Windows.Forms.Padding(3);
            this.tpPrestamo.Size = new System.Drawing.Size(786, 568);
            this.tpPrestamo.TabIndex = 0;
            this.tpPrestamo.Text = "Realizar Prestamo";
            // 
            // btPrestar
            // 
            this.btPrestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btPrestar.Location = new System.Drawing.Point(12, 526);
            this.btPrestar.Name = "btPrestar";
            this.btPrestar.Size = new System.Drawing.Size(127, 23);
            this.btPrestar.TabIndex = 35;
            this.btPrestar.Text = "Prestar";
            this.btPrestar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 490);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 13);
            this.label1.TabIndex = 34;
            this.label1.Text = "Coordinador que realiza el prestamo:";
            // 
            // cbCoordinadores
            // 
            this.cbCoordinadores.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCoordinadores.DisplayMember = "Display";
            this.cbCoordinadores.FormattingEnabled = true;
            this.cbCoordinadores.Location = new System.Drawing.Point(193, 487);
            this.cbCoordinadores.Name = "cbCoordinadores";
            this.cbCoordinadores.Size = new System.Drawing.Size(252, 21);
            this.cbCoordinadores.TabIndex = 33;
            this.cbCoordinadores.ValueMember = "Guid";
            // 
            // gbMateriales
            // 
            this.gbMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbMateriales.Controls.Add(this.cbFiltro);
            this.gbMateriales.Controls.Add(this.btBuscarMateriales);
            this.gbMateriales.Controls.Add(this.tbBuscarMateriales);
            this.gbMateriales.Controls.Add(this.gvMateriales);
            this.gbMateriales.Location = new System.Drawing.Point(3, 227);
            this.gbMateriales.Name = "gbMateriales";
            this.gbMateriales.Size = new System.Drawing.Size(774, 246);
            this.gbMateriales.TabIndex = 23;
            this.gbMateriales.TabStop = false;
            this.gbMateriales.Text = "Materiales";
            // 
            // cbFiltro
            // 
            this.cbFiltro.DisplayMember = "Display";
            this.cbFiltro.FormattingEnabled = true;
            this.cbFiltro.Location = new System.Drawing.Point(6, 45);
            this.cbFiltro.Name = "cbFiltro";
            this.cbFiltro.Size = new System.Drawing.Size(201, 21);
            this.cbFiltro.TabIndex = 32;
            this.cbFiltro.ValueMember = "Guid";
            // 
            // btBuscarMateriales
            // 
            this.btBuscarMateriales.Location = new System.Drawing.Point(297, 17);
            this.btBuscarMateriales.Name = "btBuscarMateriales";
            this.btBuscarMateriales.Size = new System.Drawing.Size(62, 23);
            this.btBuscarMateriales.TabIndex = 31;
            this.btBuscarMateriales.Text = "Buscar";
            this.btBuscarMateriales.UseVisualStyleBackColor = true;
            // 
            // tbBuscarMateriales
            // 
            this.tbBuscarMateriales.Location = new System.Drawing.Point(6, 19);
            this.tbBuscarMateriales.MaxLength = 50;
            this.tbBuscarMateriales.Name = "tbBuscarMateriales";
            this.tbBuscarMateriales.Size = new System.Drawing.Size(285, 20);
            this.tbBuscarMateriales.TabIndex = 30;
            // 
            // gvMateriales
            // 
            this.gvMateriales.AllowUserToAddRows = false;
            this.gvMateriales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvMateriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvMateriales.Location = new System.Drawing.Point(6, 72);
            this.gvMateriales.Name = "gvMateriales";
            this.gvMateriales.Size = new System.Drawing.Size(755, 166);
            this.gvMateriales.TabIndex = 8;
            // 
            // gbSocios
            // 
            this.gbSocios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSocios.Controls.Add(this.gvSocios);
            this.gbSocios.Controls.Add(this.btnBuscarSocios);
            this.gbSocios.Controls.Add(this.tbBuscarSocios);
            this.gbSocios.Location = new System.Drawing.Point(3, 3);
            this.gbSocios.Name = "gbSocios";
            this.gbSocios.Size = new System.Drawing.Size(777, 218);
            this.gbSocios.TabIndex = 22;
            this.gbSocios.TabStop = false;
            this.gbSocios.Text = "Busqueda de Socio";
            // 
            // gvSocios
            // 
            this.gvSocios.AllowUserToAddRows = false;
            this.gvSocios.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvSocios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.gvSocios.Location = new System.Drawing.Point(6, 45);
            this.gvSocios.Name = "gvSocios";
            this.gvSocios.Size = new System.Drawing.Size(755, 166);
            this.gvSocios.TabIndex = 18;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "idPersona";
            this.Column1.HeaderText = "identification";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // btnBuscarSocios
            // 
            this.btnBuscarSocios.Location = new System.Drawing.Point(297, 17);
            this.btnBuscarSocios.Name = "btnBuscarSocios";
            this.btnBuscarSocios.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarSocios.TabIndex = 20;
            this.btnBuscarSocios.Text = "Buscar";
            this.btnBuscarSocios.UseVisualStyleBackColor = true;

            // 
            // tbBuscarSocios
            // 
            this.tbBuscarSocios.Location = new System.Drawing.Point(6, 19);
            this.tbBuscarSocios.MaxLength = 50;
            this.tbBuscarSocios.Name = "tbBuscarSocios";
            this.tbBuscarSocios.Size = new System.Drawing.Size(285, 20);
            this.tbBuscarSocios.TabIndex = 19;

            // 
            // tpDevolucion
            // 
            this.tpDevolucion.BackColor = System.Drawing.SystemColors.Control;
            this.tpDevolucion.Controls.Add(this.gbBuscarPrestamo);
            this.tpDevolucion.Controls.Add(this.btnRecoger);
            this.tpDevolucion.Controls.Add(this.lbCoordinadorRecoge);
            this.tpDevolucion.Controls.Add(this.cbCoordinadorRecoge);
            this.tpDevolucion.Location = new System.Drawing.Point(4, 22);
            this.tpDevolucion.Name = "tpDevolucion";
            this.tpDevolucion.Padding = new System.Windows.Forms.Padding(3);
            this.tpDevolucion.Size = new System.Drawing.Size(786, 568);
            this.tpDevolucion.TabIndex = 1;
            this.tpDevolucion.Text = "Realizar devolución";
            // 
            // gbBuscarPrestamo
            // 
            this.gbBuscarPrestamo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbBuscarPrestamo.Controls.Add(this.gvPrestamos);
            this.gbBuscarPrestamo.Controls.Add(this.btnBuscarPrestamo);
            this.gbBuscarPrestamo.Controls.Add(this.tbBuscarPrestamo);
            this.gbBuscarPrestamo.Location = new System.Drawing.Point(6, 6);
            this.gbBuscarPrestamo.Name = "gbBuscarPrestamo";
            this.gbBuscarPrestamo.Size = new System.Drawing.Size(777, 465);
            this.gbBuscarPrestamo.TabIndex = 39;
            this.gbBuscarPrestamo.TabStop = false;
            this.gbBuscarPrestamo.Text = "Busqueda de prestamo";
            // 
            // gvPrestamos
            // 
            this.gvPrestamos.AllowUserToAddRows = false;
            this.gvPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Identificación});
            this.gvPrestamos.Location = new System.Drawing.Point(6, 45);
            this.gvPrestamos.Name = "gvPrestamos";
            this.gvPrestamos.Size = new System.Drawing.Size(765, 413);
            this.gvPrestamos.TabIndex = 18;
            // 
            // Identificación
            // 
            this.Identificación.DataPropertyName = "idPrestamo";
            this.Identificación.HeaderText = "Identificación";
            this.Identificación.Name = "Identificación";
            this.Identificación.Visible = false;
            // 
            // btnBuscarPrestamo
            // 
            this.btnBuscarPrestamo.Location = new System.Drawing.Point(297, 17);
            this.btnBuscarPrestamo.Name = "btnBuscarPrestamo";
            this.btnBuscarPrestamo.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarPrestamo.TabIndex = 20;
            this.btnBuscarPrestamo.Text = "Buscar";
            this.btnBuscarPrestamo.UseVisualStyleBackColor = true;

            // 
            // tbBuscarPrestamo
            // 
            this.tbBuscarPrestamo.Location = new System.Drawing.Point(6, 19);
            this.tbBuscarPrestamo.MaxLength = 50;
            this.tbBuscarPrestamo.Name = "tbBuscarPrestamo";
            this.tbBuscarPrestamo.Size = new System.Drawing.Size(285, 20);
            this.tbBuscarPrestamo.TabIndex = 19;

            // 
            // btnRecoger
            // 
            this.btnRecoger.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRecoger.Location = new System.Drawing.Point(18, 530);
            this.btnRecoger.Name = "btnRecoger";
            this.btnRecoger.Size = new System.Drawing.Size(127, 23);
            this.btnRecoger.TabIndex = 38;
            this.btnRecoger.Text = "Recoger";
            this.btnRecoger.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnRecoger.UseVisualStyleBackColor = true;
            // 
            // lbCoordinadorRecoge
            // 
            this.lbCoordinadorRecoge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbCoordinadorRecoge.AutoSize = true;
            this.lbCoordinadorRecoge.Location = new System.Drawing.Point(15, 494);
            this.lbCoordinadorRecoge.Name = "lbCoordinadorRecoge";
            this.lbCoordinadorRecoge.Size = new System.Drawing.Size(181, 13);
            this.lbCoordinadorRecoge.TabIndex = 37;
            this.lbCoordinadorRecoge.Text = "Coordinador que recoge el prestamo:";
            // 
            // cbCoordinadorRecoge
            // 
            this.cbCoordinadorRecoge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cbCoordinadorRecoge.DisplayMember = "Display";
            this.cbCoordinadorRecoge.FormattingEnabled = true;
            this.cbCoordinadorRecoge.Location = new System.Drawing.Point(199, 491);
            this.cbCoordinadorRecoge.Name = "cbCoordinadorRecoge";
            this.cbCoordinadorRecoge.Size = new System.Drawing.Size(252, 21);
            this.cbCoordinadorRecoge.TabIndex = 36;
            this.cbCoordinadorRecoge.ValueMember = "Guid";
            // 
            // tpEstado
            // 
            this.tpEstado.BackColor = System.Drawing.SystemColors.Control;
            this.tpEstado.Controls.Add(this.gbHistorialPrestamos);
            this.tpEstado.Controls.Add(this.gbPrestamosPendientes);
            this.tpEstado.Location = new System.Drawing.Point(4, 22);
            this.tpEstado.Name = "tpEstado";
            this.tpEstado.Size = new System.Drawing.Size(786, 568);
            this.tpEstado.TabIndex = 2;
            this.tpEstado.Text = "Estado de prestamos";
            // 
            // gbHistorialPrestamos
            // 
            this.gbHistorialPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbHistorialPrestamos.Controls.Add(this.gvHistorialPrestamos);
            this.gbHistorialPrestamos.Controls.Add(this.btnBuscarHistorialPrestamos);
            this.gbHistorialPrestamos.Controls.Add(this.tbBuscarHistorialPrestamos);
            this.gbHistorialPrestamos.Location = new System.Drawing.Point(6, 277);
            this.gbHistorialPrestamos.Name = "gbHistorialPrestamos";
            this.gbHistorialPrestamos.Size = new System.Drawing.Size(777, 288);
            this.gbHistorialPrestamos.TabIndex = 41;
            this.gbHistorialPrestamos.TabStop = false;
            this.gbHistorialPrestamos.Text = "Historial prestamos";
            // 
            // gvHistorialPrestamos
            // 
            this.gvHistorialPrestamos.AllowUserToAddRows = false;
            this.gvHistorialPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvHistorialPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvHistorialPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.gvHistorialPrestamos.Location = new System.Drawing.Point(6, 45);
            this.gvHistorialPrestamos.Name = "gvHistorialPrestamos";
            this.gvHistorialPrestamos.Size = new System.Drawing.Size(765, 236);
            this.gvHistorialPrestamos.TabIndex = 18;
            // 
            // btnBuscarHistorialPrestamos
            // 
            this.btnBuscarHistorialPrestamos.Location = new System.Drawing.Point(297, 17);
            this.btnBuscarHistorialPrestamos.Name = "btnBuscarHistorialPrestamos";
            this.btnBuscarHistorialPrestamos.Size = new System.Drawing.Size(62, 23);
            this.btnBuscarHistorialPrestamos.TabIndex = 20;
            this.btnBuscarHistorialPrestamos.Text = "Buscar";
            this.btnBuscarHistorialPrestamos.UseVisualStyleBackColor = true;

            // 
            // tbBuscarHistorialPrestamos
            // 
            this.tbBuscarHistorialPrestamos.Location = new System.Drawing.Point(6, 19);
            this.tbBuscarHistorialPrestamos.MaxLength = 50;
            this.tbBuscarHistorialPrestamos.Name = "tbBuscarHistorialPrestamos";
            this.tbBuscarHistorialPrestamos.Size = new System.Drawing.Size(285, 20);
            this.tbBuscarHistorialPrestamos.TabIndex = 19;

            // 
            // gbPrestamosPendientes
            // 
            this.gbPrestamosPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gbPrestamosPendientes.Controls.Add(this.cbTemporal);
            this.gbPrestamosPendientes.Controls.Add(this.gvPrestamosPendientes);
            this.gbPrestamosPendientes.Controls.Add(this.btBuscarPrestamosPendientes);
            this.gbPrestamosPendientes.Controls.Add(this.tbBuscarPrestamosPendientes);
            this.gbPrestamosPendientes.Location = new System.Drawing.Point(6, 3);
            this.gbPrestamosPendientes.Name = "gbPrestamosPendientes";
            this.gbPrestamosPendientes.Size = new System.Drawing.Size(777, 273);
            this.gbPrestamosPendientes.TabIndex = 40;
            this.gbPrestamosPendientes.TabStop = false;
            this.gbPrestamosPendientes.Text = "Prestamos pendientes";
            // 
            // cbTemporal
            // 
            this.cbTemporal.FormattingEnabled = true;
            this.cbTemporal.Location = new System.Drawing.Point(554, 17);
            this.cbTemporal.Name = "cbTemporal";
            this.cbTemporal.Size = new System.Drawing.Size(217, 21);
            this.cbTemporal.TabIndex = 21;

            // 
            // gvPrestamosPendientes
            // 
            this.gvPrestamosPendientes.AllowUserToAddRows = false;
            this.gvPrestamosPendientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gvPrestamosPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvPrestamosPendientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrestamo});
            this.gvPrestamosPendientes.Location = new System.Drawing.Point(6, 45);
            this.gvPrestamosPendientes.Name = "gvPrestamosPendientes";
            this.gvPrestamosPendientes.Size = new System.Drawing.Size(765, 221);
            this.gvPrestamosPendientes.TabIndex = 18;
            // 
            // btBuscarPrestamosPendientes
            // 
            this.btBuscarPrestamosPendientes.Location = new System.Drawing.Point(297, 17);
            this.btBuscarPrestamosPendientes.Name = "btBuscarPrestamosPendientes";
            this.btBuscarPrestamosPendientes.Size = new System.Drawing.Size(62, 23);
            this.btBuscarPrestamosPendientes.TabIndex = 20;
            this.btBuscarPrestamosPendientes.Text = "Buscar";
            this.btBuscarPrestamosPendientes.UseVisualStyleBackColor = true;

            // 
            // tbBuscarPrestamosPendientes
            // 
            this.tbBuscarPrestamosPendientes.Location = new System.Drawing.Point(6, 19);
            this.tbBuscarPrestamosPendientes.MaxLength = 50;
            this.tbBuscarPrestamosPendientes.Name = "tbBuscarPrestamosPendientes";
            this.tbBuscarPrestamosPendientes.Size = new System.Drawing.Size(285, 20);
            this.tbBuscarPrestamosPendientes.TabIndex = 19;

            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idPersona";
            this.dataGridViewTextBoxColumn1.HeaderText = "identification";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "idPrestamo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Identificación";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "idPrestamo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Identificación";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // idPrestamo
            // 
            this.idPrestamo.DataPropertyName = "idPrestamo";
            this.idPrestamo.HeaderText = "Identificación";
            this.idPrestamo.Name = "idPrestamo";
            this.idPrestamo.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "idPrestamo";
            this.Column2.HeaderText = "Identificación";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // MainControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tcPrestamos);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainControl";
            this.Size = new System.Drawing.Size(800, 600);
            this.tcPrestamos.ResumeLayout(false);
            this.tpPrestamo.ResumeLayout(false);
            this.tpPrestamo.PerformLayout();
            this.gbMateriales.ResumeLayout(false);
            this.gbMateriales.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvMateriales)).EndInit();
            this.gbSocios.ResumeLayout(false);
            this.gbSocios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvSocios)).EndInit();
            this.tpDevolucion.ResumeLayout(false);
            this.tpDevolucion.PerformLayout();
            this.gbBuscarPrestamo.ResumeLayout(false);
            this.gbBuscarPrestamo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamos)).EndInit();
            this.tpEstado.ResumeLayout(false);
            this.gbHistorialPrestamos.ResumeLayout(false);
            this.gbHistorialPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvHistorialPrestamos)).EndInit();
            this.gbPrestamosPendientes.ResumeLayout(false);
            this.gbPrestamosPendientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvPrestamosPendientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcPrestamos;
        private System.Windows.Forms.TabPage tpPrestamo;
        private System.Windows.Forms.TabPage tpDevolucion;
        private System.Windows.Forms.TabPage tpEstado;
        private System.Windows.Forms.GroupBox gbSocios;
        private System.Windows.Forms.DataGridView gvSocios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnBuscarSocios;
        private System.Windows.Forms.TextBox tbBuscarSocios;
        private System.Windows.Forms.GroupBox gbMateriales;
        private System.Windows.Forms.ComboBox cbFiltro;
        private System.Windows.Forms.Button btBuscarMateriales;
        private System.Windows.Forms.TextBox tbBuscarMateriales;
        private System.Windows.Forms.DataGridView gvMateriales;
        private System.Windows.Forms.Button btPrestar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbCoordinadores;
        private System.Windows.Forms.Button btnRecoger;
        private System.Windows.Forms.Label lbCoordinadorRecoge;
        private System.Windows.Forms.ComboBox cbCoordinadorRecoge;
        private System.Windows.Forms.GroupBox gbBuscarPrestamo;
        private System.Windows.Forms.DataGridView gvPrestamos;
        private System.Windows.Forms.Button btnBuscarPrestamo;
        private System.Windows.Forms.TextBox tbBuscarPrestamo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Identificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.GroupBox gbHistorialPrestamos;
        private System.Windows.Forms.DataGridView gvHistorialPrestamos;
        private System.Windows.Forms.Button btnBuscarHistorialPrestamos;
        private System.Windows.Forms.TextBox tbBuscarHistorialPrestamos;
        private System.Windows.Forms.GroupBox gbPrestamosPendientes;
        private System.Windows.Forms.DataGridView gvPrestamosPendientes;
        private System.Windows.Forms.Button btBuscarPrestamosPendientes;
        private System.Windows.Forms.TextBox tbBuscarPrestamosPendientes;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.ComboBox cbTemporal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPrestamo;
    }
}
