namespace Sistema_GestionFacturacion.Formularios
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panelPrincipal = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblSubtitulo = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtUsuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtClave = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnIngresar = new Guna.UI2.WinForms.Guna2Button();
            this.lnkRecuperar = new System.Windows.Forms.LinkLabel();
            this.chkMostrar = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.guna2CirclePictureBox1);
            this.panelPrincipal.Controls.Add(this.chkMostrar);
            this.panelPrincipal.Controls.Add(this.lblTitulo);
            this.panelPrincipal.Controls.Add(this.lblSubtitulo);
            this.panelPrincipal.Controls.Add(this.lblUsuario);
            this.panelPrincipal.Controls.Add(this.txtUsuario);
            this.panelPrincipal.Controls.Add(this.lblClave);
            this.panelPrincipal.Controls.Add(this.txtClave);
            this.panelPrincipal.Controls.Add(this.btnIngresar);
            this.panelPrincipal.Controls.Add(this.lnkRecuperar);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.FillColor = System.Drawing.Color.White;
            this.panelPrincipal.ForeColor = System.Drawing.Color.Black;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(926, 482);
            this.panelPrincipal.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lblTitulo.Location = new System.Drawing.Point(534, 36);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(290, 51);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "BIENVENIDO";
            // 
            // lblSubtitulo
            // 
            this.lblSubtitulo.AutoSize = true;
            this.lblSubtitulo.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.lblSubtitulo.Location = new System.Drawing.Point(567, 86);
            this.lblSubtitulo.Name = "lblSubtitulo";
            this.lblSubtitulo.Size = new System.Drawing.Size(209, 26);
            this.lblSubtitulo.TabIndex = 2;
            this.lblSubtitulo.Text = "Gestor de Facturas";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblUsuario.Location = new System.Drawing.Point(453, 150);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(82, 22);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            this.txtUsuario.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtUsuario.BorderRadius = 8;
            this.txtUsuario.BorderThickness = 2;
            this.txtUsuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsuario.DefaultText = "bbustillo";
            this.txtUsuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtUsuario.Font = new System.Drawing.Font("Arial", 11F);
            this.txtUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtUsuario.Location = new System.Drawing.Point(453, 177);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PlaceholderText = "Ingresa tu usuario";
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(423, 47);
            this.txtUsuario.TabIndex = 4;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lblClave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.lblClave.Location = new System.Drawing.Point(453, 239);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(118, 22);
            this.lblClave.TabIndex = 5;
            this.lblClave.Text = "Contraseña";
            // 
            // txtClave
            // 
            this.txtClave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.txtClave.BorderRadius = 8;
            this.txtClave.BorderThickness = 2;
            this.txtClave.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtClave.DefaultText = "admin123";
            this.txtClave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.txtClave.Font = new System.Drawing.Font("Arial", 11F);
            this.txtClave.ForeColor = System.Drawing.Color.Black;
            this.txtClave.Location = new System.Drawing.Point(453, 268);
            this.txtClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtClave.Name = "txtClave";
            this.txtClave.PlaceholderText = "Ingresa tu contraseña";
            this.txtClave.SelectedText = "";
            this.txtClave.Size = new System.Drawing.Size(423, 47);
            this.txtClave.TabIndex = 6;
            this.txtClave.UseSystemPasswordChar = true;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BorderRadius = 8;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnIngresar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(110)))));
            this.btnIngresar.Location = new System.Drawing.Point(453, 356);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(423, 50);
            this.btnIngresar.TabIndex = 7;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lnkRecuperar
            // 
            this.lnkRecuperar.Font = new System.Drawing.Font("Arial", 9F);
            this.lnkRecuperar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.lnkRecuperar.Location = new System.Drawing.Point(569, 422);
            this.lnkRecuperar.Name = "lnkRecuperar";
            this.lnkRecuperar.Size = new System.Drawing.Size(260, 20);
            this.lnkRecuperar.TabIndex = 8;
            this.lnkRecuperar.TabStop = true;
            this.lnkRecuperar.Text = "¿Olvidaste tu contraseña?";
            this.lnkRecuperar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkRecuperar_LinkClicked);
            // 
            // chkMostrar
            // 
            this.chkMostrar.AutoSize = true;
            this.chkMostrar.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMostrar.CheckedState.BorderRadius = 0;
            this.chkMostrar.CheckedState.BorderThickness = 0;
            this.chkMostrar.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chkMostrar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkMostrar.Location = new System.Drawing.Point(753, 328);
            this.chkMostrar.Name = "chkMostrar";
            this.chkMostrar.Size = new System.Drawing.Size(171, 22);
            this.chkMostrar.TabIndex = 9;
            this.chkMostrar.Text = "Mostrar Contraseña";
            this.chkMostrar.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMostrar.UncheckedState.BorderRadius = 0;
            this.chkMostrar.UncheckedState.BorderThickness = 0;
            this.chkMostrar.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chkMostrar.CheckedChanged += new System.EventHandler(this.chkMostrar_CheckedChanged);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CirclePictureBox1.Image")));
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(13, 25);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(400, 400);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2CirclePictureBox1.TabIndex = 10;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(926, 482);
            this.Controls.Add(this.panelPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BillManager";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelPrincipal;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblSubtitulo;
        private System.Windows.Forms.Label lblUsuario;
        private Guna.UI2.WinForms.Guna2TextBox txtUsuario;
        private System.Windows.Forms.Label lblClave;
        private Guna.UI2.WinForms.Guna2TextBox txtClave;
        private Guna.UI2.WinForms.Guna2Button btnIngresar;
        private System.Windows.Forms.LinkLabel lnkRecuperar;
        private Guna.UI2.WinForms.Guna2CheckBox chkMostrar;
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
    }
}