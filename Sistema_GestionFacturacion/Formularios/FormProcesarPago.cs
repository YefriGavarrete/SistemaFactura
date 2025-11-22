using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;       // Aquí está Document, Paragraph, etc.
using iTextSharp.text.pdf;   // Aquí está PdfWriter, PdfPTable, etc.

namespace Sistema_GestionFacturacion.Formularios
{

    public partial class FormProcesarPago : Form
    {

        private int numeroFactura = 1;
        private const decimal ISV = 0.15m;
        public FormProcesarPago()
        {

            InitializeComponent();
            InicializarFormulario();
        }
        private void InicializarFormulario()
        {
            cmbProducto.Items.AddRange(new string[]
            {
                "Laptop", "Mouse", "Teclado", "Monitor", "Impresora", "UPS"
            });
            cmbProducto.SelectedIndex = 0;

            // Cantidades del 1 al 10
            for (int i = 1; i <= 10; i++)
                cmbCantidad.Items.Add(i);
            cmbCantidad.SelectedIndex = 0;

            txtNumPedido.Text = numeroFactura.ToString();
            ActualizarTotales();

        }
        private decimal ObtenerPrecioProducto(string producto)
        {
            switch (producto)
            {
                case "Laptop": return 15000m;
                case "Mouse": return 250m;
                case "Teclado": return 450m;
                case "Monitor": return 8000m;
                case "Impresora": return 5000m;
                case "UPS": return 800m;
                case "Computadora de Escritorio": 
                    return 12000m;
                default: return 0m;
            }
        }
        private void ActualizarTotales()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dgvDetalles.Rows)
            {
                if (row.Cells[4].Value != null)
                    subtotal += Convert.ToDecimal(row.Cells[4].Value);
            }

            decimal impuesto = subtotal * ISV;
            decimal total = subtotal + impuesto;

            txtSubtotal.Text = subtotal.ToString("F2");
            txtISV.Text = impuesto.ToString("F2");
            txtTotal.Text = total.ToString("F2");

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string producto = cmbProducto.SelectedItem.ToString();
            int cantidad = Convert.ToInt32(cmbCantidad.SelectedItem);
            decimal precio = ObtenerPrecioProducto(producto);
            decimal subtotal = cantidad * precio;

