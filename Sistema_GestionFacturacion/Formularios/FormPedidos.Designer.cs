namespace Sistema_GestionFacturacion.Formularios
{
    partial class FormPedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnNuevoPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCrearPedido = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFacturacion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelarRegistro = new System.Windows.Forms.ToolStripMenuItem();
            this.btnTestConexion = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblISV = new System.Windows.Forms.Label();
            this.DGVDatos = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modelo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.txtIdPedido = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtISV = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.BackColor = System.Drawing.Color.PowderBlue;
            this.btnBuscarProductos.FlatAppearance.BorderColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarProductos.FlatAppearance.BorderSize = 2;
            this.btnBuscarProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnBuscarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProductos.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.btnBuscarProductos.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnBuscarProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscarProductos.Image")));
            this.btnBuscarProductos.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarProductos.Location = new System.Drawing.Point(572, 73);
            this.btnBuscarProductos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(124, 123);
            this.btnBuscarProductos.TabIndex = 26;
            this.btnBuscarProductos.Text = "Buscar Producto";
            this.btnBuscarProductos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnBuscarProductos.UseVisualStyleBackColor = false;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.DarkCyan;
            this.menuStrip1.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevoPedido,
            this.btnCrearPedido,
            this.btnFacturacion,
            this.btnCancelarRegistro,
            this.btnTestConexion,
            this.btnSalir});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1471, 40);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnNuevoPedido
            // 
            this.btnNuevoPedido.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoPedido.ForeColor = System.Drawing.Color.White;
            this.btnNuevoPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoPedido.Image")));
            this.btnNuevoPedido.Name = "btnNuevoPedido";
            this.btnNuevoPedido.Size = new System.Drawing.Size(159, 36);
            this.btnNuevoPedido.Text = "Nuevo Pedido";
            this.btnNuevoPedido.Click += new System.EventHandler(this.btnNuevoPedido_Click);
            // 
            // btnCrearPedido
            // 
            this.btnCrearPedido.Enabled = false;
            this.btnCrearPedido.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPedido.ForeColor = System.Drawing.Color.White;
            this.btnCrearPedido.Image = ((System.Drawing.Image)(resources.GetObject("btnCrearPedido.Image")));
            this.btnCrearPedido.Name = "btnCrearPedido";
            this.btnCrearPedido.Size = new System.Drawing.Size(186, 36);
            this.btnCrearPedido.Text = "Comenzar Pedido";
            this.btnCrearPedido.Click += new System.EventHandler(this.btnCrearPedido_Click);
            // 
            // btnFacturacion
            // 
            this.btnFacturacion.Enabled = false;
            this.btnFacturacion.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFacturacion.ForeColor = System.Drawing.Color.White;
            this.btnFacturacion.Image = ((System.Drawing.Image)(resources.GetObject("btnFacturacion.Image")));
            this.btnFacturacion.Name = "btnFacturacion";
            this.btnFacturacion.Size = new System.Drawing.Size(182, 36);
            this.btnFacturacion.Text = "Finalizar Compra";
            this.btnFacturacion.Click += new System.EventHandler(this.btnFacturacion_Click);
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
            // btnTestConexion
            // 
            this.btnTestConexion.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTestConexion.ForeColor = System.Drawing.Color.White;
            this.btnTestConexion.Image = ((System.Drawing.Image)(resources.GetObject("btnTestConexion.Image")));
            this.btnTestConexion.Name = "btnTestConexion";
            this.btnTestConexion.Size = new System.Drawing.Size(162, 36);
            this.btnTestConexion.Text = "Test Conexion";
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Dubai", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(85, 36);
            this.btnSalir.Text = "Salir";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DarkCyan;
            this.panel3.Controls.Add(this.lblISV);
            this.panel3.Controls.Add(this.DGVDatos);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtIdPedido);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.txtSubtotal);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.txtISV);
            this.panel3.Location = new System.Drawing.Point(33, 215);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1408, 359);
            this.panel3.TabIndex = 24;
            // 
            // lblISV
            // 
            this.lblISV.AutoSize = true;
            this.lblISV.Location = new System.Drawing.Point(1308, 289);
            this.lblISV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblISV.Name = "lblISV";
            this.lblISV.Size = new System.Drawing.Size(31, 16);
            this.lblISV.TabIndex = 19;
            this.lblISV.Text = "0.12";
            // 
            // DGVDatos
            // 
            this.DGVDatos.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGVDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.IdProducto,
            this.Codigo,
            this.Categoria,
            this.Marca,
            this.Modelo,
            this.Precio,
            this.Cantidad,
            this.Descuento,
            this.Subtotal,
            this.ISV,
            this.Total});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkCyan;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVDatos.DefaultCellStyle = dataGridViewCellStyle1;
            this.DGVDatos.Location = new System.Drawing.Point(25, 59);
            this.DGVDatos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVDatos.Name = "DGVDatos";
            this.DGVDatos.ReadOnly = true;
            this.DGVDatos.RowHeadersWidth = 51;
            this.DGVDatos.Size = new System.Drawing.Size(1364, 185);
            this.DGVDatos.TabIndex = 2;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "IdPedido";
            this.IdPedido.MinimumWidth = 6;
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Visible = false;
            this.IdPedido.Width = 125;
            // 
            // IdProducto
            // 
            this.IdProducto.HeaderText = "IdProducto";
            this.IdProducto.MinimumWidth = 6;
            this.IdProducto.Name = "IdProducto";
            this.IdProducto.ReadOnly = true;
            this.IdProducto.Visible = false;
            this.IdProducto.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.MinimumWidth = 6;
            this.Categoria.Name = "Categoria";
            this.Categoria.ReadOnly = true;
            this.Categoria.Width = 125;
            // 
            // Marca
            // 
            this.Marca.HeaderText = "Marca";
            this.Marca.MinimumWidth = 6;
            this.Marca.Name = "Marca";
            this.Marca.ReadOnly = true;
            this.Marca.Width = 125;
            // 
            // Modelo
            // 
            this.Modelo.HeaderText = "Modelo";
            this.Modelo.MinimumWidth = 6;
            this.Modelo.Name = "Modelo";
            this.Modelo.ReadOnly = true;
            this.Modelo.Width = 125;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 125;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.ReadOnly = true;
            this.Descuento.Width = 125;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.MinimumWidth = 6;
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            this.Subtotal.Width = 125;
            // 
            // ISV
            // 
            this.ISV.HeaderText = "ISV";
            this.ISV.MinimumWidth = 6;
            this.ISV.Name = "ISV";
            this.ISV.ReadOnly = true;
            this.ISV.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 125;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(532, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(287, 36);
            this.label10.TabIndex = 18;
            this.label10.Text = "Detalles del Pedido";
            // 
            // txtIdPedido
            // 
            this.txtIdPedido.Location = new System.Drawing.Point(25, 30);
            this.txtIdPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdPedido.Name = "txtIdPedido";
            this.txtIdPedido.ReadOnly = true;
            this.txtIdPedido.Size = new System.Drawing.Size(113, 22);
            this.txtIdPedido.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(1152, 257);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 17;
            this.label12.Text = "Subtotal";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1249, 318);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(139, 22);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "00.00";
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Location = new System.Drawing.Point(1249, 254);
            this.txtSubtotal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.ReadOnly = true;
            this.txtSubtotal.Size = new System.Drawing.Size(139, 22);
            this.txtSubtotal.TabIndex = 16;
            this.txtSubtotal.Text = "00.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "N° Pedido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(1195, 289);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 20);
            this.label11.TabIndex = 15;
            this.label11.Text = "ISV";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1179, 321);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total";
            // 
            // txtISV
            // 
            this.txtISV.Location = new System.Drawing.Point(1249, 286);
            this.txtISV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISV.Name = "txtISV";
            this.txtISV.ReadOnly = true;
            this.txtISV.Size = new System.Drawing.Size(49, 22);
            this.txtISV.TabIndex = 14;
            this.txtISV.Text = "12%";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDNI);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(33, 73);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(523, 123);
            this.panel1.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(37, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DNI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellido";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gadugi", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // txtDNI
            // 
            this.txtDNI.Enabled = false;
            this.txtDNI.Location = new System.Drawing.Point(93, 84);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(152, 22);
            this.txtDNI.TabIndex = 3;
            this.txtDNI.Text = "0512000000000";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(93, 52);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(240, 22);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.Text = "Bustillo";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(93, 16);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(240, 22);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Text = "Brayan";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(29, 53);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 27;
            this.lblUsuario.Text = "Usuario";
            // 
            // FormPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1471, 603);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnBuscarProductos);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormPedidos";
            this.Text = "FormPedidos";
            this.Load += new System.EventHandler(this.FormPedidos_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDatos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarProductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnNuevoPedido;
        private System.Windows.Forms.ToolStripMenuItem btnCrearPedido;
        private System.Windows.Forms.ToolStripMenuItem btnFacturacion;
        private System.Windows.Forms.ToolStripMenuItem btnCancelarRegistro;
        private System.Windows.Forms.ToolStripMenuItem btnTestConexion;
        private System.Windows.Forms.ToolStripMenuItem btnSalir;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblISV;
        private System.Windows.Forms.DataGridView DGVDatos;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marca;
        private System.Windows.Forms.DataGridViewTextBoxColumn Modelo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtIdPedido;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtISV;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblUsuario;
    }
}