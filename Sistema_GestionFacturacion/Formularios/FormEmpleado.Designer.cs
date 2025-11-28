namespace Sistema_GestionFacturacion.Formularios
{
    partial class FormEmpleado
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleado));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTestConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActualizarDGV = new System.Windows.Forms.ToolStripMenuItem();
            this.btnReactivarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDesactivarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGuardarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNuevoRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbCargo = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtDNI = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtApellido = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdEmpleado = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.txtFiltrar = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.rbDatosInactivos = new System.Windows.Forms.RadioButton();
            this.rbDatosActivos = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.guna2ResizeForm1 = new Guna.UI2.WinForms.Guna2ResizeForm(this.components);
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.menuStrip1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 36);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnTestConexion
            // 
            this.btnTestConexion.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConexion.ForeColor = System.Drawing.Color.White;
            this.btnTestConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConexion.Image")));
            this.btnTestConexion.Name = "btnTestConexion";
            this.btnTestConexion.Size = new System.Drawing.Size(162, 36);
            this.btnTestConexion.Text = "Test Conexion";
            this.btnTestConexion.Click += new System.EventHandler(this.btnTestConexion_Click);
            // 
            // btnActualizarDGV
            // 
            this.btnActualizarDGV.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarDGV.ForeColor = System.Drawing.Color.White;
            this.btnActualizarDGV.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarDGV.Image")));
            this.btnActualizarDGV.Name = "btnActualizarDGV";
            this.btnActualizarDGV.Size = new System.Drawing.Size(150, 36);
            this.btnActualizarDGV.Text = "Refresh Data";
            this.btnActualizarDGV.Click += new System.EventHandler(this.btnActualizarDGV_Click);
            // 
            // btnReactivarRegistro
            // 
            this.btnReactivarRegistro.Enabled = false;
            this.btnReactivarRegistro.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReactivarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnReactivarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnReactivarRegistro.Image")));
            this.btnReactivarRegistro.Name = "btnReactivarRegistro";
            this.btnReactivarRegistro.Size = new System.Drawing.Size(201, 36);
            this.btnReactivarRegistro.Text = "Reactivar Registros";
            this.btnReactivarRegistro.Click += new System.EventHandler(this.btnReactivarRegistro_Click_1);
            // 
            // btnDesactivarRegistro
            // 
            this.btnDesactivarRegistro.Enabled = false;
            this.btnDesactivarRegistro.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnDesactivarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnDesactivarRegistro.Image")));
            this.btnDesactivarRegistro.Name = "btnDesactivarRegistro";
            this.btnDesactivarRegistro.Size = new System.Drawing.Size(203, 36);
            this.btnDesactivarRegistro.Text = "Desactivar Registro";
            this.btnDesactivarRegistro.Click += new System.EventHandler(this.btnDesactivarRegistro_Click_1);
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.Enabled = false;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelarRegistro.Image")));
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(116, 36);
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // btnGuardarRegistro
            // 
            this.btnGuardarRegistro.Enabled = false;
            this.btnGuardarRegistro.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnGuardarRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardarRegistro.Image")));
            this.btnGuardarRegistro.Name = "btnGuardarRegistro";
            this.btnGuardarRegistro.Size = new System.Drawing.Size(112, 36);
            this.btnGuardarRegistro.Text = "Guardar";
            this.btnGuardarRegistro.Click += new System.EventHandler(this.btnGuardarRegistro_Click);
            // 
            // btnNuevoRegistro
            // 
            this.btnNuevoRegistro.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoRegistro.ForeColor = System.Drawing.Color.White;
            this.btnNuevoRegistro.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoRegistro.Image")));
            this.btnNuevoRegistro.Name = "btnNuevoRegistro";
            this.btnNuevoRegistro.Size = new System.Drawing.Size(100, 36);
            this.btnNuevoRegistro.Text = "Nuevo";
            this.btnNuevoRegistro.Click += new System.EventHandler(this.btnNuevoRegistro_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoRegistro,
            this.btnGuardarRegistro,
            this.btnCancelarRegistro,
            this.btnDesactivarRegistro,
            this.btnReactivarRegistro,
            this.btnActualizarDGV,
            this.btnTestConexion,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1304, 40);
            this.menuStrip1.TabIndex = 36;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BorderRadius = 10;
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.cmbCargo);
            this.guna2Panel2.Controls.Add(this.txtDNI);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.txtApellido);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.txtNombre);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.txtIdEmpleado);
            this.guna2Panel2.Controls.Add(this.lblEstado);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel2.Location = new System.Drawing.Point(16, 79);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(417, 519);
            this.guna2Panel2.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 294);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 20);
            this.label7.TabIndex = 81;
            this.label7.Text = "Cargo";
            // 
            // cmbCargo
            // 
            this.cmbCargo.BackColor = System.Drawing.Color.Transparent;
            this.cmbCargo.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cmbCargo.BorderRadius = 8;
            this.cmbCargo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCargo.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCargo.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCargo.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCargo.ForeColor = System.Drawing.Color.Gray;
            this.cmbCargo.ItemHeight = 30;
            this.cmbCargo.Location = new System.Drawing.Point(34, 317);
            this.cmbCargo.Name = "cmbCargo";
            this.cmbCargo.Size = new System.Drawing.Size(292, 36);
            this.cmbCargo.TabIndex = 80;
            // 
            // txtDNI
            // 
            this.txtDNI.BackColor = System.Drawing.Color.Transparent;
            this.txtDNI.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtDNI.BorderRadius = 8;
            this.txtDNI.BorderThickness = 0;
            this.txtDNI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDNI.DefaultText = "";
            this.txtDNI.Enabled = false;
            this.txtDNI.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDNI.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtDNI.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDNI.ForeColor = System.Drawing.Color.Gray;
            this.txtDNI.Location = new System.Drawing.Point(33, 388);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(5);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.PlaceholderText = "";
            this.txtDNI.SelectedText = "";
            this.txtDNI.Size = new System.Drawing.Size(293, 33);
            this.txtDNI.TabIndex = 79;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(28, 364);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 78;
            this.label6.Text = "DNI";
            // 
            // txtApellido
            // 
            this.txtApellido.BackColor = System.Drawing.Color.Transparent;
            this.txtApellido.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtApellido.BorderRadius = 8;
            this.txtApellido.BorderThickness = 0;
            this.txtApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtApellido.DefaultText = "";
            this.txtApellido.Enabled = false;
            this.txtApellido.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtApellido.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtApellido.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtApellido.ForeColor = System.Drawing.Color.Gray;
            this.txtApellido.Location = new System.Drawing.Point(33, 248);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.PlaceholderText = "";
            this.txtApellido.SelectedText = "";
            this.txtApellido.Size = new System.Drawing.Size(293, 33);
            this.txtApellido.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(28, 224);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(61, 23);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(257, 36);
            this.label4.TabIndex = 66;
            this.label4.Text = "Datos Empleados";
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.Transparent;
            this.txtNombre.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtNombre.BorderRadius = 8;
            this.txtNombre.BorderThickness = 0;
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.DefaultText = "";
            this.txtNombre.Enabled = false;
            this.txtNombre.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtNombre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtNombre.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtNombre.ForeColor = System.Drawing.Color.Gray;
            this.txtNombre.Location = new System.Drawing.Point(33, 177);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "";
            this.txtNombre.SelectedText = "";
            this.txtNombre.Size = new System.Drawing.Size(293, 33);
            this.txtNombre.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(28, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 74;
            this.label2.Text = "Nombre";
            // 
            // txtIdEmpleado
            // 
            this.txtIdEmpleado.BackColor = System.Drawing.Color.Transparent;
            this.txtIdEmpleado.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtIdEmpleado.BorderRadius = 8;
            this.txtIdEmpleado.BorderThickness = 0;
            this.txtIdEmpleado.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEmpleado.DefaultText = "0";
            this.txtIdEmpleado.Enabled = false;
            this.txtIdEmpleado.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtIdEmpleado.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtIdEmpleado.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtIdEmpleado.ForeColor = System.Drawing.Color.Gray;
            this.txtIdEmpleado.Location = new System.Drawing.Point(33, 106);
            this.txtIdEmpleado.Margin = new System.Windows.Forms.Padding(5);
            this.txtIdEmpleado.Name = "txtIdEmpleado";
            this.txtIdEmpleado.PlaceholderText = "";
            this.txtIdEmpleado.SelectedText = "";
            this.txtIdEmpleado.Size = new System.Drawing.Size(144, 33);
            this.txtIdEmpleado.TabIndex = 73;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.BackColor = System.Drawing.Color.Transparent;
            this.lblEstado.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.ForeColor = System.Drawing.Color.White;
            this.lblEstado.Location = new System.Drawing.Point(201, 110);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(61, 29);
            this.lblEstado.TabIndex = 72;
            this.lblEstado.Text = "Estado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 67;
            this.label1.Text = "IdEmpleado";
            // 
            // lblOperacion
            // 
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.BackColor = System.Drawing.Color.Transparent;
            this.lblOperacion.Font = new System.Drawing.Font("Dubai", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOperacion.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblOperacion.Location = new System.Drawing.Point(27, 49);
            this.lblOperacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(87, 29);
            this.lblOperacion.TabIndex = 73;
            this.lblOperacion.Text = "Operacion";
            this.lblOperacion.Visible = false;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.txtFiltrar);
            this.guna2Panel1.Controls.Add(this.dgvDatos);
            this.guna2Panel1.Controls.Add(this.rbDatosInactivos);
            this.guna2Panel1.Controls.Add(this.rbDatosActivos);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.FillColor = System.Drawing.SystemColors.Highlight;
            this.guna2Panel1.Location = new System.Drawing.Point(462, 82);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(814, 516);
            this.guna2Panel1.TabIndex = 74;
            // 
            // txtFiltrar
            // 
            this.txtFiltrar.BackColor = System.Drawing.Color.Transparent;
            this.txtFiltrar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtFiltrar.BorderRadius = 8;
            this.txtFiltrar.BorderThickness = 0;
            this.txtFiltrar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFiltrar.DefaultText = "";
            this.txtFiltrar.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFiltrar.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtFiltrar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtFiltrar.ForeColor = System.Drawing.Color.Gray;
            this.txtFiltrar.Location = new System.Drawing.Point(77, 25);
            this.txtFiltrar.Margin = new System.Windows.Forms.Padding(5);
            this.txtFiltrar.Name = "txtFiltrar";
            this.txtFiltrar.PlaceholderText = "";
            this.txtFiltrar.SelectedText = "";
            this.txtFiltrar.Size = new System.Drawing.Size(321, 33);
            this.txtFiltrar.TabIndex = 78;
            this.txtFiltrar.TextChanged += new System.EventHandler(this.txtFiltrar_TextChanged);
            // 
            // dgvDatos
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SkyBlue;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDatos.BackgroundColor = System.Drawing.Color.White;
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(23, 66);
            this.dgvDatos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.ReadOnly = true;
            this.dgvDatos.RowHeadersWidth = 51;
            this.dgvDatos.Size = new System.Drawing.Size(769, 431);
            this.dgvDatos.TabIndex = 56;
            this.dgvDatos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatos_CellDoubleClick);
            // 
            // rbDatosInactivos
            // 
            this.rbDatosInactivos.AutoSize = true;
            this.rbDatosInactivos.BackColor = System.Drawing.Color.Transparent;
            this.rbDatosInactivos.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDatosInactivos.ForeColor = System.Drawing.Color.White;
            this.rbDatosInactivos.Location = new System.Drawing.Point(592, 28);
            this.rbDatosInactivos.Margin = new System.Windows.Forms.Padding(4);
            this.rbDatosInactivos.Name = "rbDatosInactivos";
            this.rbDatosInactivos.Size = new System.Drawing.Size(179, 24);
            this.rbDatosInactivos.TabIndex = 61;
            this.rbDatosInactivos.TabStop = true;
            this.rbDatosInactivos.Text = "Registros Inactivos";
            this.rbDatosInactivos.UseVisualStyleBackColor = false;
            this.rbDatosInactivos.CheckedChanged += new System.EventHandler(this.rbDatosInactivos_CheckedChanged);
            // 
            // rbDatosActivos
            // 
            this.rbDatosActivos.AutoSize = true;
            this.rbDatosActivos.BackColor = System.Drawing.Color.Transparent;
            this.rbDatosActivos.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDatosActivos.ForeColor = System.Drawing.Color.White;
            this.rbDatosActivos.Location = new System.Drawing.Point(408, 28);
            this.rbDatosActivos.Margin = new System.Windows.Forms.Padding(4);
            this.rbDatosActivos.Name = "rbDatosActivos";
            this.rbDatosActivos.Size = new System.Drawing.Size(167, 24);
            this.rbDatosActivos.TabIndex = 60;
            this.rbDatosActivos.TabStop = true;
            this.rbDatosActivos.Text = "Registros Activos";
            this.rbDatosActivos.UseVisualStyleBackColor = false;
            this.rbDatosActivos.CheckedChanged += new System.EventHandler(this.rbDatosActivos_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(19, 30);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 20);
            this.label5.TabIndex = 58;
            this.label5.Text = "Filtrar";
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // FormEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 617);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.lblOperacion);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEmpleado";
            this.Text = "FormEmpleado";
            this.Load += new System.EventHandler(this.FormEmpleado_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.ToolStripMenuItem btnTestConexion;
        private System.Windows.Forms.ToolStripMenuItem btnActualizarDGV;
        private System.Windows.Forms.ToolStripMenuItem btnReactivarRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnDesactivarRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnCancelarRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnGuardarRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnNuevoRegistro;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtIdEmpleado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperacion;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtFiltrar;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.RadioButton rbDatosInactivos;
        private System.Windows.Forms.RadioButton rbDatosActivos;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtApellido;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtDNI;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ResizeForm guna2ResizeForm1;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCargo;
        private System.Windows.Forms.Label label7;
    }
}