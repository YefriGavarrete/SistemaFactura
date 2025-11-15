using Sistema_GestionFacturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_GestionFacturacion.Formularios
{
    public partial class FormPedidos : Form
    {
        ConsultasSQL consultas = new ConsultasSQL();
        AlertasDelSistema Alertas = new AlertasDelSistema();

        int IdUsuario;
        string rolUsario;
        string UsuarioNombre;
        string UsuarioApellido;

        public FormPedidos(int id, string rol, string nombre, string apellido)
        {
            IdUsuario = id;
            rolUsario = rol ?? string.Empty;
            UsuarioNombre = nombre ?? string.Empty;
            UsuarioApellido = apellido ?? string.Empty;
            InitializeComponent();
            MostrarEmpleado();

            btnBuscarProductos.Enabled = false;
        }

        private void MostrarEmpleado()
        {
            //lblUsuario.Text = $"Empleado: {EmpleadoNombre} {EmpleadoApellido}";
            var texto = $"Usuario: {UsuarioNombre} {UsuarioApellido}, {rolUsario}".Trim();
            lblUsuario.Text = texto;
        }

        //LOGICA PEDIDOS

        // metodo para agregar productos al datagridview
        public void AgregarProducto(string idproducto, string codigo, string categoria, string marca, string modelo, string precio, string cantidad, string descuento)
        {
            try
            {
                int idPedido = int.Parse(txtIdPedido.Text);

                // Convertir valores numéricos
                decimal precioUnitario = decimal.Parse(precio);
                int cantidadProducto = int.Parse(cantidad);
                decimal porcentajeDescuento = 0;

                // Intentar convertir el descuento a decimal
                decimal.TryParse(descuento, out porcentajeDescuento);

                // Calcular subtotal (precio × cantidad)
                decimal subtotal = precioUnitario * cantidadProducto;

                // Calcular monto del descuento
                decimal montoDescuento = subtotal * (porcentajeDescuento / 100);

                // Calcular ISV (12% del subtotal)
                decimal isv = subtotal * 0.12m;

                // Calcular total final
                decimal total = subtotal - montoDescuento + isv;

                // Agregar fila al DataGridView
                DGVDatos.Rows.Add(
                    idPedido,
                    idproducto,
                    codigo,
                    categoria,
                    marca,
                    modelo,
                    precioUnitario.ToString("N2"),
                    cantidadProducto,
                    porcentajeDescuento,
                    subtotal.ToString("N2"),
                    isv.ToString("N2"),
                    total.ToString("N2")
                );
                ActualizarTotales();

                //logica para verificar si el datagridview tiene filas
                if (DGVDatos.Rows.Count > 0)
                {
                    btnFacturacion.Enabled = true;
                }
                else
                    btnFacturacion.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // metodo para actualizar los totales del pedido
        void ActualizarTotales()
        {
            decimal subtotal = 0;
            decimal isv = 0;
            decimal total = subtotal;

            foreach (DataGridViewRow fila in DGVDatos.Rows)
            {
                subtotal += Convert.ToDecimal(fila.Cells["Subtotal"].Value);
            }

            isv = subtotal * 0.12m; // 12% de ISV
            total = subtotal + isv;

            txtSubtotal.Text = subtotal.ToString();
            txtTotal.Text = total.ToString();

            //txtSubtotal.Text = $"{subtotal:C4}";
            //txtTotal.Text = $"{total:C4}";
        }


        //  metodo para crear un nuevo pedido y obtener su IdPedido
        void CrearPedido()
        {
            string nombre = txtNombre.Text.Trim();
            string apellido = txtApellido.Text.Trim();
            string dni = txtDNI.Text.Trim();
            string estado = "Pendiente";
            string montopagado = txtTotal.Text.Trim();
            string metodopago = "Pendiente";
            int idEmpleado = IdUsuario;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni))
            {
                Alertas.Advertencia("Por favor, complete los datos del cliente.");
                return;
            }

            DateTime Fecha = DateTime.Now;
            string fechaSQL = "yyyy-MM-dd HH:mm:ss";
            string fecha = Fecha.ToString(fechaSQL);

            string columnas = "NombreCliente, ApellidoCliente, DNI, Fecha, IdEmpleado, NombreEmpleado, ApellidoEmpleado, Estado, MetodoPago, MontoPagado";
            string valores = $"'{nombre}', '{apellido}', '{dni.ToString()}','{fecha}', '{idEmpleado}', '{UsuarioNombre}', '{UsuarioApellido}', '{estado}', '{metodopago}', '{montopagado}'";
                                                                                    //Nombre y Apellido del empleado que crea el pedido
            if (consultas.Guardar("Pedidos", columnas, valores))
            {
                // Obtener el IdPedido recién insertado
                DataTable dt = consultas.Buscar("Pedidos", "MAX(IdPedido) AS IdPedido");
                int idPedido = Convert.ToInt32(dt.Rows[0]["IdPedido"]);

                // Mostrar IdPedido en el TextBox
                txtIdPedido.Text = idPedido.ToString();

                Alertas.Realizado($"En este momento esta creando un pedido a nombre de: '{nombre} {apellido}' - Numero de pedido: #{idPedido}");
                
                btnCrearPedido.Enabled = false;
                btnBuscarProductos.Enabled = true;
            }
            else
            {
                Alertas.Advertencia("Error al crear el pedido");
                btnCrearPedido.Enabled = true;
                btnBuscarProductos.Enabled = false;
            }
        }

        // metodo para guardar dellates pedidos y actualizar tabla pedido con el monto total
        void GuardarDetallesPedido()
        {
            if (string.IsNullOrEmpty(txtIdPedido.Text))
            {
                Alertas.Advertencia("No hay un pedido seleccionado o creado.");
                return;
            }

            int idPedido = Convert.ToInt32(txtIdPedido.Text);

            if (DGVDatos.Rows.Count == 0)
            {
                Alertas.Advertencia("No hay productos en el pedido.");
                return;
            }

            bool exito = true;

            foreach (DataGridViewRow fila in DGVDatos.Rows)
            {
                if (fila.IsNewRow) continue; // evita fila vacía

                int idProducto = Convert.ToInt32(fila.Cells["IdProducto"].Value);
                string categoria = Convert.ToString(fila.Cells["Categoria"].Value);
                string marca = Convert.ToString(fila.Cells["Marca"].Value);
                string modelo = Convert.ToString(fila.Cells["Modelo"].Value);
                decimal precio = Convert.ToDecimal(fila.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                decimal descuento = Convert.ToDecimal(fila.Cells["Descuento"].Value);
                decimal subtotal = Convert.ToDecimal(fila.Cells["Subtotal"].Value);
                decimal isv = Convert.ToDecimal(fila.Cells["ISV"].Value);
                decimal total = Convert.ToDecimal(fila.Cells["Total"].Value);

                string columnas = "IdPedido, IdProducto, Categoria, Marca, Modelo, Precio, Cantidad, Descuento, Subtotal, ISV, Total";
                string valores = $"'{idPedido}', '{idProducto}', '{categoria}', '{marca}', '{modelo}', '{precio}', '{cantidad}', '{descuento}', '{subtotal}', '{isv}', '{total}'";

                if (!consultas.Guardar("DetallesPedidos", columnas, valores))
                {
                    exito = false;
                    break;
                }
            }

            if (exito)
            {
                Alertas.Realizado("Pedido creado exitosamente.");

                // Limpiar el formulario para un nuevo pedido
                actualizarPedido();
                RestarStockProducto();
                LimpiarFormulario();
            }
            else
            {
                Alertas.Advertencia("Ocurrió un error al guardar los productos del pedido.");
            }
        }

        // metodo para actualizar el estado y monto del pedido facturado
        void actualizarPedido()
        {
            try
            {
                string estado = "Facturado";
                decimal montopagado = decimal.Parse(txtTotal.Text);
                string metodopago = "Efectivo";
                string actualizar = $"Estado = '{estado}', MetodoPago = '{metodopago}', MontoPagado = '{montopagado}'";

                string condicion = $"IdPedido='{txtIdPedido.Text}'";

                consultas.update("Pedidos", actualizar, condicion);
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al actualizar usuario: {ex.Message}");
            }
        }

        // metodo para restar el stock de los productos vendidos
        void RestarStockProducto()
        {
            try
            {
                foreach (DataGridViewRow fila in DGVDatos.Rows)
                {
                    int cantidad = Convert.ToInt32(fila.Cells["Cantidad"].Value);
                    int productoid = Convert.ToInt32(fila.Cells["IdProducto"].Value);

                    string actualizar = $"Stock = Stock - {cantidad}";
                    string condicion = $"IdProducto = {productoid}";

                    consultas.update("Productos", actualizar, condicion);
                }
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al actualizar el stock: {ex.Message}");
            }
        }

        void LimpiarFormulario()
        {
            DGVDatos.Rows.Clear();

            txtIdPedido.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtSubtotal.Text = "00.00";
            txtTotal.Text = "00.00";

            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            txtDNI.Enabled = false;

            btnNuevoPedido.Enabled = true;
            btnBuscarProductos.Enabled = false;
            btnCrearPedido.Enabled = false;
            btnCancelarRegistro.Enabled = false;
            btnFacturacion.Enabled = false;
            btnSalir.Enabled = true;
        }

        private void btnNuevoPedido_Click(object sender, EventArgs e)
        {
            btnNuevoPedido.Enabled = false;
            btnSalir.Enabled = false;
            btnCrearPedido.Enabled = true;
            btnCancelarRegistro.Enabled = true;
            btnFacturacion.Enabled = false;
            btnBuscarProductos.Enabled = false;

            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtDNI.Enabled = true;
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            FormBuscarProductos frm = new FormBuscarProductos();
            frm.ShowDialog();
        }

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
           /*int idPedido= int.Parse(txtIdPedido.Text);
             string NombrePedidoCliente= txtNombre.Text;
             string ApellidoPedidoCliente = txtApellido.Text;
             long DniCliente = long.Parse(txtDNI.Text);

             FormProcesarPago frm = new FormProcesarPago(idPedido, NombrePedidoCliente, ApellidoPedidoCliente, DniCliente);
             frm.ShowDialog();*/

            GuardarDetallesPedido();
        }

        private void btnCrearPedido_Click(object sender, EventArgs e)
        {
            CrearPedido();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FormPedidos_Load(object sender, EventArgs e)
        {

        }
    }
}