            dgvDetalles.Rows.Add(numeroFactura, producto, cantidad, precio, subtotal);
            ActualizarTotales();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            numeroFactura++;
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
            txtNumPedido.Text = numeroFactura.ToString();
            dgvDetalles.Rows.Clear();
            ActualizarTotales();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            dgvDetalles.Rows.Clear();
            ActualizarTotales();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
        string.IsNullOrWhiteSpace(txtApellido.Text) ||
        string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                MessageBox.Show("Por favor, complete los datos del cliente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Datos de empresa
            string nombreEmpresa = "NEXORA TECH";
            string rtnEmpresa = "0401000000000000";
            string direccionEmpresa = "Col. Miraflores, Tegucigalpa, Honduras";
            string telefonoEmpresa = "2234-5678";
            string correoEmpresa = "contacto@nexoratech.hn";
            string cai = "A1B2-C3D4-E5F6-G7H8";
            string rangoAutorizado = "000-001-01-00000001 a 000-001-01-00010000";
            string fechaLimite = "31/12/2025";

            // Crear nombre sugerido con fecha
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            string nombreArchivo = $"Factura_{numeroFactura}_{fecha}.pdf";

            // Abrir explorador para elegir ubicación
            SaveFileDialog guardarPDF = new SaveFileDialog();
            guardarPDF.FileName = nombreArchivo;
            guardarPDF.Filter = "Archivo PDF (*.pdf)|*.pdf";

            if (guardarPDF.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // Crear PDF
                    iTextSharp.text.Document doc = new iTextSharp.text.Document(iTextSharp.text.PageSize.A4, 40, 40, 40, 40);
                    iTextSharp.text.pdf.PdfWriter writer = iTextSharp.text.pdf.PdfWriter.GetInstance(doc, new FileStream(guardarPDF.FileName, FileMode.Create));
                    doc.Open();

                    // Definir fuentes
                    iTextSharp.text.Font fuenteTitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 18, iTextSharp.text.BaseColor.DARK_GRAY);
                    iTextSharp.text.Font fuenteSubtitulo = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 12, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font fuenteNormal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 10, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font fuenteNormalBold = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.BLACK);
                    iTextSharp.text.Font fuentePequena = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA, 8, iTextSharp.text.BaseColor.DARK_GRAY);
                    iTextSharp.text.Font fuenteTotal = iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 14, iTextSharp.text.BaseColor.BLACK);

                    // ==================== ENCABEZADO ====================
                    // Logo o nombre de empresa (puedes agregar logo si tienes)
                    iTextSharp.text.Paragraph nombreEmp = new iTextSharp.text.Paragraph(nombreEmpresa, fuenteTitulo);
                    nombreEmp.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    doc.Add(nombreEmp);

                    iTextSharp.text.Paragraph infoEmpresa = new iTextSharp.text.Paragraph();
                    infoEmpresa.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                    infoEmpresa.Font = fuentePequena;
                    infoEmpresa.Add($"RTN: {rtnEmpresa}\n");
                    infoEmpresa.Add($"{direccionEmpresa}\n");
                    infoEmpresa.Add($"Tel: {telefonoEmpresa} | Email: {correoEmpresa}\n");
                    doc.Add(infoEmpresa);

                    // Línea separadora
                    doc.Add(new iTextSharp.text.Paragraph(" "));
                    iTextSharp.text.pdf.draw.LineSeparator linea = new iTextSharp.text.pdf.draw.LineSeparator(1f, 100f, iTextSharp.text.BaseColor.GRAY, iTextSharp.text.Element.ALIGN_CENTER, -2);
                    doc.Add(new iTextSharp.text.Chunk(linea));
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // ==================== INFORMACIÓN FISCAL ====================
                    iTextSharp.text.pdf.PdfPTable tablaFiscal = new iTextSharp.text.pdf.PdfPTable(2);
                    tablaFiscal.WidthPercentage = 100;
                    tablaFiscal.SetWidths(new float[] { 1f, 1f });

                    // Columna izquierda
                    iTextSharp.text.pdf.PdfPCell celdaIzq = new iTextSharp.text.pdf.PdfPCell();
                    celdaIzq.Border = 0;
                    celdaIzq.AddElement(new iTextSharp.text.Paragraph("FACTURA", fuenteSubtitulo));
                    celdaIzq.AddElement(new iTextSharp.text.Paragraph($"N° {numeroFactura}", fuenteNormalBold));
                    celdaIzq.AddElement(new iTextSharp.text.Paragraph($"Fecha: {DateTime.Now.ToString("dd/MM/yyyy")}", fuenteNormal));
                    celdaIzq.AddElement(new iTextSharp.text.Paragraph($"Hora: {DateTime.Now.ToString("HH:mm:ss")}", fuenteNormal));
                    tablaFiscal.AddCell(celdaIzq);

                    // Columna derecha - Datos fiscales
                    iTextSharp.text.pdf.PdfPCell celdaDer = new iTextSharp.text.pdf.PdfPCell();
                    celdaDer.Border = 0;
                    celdaDer.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    celdaDer.AddElement(new iTextSharp.text.Paragraph($"CAI: {cai}", fuentePequena));
                    celdaDer.AddElement(new iTextSharp.text.Paragraph($"Rango: {rangoAutorizado}", fuentePequena));
                    celdaDer.AddElement(new iTextSharp.text.Paragraph($"Fecha Límite: {fechaLimite}", fuentePequena));
                    tablaFiscal.AddCell(celdaDer);

                    doc.Add(tablaFiscal);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

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
                    iTextSharp.text.pdf.PdfPTable tablaProductos = new iTextSharp.text.pdf.PdfPTable(5);
                    tablaProductos.WidthPercentage = 100;
                    tablaProductos.SetWidths(new float[] { 1.5f, 3f, 1.5f, 2f, 2f });

                    // Encabezados de tabla con estilo
                    iTextSharp.text.BaseColor colorEncabezado = new iTextSharp.text.BaseColor(70, 130, 180);
                    string[] encabezados = { "ID", "Producto", "Cantidad", "Precio Unit.", "Subtotal" };

                    foreach (string encabezado in encabezados)
                    {
                        iTextSharp.text.pdf.PdfPCell celda = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(encabezado, iTextSharp.text.FontFactory.GetFont(iTextSharp.text.FontFactory.HELVETICA_BOLD, 10, iTextSharp.text.BaseColor.WHITE)));
                        celda.BackgroundColor = colorEncabezado;
                        celda.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                        celda.Padding = 8;
                        tablaProductos.AddCell(celda);
                    }

                    // Agregar productos
                    foreach (DataGridViewRow row in dgvDetalles.Rows)
                    {
                        if (row.Cells[0].Value != null)
                        {
                            // ID
                            iTextSharp.text.pdf.PdfPCell celdaId = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[0].Value.ToString(), fuenteNormal));
                            celdaId.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            celdaId.Padding = 5;
                            tablaProductos.AddCell(celdaId);

                            // Producto
                            iTextSharp.text.pdf.PdfPCell celdaProd = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[1].Value.ToString(), fuenteNormal));
                            celdaProd.Padding = 5;
                            tablaProductos.AddCell(celdaProd);

                            // Cantidad
                            iTextSharp.text.pdf.PdfPCell celdaCant = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase(row.Cells[2].Value.ToString(), fuenteNormal));
                            celdaCant.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER;
                            celdaCant.Padding = 5;
                            tablaProductos.AddCell(celdaCant);

                            // Precio Unitario
                            iTextSharp.text.pdf.PdfPCell celdaPrecio = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + row.Cells[3].Value.ToString(), fuenteNormal));
                            celdaPrecio.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            celdaPrecio.Padding = 5;
                            tablaProductos.AddCell(celdaPrecio);

                            // Subtotal
                            iTextSharp.text.pdf.PdfPCell celdaSub = new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + row.Cells[4].Value.ToString(), fuenteNormal));
                            celdaSub.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                            celdaSub.Padding = 5;
                            tablaProductos.AddCell(celdaSub);
                        }
                    }

                    doc.Add(tablaProductos);
                    doc.Add(new iTextSharp.text.Paragraph(" "));

                    // ==================== TOTALES ====================
                    iTextSharp.text.pdf.PdfPTable tablaTotales = new iTextSharp.text.pdf.PdfPTable(2);
                    tablaTotales.WidthPercentage = 50;
                    tablaTotales.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT;
                    tablaTotales.SetWidths(new float[] { 2f, 2f });

                    // Subtotal
                    tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("Subtotal:", fuenteNormalBold))
                    { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });
                    tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + txtSubtotal.Text, fuenteNormal))
                    { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });

                    // ISV
                    tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("ISV (15%):", fuenteNormalBold))
                    { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });
                    tablaTotales.AddCell(new iTextSharp.text.pdf.PdfPCell(new iTextSharp.text.Phrase("L. " + txtISV.Text, fuenteNormal))
                    { Border = iTextSharp.text.Rectangle.NO_BORDER, HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT, Padding = 5 });

                    // Total
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

                    MessageBox.Show("✅ Factura guardada correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnNuevo.PerformClick(); 
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al generar la factura: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
