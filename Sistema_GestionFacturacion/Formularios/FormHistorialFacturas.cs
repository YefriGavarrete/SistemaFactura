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

namespace Sistema_GestionFacturacion.Formularios
{
    public partial class FormHistorialFacturas : Form
    {
        ConsultasSQL consultaSQL = new ConsultasSQL();
        AlertasDelSistema Alertas = new AlertasDelSistema();
        Conexion conexion = new Conexion();
        public FormHistorialFacturas()
        {
            InitializeComponent();
            MostrarRegistros();
        }

        private void MostrarRegistros()
        {
            try
            {
                string columnas = "IdFactura, IdPedido, NombreEmpleado, ApellidoEmpleado, NombreCliente, ApelidoCliente, DNI, Total"; // NO AGREGAR LA DE PDP que explota;
                DataTable dt = consultaSQL.Buscar("Facturas", columnas);
                dgvdatos.DataSource = dt;
                dgvdatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvdatos.Refresh();

                DataGridViewButtonColumn PDF = new DataGridViewButtonColumn();
                PDF.Name = "PDF";
                PDF.HeaderText = "PDF";
                PDF.Text = "Ver";
                PDF.UseColumnTextForButtonValue = true;

                dgvdatos.Columns.Add(PDF);
                dgvdatos.RowTemplate.Height = 20;

            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al mostrar registros: {ex.Message}");
            }
        }

        void Filtro()
        {
            DataTable dt = (DataTable)dgvdatos.DataSource;

            if (dt == null) return;

            string texto = txtFiltrar.Text.Replace("'", "''");

            if (string.IsNullOrWhiteSpace(texto))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            dt.DefaultView.RowFilter = $"Convert(IdFactura, 'System.String') LIKE '%{texto}%' OR " + $"Convert(IdPedido, 'System.String') LIKE '%{texto}%' OR " + $"NombreEmpleado LIKE '%{texto}%' OR " + $"ApellidoEmpleado LIKE '%{texto}%' OR " + $"NombreCliente LIKE '%{texto}%' OR " + $"ApelidoCliente LIKE '%{texto}%' OR " + $"DNI LIKE '%{texto}%' OR " + $"Convert(Total, 'System.String') LIKE '%{texto}%'";
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Filtro();
        }

        private void dgvdatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                MessageBox.Show("Debe seleccionar un registro valido.");
                return;
            }

            if (dgvdatos.Columns[e.ColumnIndex].Name == "PDF")
            {
                object valorId = dgvdatos.Rows[e.RowIndex].Cells["IdPedido"].Value;

                if (valorId == null || valorId == DBNull.Value)
                {
                    MessageBox.Show("Este registro esta vacio. Seleccione un registro valido.");
                    return;
                }

                int idPedido = Convert.ToInt32(dgvdatos.Rows[e.RowIndex].Cells["IdPedido"].Value);

                // Consulta la base de datos
                string consulta = $"SELECT PDF FROM Facturas WHERE IdPedido = {idPedido}";
                DataTable dt = consultaSQL.EjecutarConsultaSelect(consulta);

                if (dt.Rows.Count > 0)
                {
                    byte[] archivoPDF = dt.Rows[0]["PDF"] as byte[];

                    if (archivoPDF != null && archivoPDF.Length > 0)
                    {
                        // Generar un nombre temporal para abrir el PDF
                        string tempPath = Path.Combine(Path.GetTempPath(), $"Factura_Pedido_{idPedido}.pdf");
                        File.WriteAllBytes(tempPath, archivoPDF);

                        var psi = new ProcessStartInfo()
                        {
                            FileName = tempPath,
                            UseShellExecute = true
                        };
                        Process.Start(psi);
                    }
                    else
                    {
                        MessageBox.Show($"El PDF del Pedido #{idPedido} está vacío en la base de datos.");
                    }
                }
                else
                {
                    MessageBox.Show($"No se encontró la factura del Pedido #{idPedido} en la base de datos.");
                }
            }
        }

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
            Alertas.Confirmacion("Datos Actualizados");
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            conexion.validarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
