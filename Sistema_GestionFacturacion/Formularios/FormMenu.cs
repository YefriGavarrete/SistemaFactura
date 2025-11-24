using Sistema_GestionFacturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_GestionFacturacion.Formularios
{
    public partial class FormMenu : Form
    {

        AlertasDelSistema Alertas = new AlertasDelSistema();
        ConsultasSQL Consultas = new ConsultasSQL();
        Conexion conexion = new Conexion();

        int idUsuario;
        string rolUsuario;
        string nombreUsuario;
        string apellidoUsuario;

        public FormMenu()
        {
            InitializeComponent();
            InhabilitarButtons(); 
        }
        public FormMenu(int id, string rol, string nombre, string apellido) : this()
        {
            idUsuario = id;
            rolUsuario = rol ?? string.Empty;
            nombreUsuario = nombre ?? string.Empty;
            apellidoUsuario = apellido ?? string.Empty;
            this.IsMdiContainer = true;
            bienvenidaUsuario(nombre, apellido, rol);
            configuracionRol(rol);
        }

        void Regresar() {
            this.Close();
            var login = new Login();
            login.Closed += (s, args) => this.Close();
            login.Show();
        }

        void bienvenidaUsuario(string nombre, string apellido, string rol)
        {
            try
            {
                var texto = $"Bienvenido {nombre} {apellido}, {rol}".Trim();
                var lbls = this.Controls.Find("lblUsuario", true);
                if (lbls.Length == 0) lbls = this.Controls.Find("lblUsuario", true);
                if (lbls.Length > 0 && lbls[0] is Label lb)
                {
                    lb.Text = texto;
                }
            }
            catch
            {
                // se puede agregar un error en caso de falla
            }
        }
        void configuracionRol(string rol)
        {
            if (string.IsNullOrWhiteSpace(rol))
            {
                InhabilitarButtons();
                return;
            }
            var clave = rol.Trim().ToLowerInvariant();

            if (clave == "administrador" || clave == "admin")
            {
                ConfigurarButtonesAdministrador();
            }
            else
            {
                ConfigurarButtonesEmpleados();
            }
        }
        

        bool InhabilitarButtons()
        {

            //debo de agregar todos los botones para inhabilitarlos para el usuario, no  para el administrador
            btnCargos.Enabled = false;
            btnPedidos.Enabled = false;
            btnEmpleado.Enabled = false;
            btnDescuento.Enabled = false;
            btnCategorias.Enabled = false;
            btnRoles.Enabled = false;
            btnUsuarios.Enabled = false;
            btnProductos.Enabled = false;
            btnHistorialPedidos.Enabled = false;
            btnHistorialFacturas.Enabled = false;
            return true;
        }

        void ConfigurarButtonesAdministrador()
        {
            var adminButtons = new[]
            {
                "btnCargos", "btnPedidos", "btnEmpleado",
                "btnDescuento", "btnCategorias", "btnRoles",
                "btnUsuarios", "btnProductos", "btnHistorialPedidos", "btnHistorialFacturas"
            };
            establecerInhabilitarButtones(adminButtons, true);

        }

        /*
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
         */

        void ConfigurarButtonesEmpleados()
        {
            var empleadosButtons = new[]
            {
                 "btnPedidos", "btnHistorialPedidos", "btnHistorialFacturas, btnProductos"
            };
            InhabilitarButtons();
            establecerInhabilitarButtones(empleadosButtons, true);
        }


  
        void establecerInhabilitarButtones(IEnumerable<string> nombres, bool habilitar = true)
        {
            foreach (var nombre in nombres)
            {
                try
                {
                    var controles = this.Controls.Find(nombre, true);
                    foreach (var ctrl in controles)
                    {
                        if (ctrl is System.Windows.Forms.Button b)
                        {
                            b.Enabled = habilitar;
                            b.Visible = habilitar;
                            continue;
                        }

                        if (ctrl.GetType().FullName == "Guna.UI2.WinForms.Guna2Button")
                        {
                            var enabledProp = ctrl.GetType().GetProperty("Enabled");
                            var visibleProp = ctrl.GetType().GetProperty("Visible");
                            if (enabledProp != null) enabledProp.SetValue(ctrl, habilitar);
                            if (visibleProp != null) visibleProp.SetValue(ctrl, habilitar);
                            continue;
                        }
                        if (ctrl is Control genericCtrl)
                        {
                            genericCtrl.Enabled = habilitar;
                            genericCtrl.Visible = habilitar;
                        }
                    }
                }
                catch
                {
                    //
                }
            }
        }

        void AbrirFormHijo(Form Formulario)
        {
            if (Formulario == null) return;
            var formularioExistente = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f.GetType() == Formulario.GetType());
            if (formularioExistente != null)
            {

                formularioExistente.FormClosed -= CerrarFormHijo;
                formularioExistente.FormClosed += CerrarFormHijo;
                formularioExistente.BringToFront();
                if (formularioExistente.WindowState == FormWindowState.Minimized)
                    formularioExistente.WindowState = FormWindowState.Normal;
                this.Hide();
                formularioExistente.BringToFront(); 
                return;
            }

            Formulario.FormClosed += CerrarFormHijo;
            this.Hide();
            Formulario.StartPosition = FormStartPosition.CenterScreen;
            Formulario.Show();

        }


        void CerrarFormHijo(object sender, FormClosedEventArgs e)
        {
            try
            {
                this.Show();
                // Me muestra el formMenu otra vez.
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.BringToFront();
                }
            }
            catch
            {

            }
        }

        private void btnCargos_Click(object sender, EventArgs e)
        {
            var cargos = new FormCargos();
            AbrirFormHijo(cargos);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            var categorias = new FormCategorias();
            AbrirFormHijo(categorias);
        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {
            var Descuentos = new FormDescuentos();
            AbrirFormHijo(Descuentos);
        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            var empleados = new FormEmpleado();
            AbrirFormHijo(empleados);
        }

        private void btnPedidos_Click(object sender, EventArgs e)
        {

            var pedidos = new FormPedidos(idUsuario, rolUsuario, nombreUsuario, apellidoUsuario);
            AbrirFormHijo(pedidos);
        }

        private void btnRoles_Click(object sender, EventArgs e)
        {
            var roles = new FormRoles();
            AbrirFormHijo(roles);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            var usuarios = new FormUsuariosLogin();
            AbrirFormHijo(usuarios);
        }

        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            /*var productos = new FormProductos();
            AbrirFormHijo(productos);*/
        }
    }
}
