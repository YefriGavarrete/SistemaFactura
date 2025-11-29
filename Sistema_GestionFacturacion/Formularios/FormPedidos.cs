using Sistema_GestionFacturacion.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;       // Aquí está Document, Paragraph, etc.
using iTextSharp.text.pdf;   // Aquí está PdfWriter, PdfPTable, etc.
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using Chunk = iTextSharp.text.Chunk;

namespace Sistema_GestionFacturacion.Formularios
{
    public partial class FormPedidos : Form
    {
        ConsultasSQL consultas = new ConsultasSQL();
        AlertasDelSistema Alertas = new AlertasDelSistema();
        //ClaseProcesoPago procesoPago;

        int IdUsuario;
        string rolUsario;
        string UsuarioNombre;
        string UsuarioApellido;

        string estadoPagoGlobal;
        string metodoPagoGlobal;

        DateTime Fecha = DateTime.Now;
        string fechaSQL = "yyyy-MM-dd HH:mm:ss";

        public FormPedidos(int id, string rol, string nombre, string apellido, string estadoPago, string metodoPago)
        {
            IdUsuario = id;
            rolUsario = rol ?? string.Empty;
            UsuarioNombre = nombre ?? string.Empty;
            UsuarioApellido = apellido ?? string.Empty;

            estadoPagoGlobal = estadoPago;
            metodoPagoGlobal = metodoPago;

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
                decimal porcentajeDescuento = decimal.Parse(descuento);

                // Intentar convertir el descuento a decimal
                decimal.TryParse(descuento, out porcentajeDescuento);

                // Calcular subtotal (precio × cantidad)
                decimal subtotal = precioUnitario * cantidadProducto;

                // Calcular monto del descuento
                decimal montoDescuento = subtotal * (porcentajeDescuento / 100);

                decimal subtotal2 = subtotal - montoDescuento;
                // Calcular ISV (12% del subtotal)
                decimal isv = subtotal2 * 0.12m;

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
                    subtotal2.ToString("N2"),
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
            txtISV.Text = isv.ToString();
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
            //string estado = "Pendiente";
            string montopagado = txtTotal.Text.Trim();
            //string metodopago = "Pendiente";
            int idEmpleado = IdUsuario;

            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) || string.IsNullOrEmpty(dni))
            {
                Alertas.Advertencia("Por favor, complete los datos del cliente.");
                return;
            }

            string fecha = Fecha.ToString(fechaSQL);

