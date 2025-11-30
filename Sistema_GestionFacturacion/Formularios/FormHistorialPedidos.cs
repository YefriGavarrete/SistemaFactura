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
    public partial class FormHistorialPedidos : Form
    {
        ConsultasSQL Con;
        AlertasDelSistema Alertas;
        public FormHistorialPedidos()
        {
            InitializeComponent();
        }

        private void MostrarRegistros()
        {
            Con = new ConsultasSQL();
            Alertas = new AlertasDelSistema();
            try
            {
                string columnas = "IdPedido, NombreCliente, ApellidoCliente, DNI, Fecha, IdEmpleado, NombreEmpleado, ApellidoEmpleado, Estado, MetodoPago, MontoPagado";
                DataTable dt = Con.Buscar("Pedidos", columnas);
                dgvDatos.DataSource = dt;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDatos.Refresh();

            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al mostrar registros: {ex.Message}");
            }
        }

        void Filtro()
        {
            DataTable dt = (DataTable)dgvDatos.DataSource;

            if (dt == null) return;

            string texto = txtFiltrar.Text.Replace("'", "''");

            if (string.IsNullOrWhiteSpace(texto))
            {
                dt.DefaultView.RowFilter = "";
                return;
            }

            dt.DefaultView.RowFilter =
                $"Convert(IdPedido, 'System.String') LIKE '%{texto}%' OR " +
                $"NombreCliente LIKE '%{texto}%' OR " +
                $"ApellidoCliente LIKE '%{texto}%' OR " +
                $"DNI LIKE '%{texto}%' OR " +
                $"Convert(IdEmpleado,'System.String') LIKE '%{texto}%' OR " +
                $"NombreEmpleado LIKE '%{texto}%' OR " +
                $"ApellidoEmpleado LIKE '%{texto}%' OR " +
                $"Estado LIKE '%{texto}%' OR " +
                $"MetodoPago LIKE '%{texto}%' OR " +
                $"Convert(MontoPagado,'System.String')  LIKE '%{texto}%'";
        }

        private void FormHistorialPedidos_Load(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            Filtro();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int idPedido = Convert.ToInt32(dgvDatos.Rows[e.RowIndex].Cells["IdPedido"].Value);
                string estado = Convert.ToString(dgvDatos.Rows[e.RowIndex].Cells["Estado"].Value);
                FormDetallesPedido frm = new FormDetallesPedido(idPedido, estado);
                frm.ShowDialog();
            }
        }

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            Con.validarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
