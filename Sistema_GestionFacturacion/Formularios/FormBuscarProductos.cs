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
    public partial class FormBuscarProductos : Form
    {
        AlertasDelSistema Alertas = new AlertasDelSistema();
        ConsultasSQL consulta = new ConsultasSQL();

        public FormBuscarProductos()
        {
            InitializeComponent();
        }

        private void FormBuscarProductos_Load(object sender, EventArgs e)
        {
            MostrarRegistros2();
        }

        private void MostrarRegistros2()
        {
            try
            {
                string query = @"
            SELECT 
                p.IdProducto,
                p.Codigo,
                p.Marca,
                p.Modelo,
                p.Precio,
                p.Stock,
                c.Categoria AS Categoria,
                d.Descuento AS Descuento,
                p.Descripcion
            FROM Productos p
            INNER JOIN Categorias c ON p.IdCategoria = c.IdCategoria
            INNER JOIN Descuento d ON p.IdDescuento = d.IdDescuento
            WHERE p.Stock > 0;";

                DataTable dt = consulta.EjecutarConsultaSelect(query);
                dgvDatos.DataSource = dt;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDatos.Refresh();
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al mostrar registros: {ex.Message}");
            }
        }
        void CargarTextBox(DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                    // Cargar los valores a los TextBox
                    txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
                    txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                    txtCategoria.Text = fila.Cells["Categoria"].Value.ToString();
                    txtMarca.Text = fila.Cells["Marca"].Value.ToString();
                    txtModelo.Text = fila.Cells["Modelo"].Value.ToString();
                    txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                    txtDescuento.Text = fila.Cells["Descuento"].Value.ToString();
                    txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();

                    // Obtener el stock del producto
                    int stock = Convert.ToInt32(fila.Cells["Stock"].Value);

                    // Limpiar el ComboBox antes de llenarlo
                    cmbCantidad.Items.Clear();

                    // Llenar el ComboBox desde 1 hasta el valor del stock
                    for (int i = 1; i <= stock; i++)
                    {
                        cmbCantidad.Items.Add(i);
                    }

                    // Establecer por defecto el valor 1
                    if (cmbCantidad.Items.Count > 0)
                    {
                        cmbCantidad.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al cargar datos: {ex.Message}");
            }
        }

        private void EnviarAPedidos()
        {
            // Instancia del formulario destino
            FormPedidos pedidosForm = (FormPedidos)Application.OpenForms["FormPedidos"];

            // Verifica si el formulario esta abierto
            if (pedidosForm != null)
            {
                // Llama al metodo publico y envia los datos
                pedidosForm.AgregarProducto(
                    txtIdProducto.Text,
                    txtCodigo.Text,
                    txtCategoria.Text,
                    txtMarca.Text,
                    txtModelo.Text,
                    txtPrecio.Text,
                    cmbCantidad.Text,
                    txtDescuento.Text
                );

                MessageBox.Show("Producto agregado al pedido correctamente.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El formulario de pedidos no está abierto.");
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnviarAPedidos_Click(object sender, EventArgs e)
        {
            EnviarAPedidos();
        }

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            // refrezcar datagridview
            MostrarRegistros2();
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CargarTextBox(e);
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {

        }
    }
}
