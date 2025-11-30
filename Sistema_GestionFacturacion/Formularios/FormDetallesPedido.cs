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
    public partial class FormDetallesPedido : Form
    {
        ConsultasSQL consulta = new ConsultasSQL();
        AlertasDelSistema Alertas = new AlertasDelSistema();

        int ID;
        string Est;

        public FormDetallesPedido(int idPedido, string estado)
        {
            InitializeComponent();
            
            ID = idPedido;  
            Est = estado;

            MostrarRegistros();
        }

        private void MostrarRegistros()
        {

            try
            {
                string columnasDetalles = "Categoria, Marca , Modelo, Precio, Cantidad, Descuento, Subtotal, ISV, Total";
                string condicionDetalles = $"IdPedido = {ID}";
                DataTable dtDetalles = consulta.Buscar("DetallesPedidos", columnasDetalles, condicionDetalles);
                DGVDatos.DataSource = dtDetalles;
                DGVDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                DGVDatos.Refresh();

                decimal sumaSubtotal = 0;
                decimal sumaISV = 0;
                decimal sumaTotal = 0;

                foreach (DataRow row in dtDetalles.Rows)
                {
                    sumaSubtotal += Convert.ToDecimal(row["Subtotal"]);
                    sumaISV += Convert.ToDecimal(row["ISV"]);
                    sumaTotal += Convert.ToDecimal(row["Total"]);
                }

                // Mostrar en TextBox
                txtSubtotal.Text = sumaSubtotal.ToString("N2");
                txtISV.Text = sumaISV.ToString("N2");
                txtTotal.Text = sumaTotal.ToString("N2");

                string columnasPedidos = "NombreCliente, ApellidoCliente, DNI, Fecha, NombreEmpleado, ApellidoEmpleado, Estado, MetodoPago, MontoPagado";
                string condicionPedidos = $"IdPedido = {ID}";
                DataTable dtPdidos = consulta.Buscar("Pedidos", columnasPedidos, condicionPedidos);

                txtNombre.Text = dtPdidos.Rows[0]["NombreCliente"].ToString();
                txtApellido.Text = dtPdidos.Rows[0]["ApellidoCliente"].ToString();
                txtDNI.Text = dtPdidos.Rows[0]["DNI"].ToString();
                dtpFecha.Value = Convert.ToDateTime(dtPdidos.Rows[0]["Fecha"]);
                txtNombreEmpleado.Text = dtPdidos.Rows[0]["NombreEmpleado"].ToString();
                txtApellidoEmpleado.Text = dtPdidos.Rows[0]["ApellidoEmpleado"].ToString();
                txtEstado.Text = dtPdidos.Rows[0]["Estado"].ToString();
                txtMetodoPago.Text = dtPdidos.Rows[0]["MetodoPago"].ToString();

            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al mostrar registros: {ex.Message}");
            }
        }

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            MostrarRegistros();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            consulta.validarConexion();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