            string columnas = "NombreCliente, ApellidoCliente, DNI, Fecha, IdEmpleado, NombreEmpleado, ApellidoEmpleado, Estado, MetodoPago, MontoPagado";
            string valores = $"'{nombre}', '{apellido}', '{dni.ToString()}','{fecha}', '{idEmpleado}', '{UsuarioNombre}', '{UsuarioApellido}', '{estadoPagoGlobal}', '{metodoPagoGlobal}', '{montopagado}'";
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

                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtDNI.Enabled = false;
            }
            else
            {
                Alertas.Advertencia("Error al crear el pedido");
                btnCrearPedido.Enabled = true;
                btnBuscarProductos.Enabled = false;
            }
        }


        // metodo para guardar dellates pedidos y actualizar tabla pedido con el monto total
        public void GuardarDetallesPedido(ClaseProcesoPago procesoPago)
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

            // Guardar factura en la tabla Facturas

            facturacion(idPedido, exito);

            if (exito)
            {
                //Alertas.Realizado("Pedido creado exitosamente.");

                actualizarPedido(procesoPago);
                RestarStockProducto();
                LimpiarFormulario();
            }
            else
            {
                Alertas.Advertencia("Ocurrió un error al guardar los productos del pedido.");
            }
        }

        // Guardar en Tabla Facturas
        void GuardarFactura(int idPedido, bool exito, string nombreFactura)
        {
            string carpetaFacturas = Path.Combine(Application.StartupPath, "Facturas");
            //string rutaPDF = Path.Combine(carpetaFacturas, $"Factura_{idPedido}.pdf");
            string rutaPDF = Path.Combine(carpetaFacturas, nombreFactura);

            byte[] pdfBytes = File.ReadAllBytes(rutaPDF);

            /*  foreach (DataGridViewRow fila in DGVDatos.Rows)
              {
                  if (fila.IsNewRow) continue;*/

            string fecha = Fecha.ToString(fechaSQL);
            //decimal total = Convert.ToDecimal(fila.Cells["Total"].Value);
            decimal total = decimal.Parse(txtTotal.Text);

            var parametros = new Dictionary<string, object>()
                {
                    { "IdPedido", idPedido },
                    { "Fecha", fecha },
                    { "NombreEmpleado", UsuarioNombre },
                    { "ApellidoEmpleado", UsuarioApellido },
                    { "NombreCliente", txtNombre.Text },
                    { "ApellidoCliente", txtApellido.Text },
                    { "DNI", txtDNI.Text.Trim() },
                    { "Total", total },
                    { "PDF", pdfBytes }
                };

            string columnas = "IdPedido, Fecha, NombreEmpleado, ApellidoEmpleado, NombreCliente, ApelidoCliente, DNI, Total, PDF";

            if (!consultas.GuardarPDF("Facturas", columnas, parametros))
            {
                exito = false;
                //break;
            }
        }

        // metodo para actualizar el estado y monto del pedido facturado
        void actualizarPedido(ClaseProcesoPago pago)
        {
            try
            {
                string estado = pago.EstadoPago;
                string metodopago = pago.MetodoPago;

                decimal montopagado = decimal.Parse(txtTotal.Text);               
                string actualizar = $"Estado = '{estado}', MetodoPago = '{metodopago}', MontoPagado = '{montopagado}'";
                string condicion = $"IdPedido='{txtIdPedido.Text}'";

                consultas.update("Pedidos", actualizar, condicion);
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al actualizar el pedido: {ex.Message}");
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

            txtIdPedido.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDNI.Text = "";
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

        void facturacion(int idpedido, bool exito)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, complete los datos del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // ==================== GUARDADO AUTOMATICO ====================
                //string carpetaDestino = @"C:\Facturas\";
                string carpetaDestino = Application.StartupPath + @"\Facturas\";

                if (!Directory.Exists(carpetaDestino))
                    Directory.CreateDirectory(carpetaDestino);

                int numeroFactura = idpedido;
                string fecha = DateTime.Now.ToString("yyyy-MM-dd_HHmmss");
                string nombreArchivo = $"Factura_Pedido#{numeroFactura}_{fecha}.pdf";
                string rutaCompleta = Path.Combine(carpetaDestino, nombreArchivo);

                // ==================== CREAR PDF ====================
                iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER, 40, 40, 40, 40);
                iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(rutaCompleta, FileMode.Create));
                doc.Open();

                // ==================== FUENTES ====================
                iTextSharp.text.Font fuenteTitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18, iTextSharp.text.BaseColor.DARK_GRAY);
                iTextSharp.text.Font fuenteSubtitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 12, iTextSharp.text.BaseColor.BLACK);
                iTextSharp.text.Font fuenteNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 10, iTextSharp.text.BaseColor.BLACK);
                iTextSharp.text.Font fuenteNormalBold = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.BLACK);
                iTextSharp.text.Font fuentePequena = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.DARK_GRAY);
                iTextSharp.text.Font fuenteTotal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 14, iTextSharp.text.BaseColor.BLACK);

                // ==================== ENCABEZADO (Logo | Empresa | Datos factura) ====================
                PdfPTable tablaEncabezado = new PdfPTable(3);
                tablaEncabezado.WidthPercentage = 100;
                tablaEncabezado.SetWidths(new float[] { 2f, 3f, 2f });
                tablaEncabezado.DefaultCell.Border = PdfPCell.NO_BORDER;

                // ---------- COLUMNA 1: LOGO ----------
                string rutaLogo = Application.StartupPath + @"\Facturas\Empresa\LOGO.jpg";
                PdfPCell celdaLogo;

                if (File.Exists(rutaLogo))
                {
                    iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(rutaLogo);
                    logo.ScaleToFit(70f, 70f);

                    celdaLogo = new PdfPCell(logo);
                }
                else
                {
                    celdaLogo = new PdfPCell(new Phrase("")); // vacío
                }

                celdaLogo.Border = PdfPCell.NO_BORDER;
                celdaLogo.HorizontalAlignment = Element.ALIGN_LEFT;
                celdaLogo.VerticalAlignment = Element.ALIGN_MIDDLE;
                tablaEncabezado.AddCell(celdaLogo);

                // ---------- COLUMNA 2: INFORMACION EMPRESA ----------
                PdfPCell celdaEmpresa = new PdfPCell();
                celdaEmpresa.Border = PdfPCell.NO_BORDER;
                celdaEmpresa.HorizontalAlignment = Element.ALIGN_CENTER;
                celdaEmpresa.VerticalAlignment = Element.ALIGN_MIDDLE;

                Paragraph titulo = new Paragraph("TecnoHogar", fuenteTitulo);
                titulo.Alignment = Element.ALIGN_CENTER;

                Paragraph infoEmp = new Paragraph("", fuentePequena);
                infoEmp.Alignment = Element.ALIGN_CENTER;
                infoEmp.Add("RTN: 0401000000000000\n");
                infoEmp.Add("Col. Miraflores, Tegucigalpa, Honduras\n");
                infoEmp.Add("Tel: 2234-5678 | Email: contacto@nexoratech.hn\n");

                celdaEmpresa.AddElement(titulo);
                celdaEmpresa.AddElement(infoEmp);
                tablaEncabezado.AddCell(celdaEmpresa);

                // ---------- COLUMNA 3: DATOS DE FACTURA ----------
                PdfPCell celdaDatos = new PdfPCell();
                celdaDatos.Border = PdfPCell.NO_BORDER;

                celdaDatos.HorizontalAlignment = Element.ALIGN_RIGHT;
                celdaDatos.VerticalAlignment = Element.ALIGN_MIDDLE;

                Paragraph pFactura = new Paragraph("FACTURA", fuenteSubtitulo);
                pFactura.Alignment = Element.ALIGN_RIGHT;
                celdaDatos.AddElement(pFactura);

                Paragraph pNumero = new Paragraph($"Pedido N°{numeroFactura}", fuenteNormalBold);
                pNumero.Alignment = Element.ALIGN_RIGHT;
                celdaDatos.AddElement(pNumero);

                Paragraph pFecha = new Paragraph($"Fecha: {DateTime.Now:dd/MM/yyyy}", fuenteNormal);
                pFecha.Alignment = Element.ALIGN_RIGHT;
                celdaDatos.AddElement(pFecha);

                Paragraph pHora = new Paragraph($"Hora: {DateTime.Now:HH:mm:ss}", fuenteNormal);
                pHora.Alignment = Element.ALIGN_RIGHT;
                celdaDatos.AddElement(pHora);

                tablaEncabezado.AddCell(celdaDatos);

                // Agregar al documento
                doc.Add(tablaEncabezado);

                // --------- LINEA SEPARADORA ---------
                doc.Add(new Paragraph(" "));

                iTextSharp.text.pdf.draw.LineSeparator linea =
                    new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, BaseColor.GRAY, Element.ALIGN_CENTER, -2);
                doc.Add(new Chunk(linea));
                doc.Add(new Paragraph(" "));

                // ==================== INFORMACION FISCAL ====================
                iTextSharp.text.pdf.PdfPTable tablaFiscal = new iTextSharp.text.pdf.PdfPTable(3);
                tablaFiscal.WidthPercentage = 100;
                tablaFiscal.SetWidths(new float[] { 1.3f, 3f, 1.2f });

                // --- COLUMNA 1: CAI ---
                PdfPCell celdaCAI = new PdfPCell();
                celdaCAI.Border = PdfPCell.NO_BORDER;
                celdaCAI.HorizontalAlignment = Element.ALIGN_LEFT;

                Paragraph pCAI = new Paragraph($"CAI: A1B2-C3D4-E5F6-G7H8", fuentePequena);
                pCAI.Alignment = Element.ALIGN_LEFT;
                celdaCAI.AddElement(pCAI);
                tablaFiscal.AddCell(celdaCAI);

                // --- COLUMNA 2: RANGO ---
                PdfPCell celdaRango = new PdfPCell();
                celdaRango.Border = PdfPCell.NO_BORDER;
                celdaRango.HorizontalAlignment = Element.ALIGN_CENTER;

                Paragraph pRango = new Paragraph($"Rango: 000-001-01-00000001 a 000-001-01-00010000", fuentePequena);
                pRango.Alignment = Element.ALIGN_CENTER;
                celdaRango.AddElement(pRango);
                tablaFiscal.AddCell(celdaRango);

                // --- COLUMNA 3: FECHA LIMITE ---
                PdfPCell celdaFecha = new PdfPCell();
                celdaFecha.Border = PdfPCell.NO_BORDER;
                celdaFecha.HorizontalAlignment = Element.ALIGN_RIGHT;

                DateTime fechalimit = DateTime.Now.AddMonths(1);
                string fechaLimite = fechalimit.ToString("dd/MM/yyyy");

                Paragraph FechaLimit = new Paragraph($"Fecha Límite: " + fechaLimite, fuentePequena);
                FechaLimit.Alignment = Element.ALIGN_RIGHT;
                celdaFecha.AddElement(FechaLimit);
                tablaFiscal.AddCell(celdaFecha);

                // Agregar tabla al documento
                doc.Add(tablaFiscal);
                doc.Add(new Paragraph(" "));

                // ==================== DATOS DEL CLIENTE ====================
                iTextSharp.text.pdf.PdfPTable tablaCliente = new iTextSharp.text.pdf.PdfPTable(1);
                tablaCliente.WidthPercentage = 100;

                iTextSharp.text.pdf.PdfPCell celdaCliente = new iTextSharp.text.pdf.PdfPCell();
                celdaCliente.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                celdaCliente.Padding = 10;
                celdaCliente.AddElement(new iTextSharp.text.Paragraph("DATOS DEL CLIENTE", fuenteSubtitulo));
                celdaCliente.AddElement(new iTextSharp.text.Paragraph($"Nombre: {txtNombre.Text} {txtApellido.Text}", fuenteNormal));
                celdaCliente.AddElement(new iTextSharp.text.Paragraph($"DNI/RTN: {txtDNI.Text}", fuenteNormal));
                tablaCliente.AddCell(celdaCliente);

                doc.Add(tablaCliente);
                doc.Add(new iTextSharp.text.Paragraph(" "));

                // ==================== TABLA DE PRODUCTOS ====================
                iTextSharp.text.pdf.PdfPTable tablaProductos = new iTextSharp.text.pdf.PdfPTable(6);
                tablaProductos.WidthPercentage = 100;
                tablaProductos.SetWidths(new float[] { 1f, 2f, 1f, 1f, 1f, 1f });

                // Encabezados de tabla con estilo
                iTextSharp.text.BaseColor colorEncabezado = new iTextSharp.text.BaseColor(70, 130, 180);
                string[] encabezados = { "Codigo", "Producto", "Precio Unitario", "Descuento", "Subtotal", "Total" };
                foreach (string encabezado in encabezados)
                {
                    iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(encabezado, iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.WHITE)));
                    celda.BackgroundColor = colorEncabezado;
                    celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                    celda.Padding = 8;
                    celda.Border = PdfPCell.NO_BORDER;
                    tablaProductos.AddCell(celda);
                }

                BaseColor colorFila1 = BaseColor.WHITE;
                BaseColor colorFila2 = new BaseColor(240, 240, 240);
                int filaIndex = 0;

                foreach (DataGridViewRow row in DGVDatos.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        BaseColor colorFila = (filaIndex % 2 == 0) ? colorFila1 : colorFila2;

                        PdfPCell celdaCodigo = new PdfPCell(new Phrase(row.Cells[2].Value.ToString(), fuenteNormal));
                        celdaCodigo.Border = PdfPCell.NO_BORDER;
                        celdaCodigo.BackgroundColor = colorFila;
                        celdaCodigo.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaCodigo.Padding = 5;
                        tablaProductos.AddCell(celdaCodigo);

                        string Producto = row.Cells[7].Value.ToString() + " " +
                                          row.Cells[3].Value.ToString() + " " +
                                          row.Cells[4].Value.ToString() + " " +
                                          row.Cells[5].Value.ToString();
                        PdfPCell celdaProducto = new PdfPCell(new Phrase(Producto, fuenteNormal));
                        celdaProducto.Border = PdfPCell.NO_BORDER;
                        celdaProducto.BackgroundColor = colorFila;
                        celdaProducto.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaProducto.Padding = 5;
                        celdaProducto.NoWrap = false;
                        tablaProductos.AddCell(celdaProducto);

                        PdfPCell celdaPrecio = new PdfPCell(new Phrase("L. " + row.Cells[6].Value.ToString(), fuenteNormal));
                        celdaPrecio.Border = PdfPCell.NO_BORDER;
                        celdaPrecio.BackgroundColor = colorFila;
                        celdaPrecio.HorizontalAlignment = Element.ALIGN_RIGHT;
                        celdaPrecio.Padding = 5;
                        tablaProductos.AddCell(celdaPrecio);

                        PdfPCell celdaDesc = new PdfPCell(new Phrase(row.Cells[8].Value.ToString(), fuenteNormal));
                        celdaDesc.Border = PdfPCell.NO_BORDER;
                        celdaDesc.BackgroundColor = colorFila;
                        celdaDesc.HorizontalAlignment = Element.ALIGN_CENTER;
                        celdaDesc.Padding = 5;
                        tablaProductos.AddCell(celdaDesc);

                        PdfPCell celdaSub = new PdfPCell(new Phrase("L. " + row.Cells[9].Value.ToString(), fuenteNormal));
                        celdaSub.Border = PdfPCell.NO_BORDER;
                        celdaSub.BackgroundColor = colorFila;
                        celdaSub.HorizontalAlignment = Element.ALIGN_RIGHT;
                        celdaSub.Padding = 5;
                        tablaProductos.AddCell(celdaSub);

                        PdfPCell celdaTotal = new PdfPCell(new Phrase("L. " + row.Cells[11].Value.ToString(), fuenteNormal));
                        celdaTotal.Border = PdfPCell.NO_BORDER;
                        celdaTotal.BackgroundColor = colorFila;
                        celdaTotal.HorizontalAlignment = Element.ALIGN_RIGHT;
                        celdaTotal.Padding = 5;
                        tablaProductos.AddCell(celdaTotal);

                        filaIndex++;
                    }
                }

                doc.Add(tablaProductos);
                doc.Add(new iTextSharp.text.Paragraph(" "));

                // ==================== TOTALES ====================
                iTextSharp.text.pdf.PdfPTable tablaTotales = new iTextSharp.text.pdf.PdfPTable(2);
                tablaTotales.WidthPercentage = 50;
                tablaTotales.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                tablaTotales.SetWidths(new float[] { 2f, 2f });

                // SUBTOTAL
                tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Subtotal:", fuenteNormalBold))
                { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });
                tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + txtSubtotal.Text, fuenteNormal))
                { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });

                // ISV
                tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("ISV (12%):", fuenteNormalBold))
                { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });
                tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(txtISV.Text, fuenteNormal))
                { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });

                // TOTAL
                iTextSharp.text.pdf.PdfPCell celdaTotalLabel = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("TOTAL:", fuenteTotal));
                celdaTotalLabel.Border = iTextSharp.text.Rectangle.TOP_BORDER;
                celdaTotalLabel.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                celdaTotalLabel.Padding = 8;
                celdaTotalLabel.BorderWidthTop = 2;
                tablaTotales.AddCell(celdaTotalLabel);

                iTextSharp.text.pdf.PdfPCell celdaTotalValor = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + txtTotal.Text, fuenteTotal));
                celdaTotalValor.Border = iTextSharp.text.Rectangle.TOP_BORDER;
                celdaTotalValor.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                celdaTotalValor.Padding = 8;
                celdaTotalValor.BorderWidthTop = 2;
                tablaTotales.AddCell(celdaTotalValor);

                doc.Add(tablaTotales);
                doc.Add(new iTextSharp.text.Paragraph(" "));
                doc.Add(new iTextSharp.text.Paragraph(" "));

                // ==================== PIE DE PÁGINA ====================
                iTextSharp.text.Paragraph notaFinal = new iTextSharp.text.Paragraph("Gracias por su compra", fuenteSubtitulo);
                notaFinal.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(notaFinal);

                iTextSharp.text.Paragraph leyenda = new iTextSharp.text.Paragraph(
                    "La factura es beneficio de todos. Exija su factura.\n" +
                    "Este documento es válido como factura comercial.",
                    fuentePequena
                );
                leyenda.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                doc.Add(leyenda);

                doc.Close();

                Alertas.Realizado($"Factura guardada correctamente en:\n{rutaCompleta}");
                GuardarFactura(idpedido, exito, nombreArchivo);

                // ==================== ABRIR PDF AUTOMÁTICAMENTE ====================
                Process.Start(new ProcessStartInfo()
                {
                    FileName = rutaCompleta,
                    UseShellExecute = true
                });             
            }
            catch 
            {
                Alertas.Advertencia("Error al generar la factura, CONTACTE A SISTEMAS");
            }
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

        private void btnFacturacion_Click(object sender, EventArgs e)
        {
             int idPedido= int.Parse(txtIdPedido.Text);
             string NombrePedidoCliente= txtNombre.Text;
             string ApellidoPedidoCliente = txtApellido.Text;
             decimal totalPago = decimal.Parse(txtTotal.Text);

            FormProcesoPago frm = new FormProcesoPago(this, idPedido, NombrePedidoCliente, ApellidoPedidoCliente, totalPago);
            frm.ShowDialog();

            //GuardarDetallesPedido();
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void btnBuscarProductos_Click_1(object sender, EventArgs e)
        {
            FormBuscarProductos frm = new FormBuscarProductos();
            frm.ShowDialog();
        }
    }
}
