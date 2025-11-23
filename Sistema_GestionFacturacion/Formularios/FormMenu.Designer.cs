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
            this.panelContenido = new Guna.UI2.WinForms.Guna2Panel();
            this.btnHistorialFacturas = new Guna.UI2.WinForms.Guna2Button();
            this.btnHistorialPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btnProductos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCargos = new Guna.UI2.WinForms.Guna2Button();
            this.btnCategorias = new Guna.UI2.WinForms.Guna2Button();
            this.btnDescuento = new Guna.UI2.WinForms.Guna2Button();
            this.btnEmpleado = new Guna.UI2.WinForms.Guna2Button();
            this.btnPedidos = new Guna.UI2.WinForms.Guna2Button();
            this.btnRoles = new Guna.UI2.WinForms.Guna2Button();
            this.btnUsuarios = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            this.panelContenido.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHeader.BorderThickness = 2;
            this.panelHeader.Controls.Add(this.lblBienvenida);
            this.panelHeader.Controls.Add(this.lblUsuario);
            this.panelHeader.Controls.Add(this.btnRegresar);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.ShadowDecoration.Depth = 8;
            this.panelHeader.Size = new System.Drawing.Size(1119, 100);
            this.panelHeader.TabIndex = 0;
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblBienvenida.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBienvenida.Location = new System.Drawing.Point(20, 12);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(106, 40);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "Menú";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(26, 61);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(92, 26);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.DimGray;
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
            this.btnRegresar.Location = new System.Drawing.Point(809, 30);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(161, 40);
            this.btnRegresar.TabIndex = 2;
            this.btnRegresar.Text = "REGRESAR";
            this.btnRegresar.TextOffset = new System.Drawing.Point(0, -2);
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // panelContenido
            // 
            this.panelContenido.AutoScroll = true;
            this.panelContenido.Controls.Add(this.btnHistorialFacturas);
            this.panelContenido.Controls.Add(this.btnHistorialPedidos);
            this.panelContenido.Controls.Add(this.btnProductos);
            this.panelContenido.Controls.Add(this.btnCargos);
            this.panelContenido.Controls.Add(this.btnCategorias);
            this.panelContenido.Controls.Add(this.btnDescuento);
            this.panelContenido.Controls.Add(this.btnEmpleado);
            this.panelContenido.Controls.Add(this.btnPedidos);
            this.panelContenido.Controls.Add(this.btnRoles);
            this.panelContenido.Controls.Add(this.btnUsuarios);
            this.panelContenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenido.FillColor = System.Drawing.Color.Silver;
            this.panelContenido.Location = new System.Drawing.Point(0, 100);
            this.panelContenido.Name = "panelContenido";
            this.panelContenido.Size = new System.Drawing.Size(1119, 600);
            this.panelContenido.TabIndex = 1;
            this.panelContenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenido_Paint);
            // 
            // btnHistorialFacturas
            // 
            this.btnHistorialFacturas.BorderRadius = 12;
            this.btnHistorialFacturas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialFacturas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialFacturas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialFacturas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorialFacturas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistorialFacturas.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(57)))), ((int)(((byte)(53)))));
            this.btnHistorialFacturas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnHistorialFacturas.ForeColor = System.Drawing.Color.White;
            this.btnHistorialFacturas.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnHistorialFacturas.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialFacturas.Image")));
            this.btnHistorialFacturas.ImageSize = new System.Drawing.Size(35, 35);
            this.btnHistorialFacturas.Location = new System.Drawing.Point(863, 20);
            this.btnHistorialFacturas.Name = "btnHistorialFacturas";
            this.btnHistorialFacturas.Size = new System.Drawing.Size(220, 140);
            this.btnHistorialFacturas.TabIndex = 9;
            this.btnHistorialFacturas.Text = "HISTORIAL FACTURAS";
            this.btnHistorialFacturas.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // btnHistorialPedidos
            // 
            this.btnHistorialPedidos.BorderRadius = 12;
            this.btnHistorialPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHistorialPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnHistorialPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnHistorialPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnHistorialPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnHistorialPedidos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnHistorialPedidos.ForeColor = System.Drawing.Color.White;
            this.btnHistorialPedidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnHistorialPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialPedidos.Image")));
            this.btnHistorialPedidos.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnHistorialPedidos.ImageSize = new System.Drawing.Size(30, 30);
            this.btnHistorialPedidos.Location = new System.Drawing.Point(863, 190);
            this.btnHistorialPedidos.Name = "btnHistorialPedidos";
            this.btnHistorialPedidos.Size = new System.Drawing.Size(220, 140);
            this.btnHistorialPedidos.TabIndex = 8;
            this.btnHistorialPedidos.Text = "HISTORIAL PEDIDOS";
            this.btnHistorialPedidos.TextOffset = new System.Drawing.Point(0, 10);
            // 
            // btnProductos
            // 
            this.btnProductos.BorderRadius = 12;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProductos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProductos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProductos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnProductos.ForeColor = System.Drawing.Color.White;
            this.btnProductos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnProductos.Image = ((System.Drawing.Image)(resources.GetObject("btnProductos.Image")));
            this.btnProductos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnProductos.Location = new System.Drawing.Point(305, 360);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(220, 140);
            this.btnProductos.TabIndex = 7;
            this.btnProductos.Text = "PRODUCTOS";
            // 
            // btnCargos
            // 
            this.btnCargos.BorderRadius = 12;
            this.btnCargos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCargos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCargos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCargos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCargos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnCargos.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnCargos.ForeColor = System.Drawing.Color.White;
            this.btnCargos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(118)))), ((int)(((byte)(210)))));
            this.btnCargos.Image = ((System.Drawing.Image)(resources.GetObject("btnCargos.Image")));
            this.btnCargos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCargos.Location = new System.Drawing.Point(30, 20);
            this.btnCargos.Name = "btnCargos";
            this.btnCargos.Size = new System.Drawing.Size(220, 140);
            this.btnCargos.TabIndex = 0;
            this.btnCargos.Text = "CARGOS";
            this.btnCargos.Click += new System.EventHandler(this.btnCargos_Click);
            // 
            // btnCategorias
            // 
            this.btnCategorias.BorderRadius = 12;
            this.btnCategorias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategorias.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCategorias.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCategorias.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCategorias.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            this.btnCategorias.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnCategorias.ForeColor = System.Drawing.Color.White;
            this.btnCategorias.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(31)))), ((int)(((byte)(162)))));
            this.btnCategorias.Image = ((System.Drawing.Image)(resources.GetObject("btnCategorias.Image")));
            this.btnCategorias.ImageSize = new System.Drawing.Size(35, 35);
            this.btnCategorias.Location = new System.Drawing.Point(305, 20);
            this.btnCategorias.Name = "btnCategorias";
            this.btnCategorias.Size = new System.Drawing.Size(220, 140);
            this.btnCategorias.TabIndex = 4;
            this.btnCategorias.Text = "CATEGORÍAS";
            this.btnCategorias.Click += new System.EventHandler(this.btnCategorias_Click);
            // 
            // btnDescuento
            // 
            this.btnDescuento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDescuento.BorderRadius = 12;
            this.btnDescuento.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDescuento.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDescuento.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDescuento.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDescuento.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDescuento.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.btnDescuento.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnDescuento.ForeColor = System.Drawing.Color.White;
            this.btnDescuento.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(24)))), ((int)(((byte)(91)))));
            this.btnDescuento.Image = ((System.Drawing.Image)(resources.GetObject("btnDescuento.Image")));
            this.btnDescuento.ImageSize = new System.Drawing.Size(35, 35);
            this.btnDescuento.Location = new System.Drawing.Point(591, 20);
            this.btnDescuento.Name = "btnDescuento";
            this.btnDescuento.Size = new System.Drawing.Size(220, 140);
            this.btnDescuento.TabIndex = 3;
            this.btnDescuento.Text = "DESCUENTO";
            this.btnDescuento.Click += new System.EventHandler(this.btnDescuento_Click);
            // 
            // btnEmpleado
            // 
            this.btnEmpleado.BorderRadius = 12;
            this.btnEmpleado.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmpleado.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleado.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmpleado.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmpleado.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmpleado.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnEmpleado.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnEmpleado.ForeColor = System.Drawing.Color.White;
            this.btnEmpleado.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(142)))), ((int)(((byte)(60)))));
            this.btnEmpleado.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleado.Image")));
            this.btnEmpleado.ImageSize = new System.Drawing.Size(35, 35);
            this.btnEmpleado.Location = new System.Drawing.Point(30, 190);
            this.btnEmpleado.Name = "btnEmpleado";
            this.btnEmpleado.Size = new System.Drawing.Size(220, 140);
            this.btnEmpleado.TabIndex = 2;
            this.btnEmpleado.Text = "EMPLEADOS";
            this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BorderRadius = 5;
            this.btnPedidos.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnPedidos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPedidos.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPedidos.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPedidos.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPedidos.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.btnPedidos.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnPedidos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.btnPedidos.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(179)))), ((int)(((byte)(0)))));
            this.btnPedidos.Image = ((System.Drawing.Image)(resources.GetObject("btnPedidos.Image")));
            this.btnPedidos.ImageSize = new System.Drawing.Size(35, 35);
            this.btnPedidos.Location = new System.Drawing.Point(305, 190);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(220, 140);
            this.btnPedidos.TabIndex = 1;
            this.btnPedidos.Text = "PEDIDOS";
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnRoles
            // 
            this.btnRoles.BorderRadius = 12;
            this.btnRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRoles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRoles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRoles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.btnRoles.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnRoles.ForeColor = System.Drawing.Color.White;
            this.btnRoles.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(127)))), ((int)(((byte)(23)))));
            this.btnRoles.Image = ((System.Drawing.Image)(resources.GetObject("btnRoles.Image")));
            this.btnRoles.ImageSize = new System.Drawing.Size(35, 35);
            this.btnRoles.Location = new System.Drawing.Point(591, 190);
            this.btnRoles.Name = "btnRoles";
            this.btnRoles.Size = new System.Drawing.Size(220, 140);
            this.btnRoles.TabIndex = 5;
            this.btnRoles.Text = "ROLES";
            this.btnRoles.Click += new System.EventHandler(this.btnRoles_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BorderRadius = 12;
            this.btnUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUsuarios.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUsuarios.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUsuarios.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUsuarios.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.btnUsuarios.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Bold);
            this.btnUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnUsuarios.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(63)))), ((int)(((byte)(159)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageSize = new System.Drawing.Size(35, 35);
            this.btnUsuarios.Location = new System.Drawing.Point(30, 360);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(220, 140);
            this.btnUsuarios.TabIndex = 6;
            this.btnUsuarios.Text = "USUARIOS";
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1119, 700);
            this.Controls.Add(this.panelContenido);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Principal";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelContenido.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Panel panelContenido;    
        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2Button btnRegresar;
        private Guna.UI2.WinForms.Guna2Button btnCargos;
        private Guna.UI2.WinForms.Guna2Button btnPedidos;
        private Guna.UI2.WinForms.Guna2Button btnEmpleado;
        private Guna.UI2.WinForms.Guna2Button btnDescuento;
        private Guna.UI2.WinForms.Guna2Button btnCategorias;
        private Guna.UI2.WinForms.Guna2Button btnRoles;
        private Guna.UI2.WinForms.Guna2Button btnUsuarios;
        private Guna.UI2.WinForms.Guna2Button btnProductos;
        private Guna.UI2.WinForms.Guna2Button btnHistorialPedidos;
        private Guna.UI2.WinForms.Guna2Button btnHistorialFacturas;
    }
}