using System;

namespace Sistema_GestionFacturacion.Formularios
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnRegresar = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoles = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistorialFacturas = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistorialPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargos = new Guna.UI2.WinForms.Guna2Button();
            this.btnDescuento = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHeader.BorderThickness = 2;
            this.panelHeader.Controls.Add(this.guna2PictureBox1);
            this.panelHeader.Controls.Add(this.lblBienvenida);
            this.panelHeader.Controls.Add(this.lblUsuario);
            this.panelHeader.Controls.Add(this.btnRegresar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.SystemColors.Highlight;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.Depth = 8;
            this.panelHeader.Size = new System.Drawing.Size(853, 87);
            this.panelHeader.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienvenida.Font = new System.Drawing.Font("Gadugi", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(123, 13);
            this.lblBienvenida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(95, 35);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Menú";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(126, 48);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(68, 19);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.BorderRadius = 8;
            this.btnRegresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(47)))), ((int)(((byte)(47)))));
            this.btnRegresar.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRegresar.Location = new System.Drawing.Point(682, 22);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(124, 41);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextOffset = new System.Drawing.Point(0, -2);
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BackColor = System.Drawing.Color.White;
            this.btnRoles.BorderRadius = 10;
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoles.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnRoles.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRoles.Location = new System.Drawing.Point(241, 107);
            this.btnRoles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(165, 114);
            this.btnRoles.TabIndex = 15;
            this.btnRoles.Text = "ROLES";
            this.btnRoles.TextOffset = new System.Drawing.Point(0, 10);
            this.btnRoles.Tile = true;
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnHistorialFacturas
            // 
            this.btnHistorialFacturas.BackColor = System.Drawing.Color.White;
            this.btnHistorialFacturas.BorderRadius = 10;
            this.btnHistorialFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialFacturas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialFacturas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialFacturas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorialFacturas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistorialFacturas.FillColor = System.Drawing.Color.Firebrick;
            this.btnHistorialFacturas.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialFacturas.ForeColor = System.Drawing.Color.White;
            this.btnHistorialFacturas.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnHistorialFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialFacturas.Image")));
            this.btnHistorialFacturas.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHistorialFacturas.Location = new System.Drawing.Point(241, 402);
            this.btnHistorialFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorialFacturas.Name = "btnHistorialFacturas";
            this.btnHistorialFacturas.Size = new System.Drawing.Size(165, 114);
            this.btnHistorialFacturas.TabIndex = 19;
            this.btnHistorialFacturas.Text = "HISTORIAL FACTURAS";
            this.btnHistorialFacturas.TextOffset = new System.Drawing.Point(0, 10);
            this.btnHistorialFacturas.Tile = true;
            this.btnHistorialFacturas.Click += new System.EventHandler(this.btnHistorialFacturas_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.BorderRadius = 10;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnUsuarios.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUsuarios.Location = new System.Drawing.Point(449, 107);
            this.btnUsuarios.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(165, 114);
            this.btnUsuarios.TabIndex = 16;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.TextOffset = new System.Drawing.Point(0, 10);
            this.btnUsuarios.Tile = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnHistorialPedidos
            // 
            this.btnHistorialPedidos.BackColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.BorderRadius = 10;
            this.btnHistorialPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorialPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistorialPedidos.FillColor = System.Drawing.Color.Firebrick;
            this.btnHistorialPedidos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHistorialPedidos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.HoverState.FillColor = System.Drawing.Color.OrangeRed;
            this.btnHistorialPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialPedidos.Image")));
            this.btnHistorialPedidos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHistorialPedidos.Location = new System.Drawing.Point(33, 402);
            this.btnHistorialPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnHistorialPedidos.Name = "btnHistorialPedidos";
            this.btnHistorialPedidos.Size = new System.Drawing.Size(165, 114);
            this.btnHistorialPedidos.TabIndex = 18;
            this.btnHistorialPedidos.Text = "HISTORIAL PEDIDOS";
            this.btnHistorialPedidos.TextOffset = new System.Drawing.Point(0, 10);
            this.btnHistorialPedidos.Tile = true;
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.White;
            this.btnPedidos.BorderRadius = 10;
            this.btnPedidos.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnPedidos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold);
            this.btnPedidos.ForeColor = System.Drawing.Color.White;
            this.btnPedidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPedidos.Location = new System.Drawing.Point(658, 258);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(2);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(160, 249);
            this.btnPedidos.TabIndex = 11;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.White;
            this.btnProductos.BorderRadius = 10;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnProductos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProductos.Location = new System.Drawing.Point(445, 258);
            this.btnProductos.Margin = new System.Windows.Forms.Padding(2);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(165, 114);
            this.btnProductos.TabIndex = 17;
            this.btnProductos.Text = "PRODUCTOS";
            this.btnProductos.TextOffset = new System.Drawing.Point(0, 10);
            this.btnProductos.Tile = true;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BackColor = System.Drawing.Color.White;
            this.btnEmpleado.BorderRadius = 10;
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmpleado.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnEmpleado.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEmpleado.Location = new System.Drawing.Point(28, 107);
            this.btnEmpleado.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(165, 114);
            this.btnEmpleado.TabIndex = 12;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.TextOffset = new System.Drawing.Point(0, 10);
            this.btnEmpleado.Tile = true;
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnCargos
            // 
            this.btnCargos.BackColor = System.Drawing.Color.White;
            this.btnCargos.BorderRadius = 10;
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargos.FillColor = System.Drawing.SystemColors.Highlight;
            this.btnCargos.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.HoverState.FillColor = System.Drawing.Color.DarkBlue;
            this.btnCargos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargos.Image")));
            this.btnCargos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCargos.Location = new System.Drawing.Point(653, 107);
            this.btnCargos.Margin = new System.Windows.Forms.Padding(2);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(165, 114);
            this.btnCargos.TabIndex = 10;
            this.btnCargos.Text = "CARGOS";
            this.btnCargos.TextOffset = new System.Drawing.Point(0, 10);
            this.btnCargos.Tile = true;
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click_1);
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackColor = System.Drawing.Color.White;
            this.btnDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDescuento.BorderRadius = 10;
            this.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDescuento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDescuento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDescuento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDescuento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDescuento.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescuento.ForeColor = System.Drawing.Color.White;
            this.btnDescuento.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDescuento.Location = new System.Drawing.Point(241, 258);
            this.btnDescuento.Margin = new System.Windows.Forms.Padding(2);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(165, 114);
            this.btnDescuento.TabIndex = 13;
            this.btnDescuento.Text = "DESCUENTO";
            this.btnDescuento.TextOffset = new System.Drawing.Point(0, 10);
            this.btnDescuento.Tile = true;
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click_1);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BackColor = System.Drawing.Color.White;
            this.btnCategorias.BorderRadius = 10;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCategorias.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.FillColor = System.Drawing.Color.Gold;
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCategorias.Location = new System.Drawing.Point(33, 258);
            this.btnCategorias.Margin = new System.Windows.Forms.Padding(2);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(165, 114);
            this.btnCategorias.TabIndex = 14;
            this.btnCategorias.Text = "CATEGORÍAS";
            this.btnCategorias.TextOffset = new System.Drawing.Point(0, 10);
            this.btnCategorias.Tile = true;
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.BorderRadius = 10;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Gainsboro;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(33, 9);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(85, 69);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 28;
            this.guna2PictureBox1.TabStop = false;
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(433, 377);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(198, 154);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 20;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(853, 538);
            this.Controls.Add(this.guna2CirclePictureBox1);
            this.Controls.Add(this.btnRoles);
            this.Controls.Add(this.btnHistorialFacturas);
            this.Controls.Add(this.btnUsuarios);
            this.Controls.Add(this.btnHistorialPedidos);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnProductos);
            this.Controls.Add(this.btnEmpleado);
            this.Controls.Add(this.btnCargos);
            this.Controls.Add(this.btnDescuento);
            this.Controls.Add(this.btnCategorias);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMenu";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2Button btnRegresar;
        private Guna.UI2.WinForms.Guna2Button btnRoles;
        private Guna.UI2.WinForms.Guna2Button btnHistorialFacturas;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnHistorialPedidos;
        private Guna.UI2.WinForms.Guna2Button btnPedidos;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnCargos;
        private Guna.UI2.WinForms.Guna2Button btnDescuento;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}