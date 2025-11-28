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
    public partial class FormProductos : Form
    {
        ConsultasSQL consulta = new ConsultasSQL();
        AlertasDelSistema Alertas = new AlertasDelSistema();
        Conexion conexion = new Conexion();

        public FormProductos()
        {
            InitializeComponent();
            MostrarRegistros($"Stock > 0");

            rbConStock.Checked = true;
            txtFiltrar.Enabled = true;
            
            txtIdProducto.Enabled = false;
            txtCodigo.Enabled = false;
            txtMarca.Enabled = false;
            txtModelo.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtCantidad.Enabled = false;

            cmbCategoria.Enabled = false;

            CargarDescuento();
        }

        void CargarDescuento()
        {
            try
            {
                DataTable dtDesc = consulta.Buscar("Descuento", "IdDescuento, Descuento", "Estado = 'Activo'");
                if (dtDesc != null && dtDesc.Rows.Count > 0)
                {
                    cmbDescuento.DataSource = dtDesc;
                    cmbDescuento.DisplayMember = "Descuento";
                    cmbDescuento.ValueMember = "IdDescuento";
                    cmbDescuento.Enabled = false;
                }
                else
                {
                    cmbDescuento.DataSource = null;
                    cmbDescuento.Items.Clear();
                }



                DataTable dtCat = consulta.Buscar("Categorias", "IdCategoria, Categoria", "Estado = 'Activo'");
                if (dtCat != null && dtCat.Rows.Count > 0)
                {
                    cmbCategoria.DataSource = dtCat;
                    cmbCategoria.DisplayMember = "Categoria";
                    cmbCategoria.ValueMember = "IdCategoria";
                    cmbCategoria.Enabled = false;
                }
                else
                {
                    cmbCategoria.DataSource = null;
                    cmbCategoria.Items.Clear();
                }
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al cargar los Cmb: {ex.Message}");
            }

        }

        void limpiarCampos()
        {
            txtIdProducto.Text = "";
            txtCodigo.Clear();
            txtMarca.Clear();
            txtModelo.Clear();
            txtDescripcion.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            cmbDescuento.SelectedIndex = 0;

            cmbCategoria.SelectedIndex = 0;
        }

        void HabilitarNuevosRegistros(bool valor)
        {
            btnGuardarRegistro.Enabled = valor;
            btnCancelarRegistro.Enabled = valor;
            cmbCategoria.Enabled = valor;
            cmbDescuento.Enabled = valor;

            txtCodigo.Enabled = !valor;
            txtCodigo.Enabled = valor;
            txtMarca.Enabled = valor;
            txtModelo.Enabled = valor;
            txtDescripcion.Enabled = valor;
            txtPrecio.Enabled = valor;
            txtCantidad.Enabled = valor;
            btnNuevoRegistro.Enabled = !valor;
        }

        void GuardarProducto()
        {
            string codigo = txtCodigo.Text;
            string marca = txtMarca.Text;
            string modelo = txtModelo.Text;
            string descripcion = txtDescripcion.Text;
            string precio = txtPrecio.Text;
            string cantidad = txtCantidad.Text;

            int categoria = Convert.ToInt32(((DataRowView)cmbCategoria.SelectedItem)["IdCategoria"]);
            int descuento = Convert.ToInt32(((DataRowView)cmbDescuento.SelectedItem)["IdDescuento"]);

            // Verificar si alguna variable está vacía o nula
            if (string.IsNullOrEmpty(codigo) ||
                string.IsNullOrEmpty(marca) ||
                string.IsNullOrEmpty(modelo) ||
                string.IsNullOrEmpty(descripcion) ||
                string.IsNullOrEmpty(cantidad) ||
                string.IsNullOrEmpty(precio))
            {
                Alertas.Advertencia("Por favor, complete todos los campos antes de registrar.");
                return;
            }

            // Verificar si ya existe un registro con el mismo codigo
            DataTable dt = consulta.Buscar("Productos", "Codigo", $"Codigo = '{codigo}'");
            if (dt.Rows.Count > 0)
            {
                Alertas.Advertencia("Ya existe un producto registrado con el mismo codigo.");
                return;
            }

            string columnas = "Codigo, Marca, Modelo, Precio, Stock, IdCategoria, IdDescuento, Descripcion";
            string valores = $"'{codigo}', '{marca}', '{modelo}', '{precio}', '{cantidad}', '{categoria}', '{descuento}', '{descripcion}'";

            if (consulta.Guardar("Productos", columnas, valores))
            {
                Alertas.Realizado($"Se registro con éxito");

                limpiarCampos();
                MostrarRegistros($"Stock > 0");
                rbConStock.Checked = true;
                HabilitarNuevosRegistros(false);
                
            }
            else
            {
                Alertas.Advertencia("No se pudo guardar el producto. Intente nuevamente.");
            }

        }

        private void MostrarRegistros(string condicion)
        {
            try
            {
                string columnas = "IdProducto, Codigo, Marca, Modelo, Precio, Stock, IdCategoria, IdDescuento, Descripcion";
                //condicion = $"Stock > 0";

                DataTable dt = consulta.Buscar("Productos", columnas, condicion);

                dgvDatos.DataSource = dt;
                dgvDatos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvDatos.Refresh();
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al mostrar registros: {ex.Message}");
            }
        }

        void EnviarDatosParaEditar(DataGridViewCellEventArgs e)
        {
            try
            {
                object valorId = dgvDatos.Rows[e.RowIndex].Cells["IdProducto"].Value;

                if (e.RowIndex < 0 || e.ColumnIndex < 0)
                {
                    MessageBox.Show("Debe seleccionar un registro valido.");
                    return;
                }

                if (valorId == null || valorId == DBNull.Value)
                {
                    Alertas.Advertencia("Este registro esta vacio. Seleccione un registro valido.");
                    return;
                }

                lblOperacion.Text = "Editando";
                lblOperacion.Visible = true;

                if (e.RowIndex >= 0)
                {
                    DataGridViewRow fila = dgvDatos.Rows[e.RowIndex];

                    // Asignar los valores de la fila a los controles del formulario
                    txtIdProducto.Text = fila.Cells["IdProducto"].Value.ToString();
                    txtCodigo.Text = fila.Cells["Codigo"].Value.ToString();
                    txtMarca.Text = fila.Cells["Marca"].Value.ToString();
                    txtModelo.Text = fila.Cells["Modelo"].Value.ToString();
                    txtPrecio.Text = fila.Cells["Precio"].Value.ToString();
                    txtCantidad.Text = fila.Cells["Stock"].Value.ToString();
                    cmbCategoria.SelectedValue = fila.Cells["IdCategoria"].Value;
                    cmbDescuento.SelectedValue = fila.Cells["IdDescuento"].Value;
                    txtDescripcion.Text = fila.Cells["Descripcion"].Value.ToString();
                }

                HabilitarNuevosRegistros(true);

                // Configurar visibilidad y habilitación de botones según el estado
                /*  if (lblEstado.Text == "Activo")
                  {
                      btnDesactivarRegistro.Enabled = true;
                      btnReactivarRegistro.Enabled = false;
                      HabilitarNuevosRegistros(true);
                  }
                  else if (lblEstado.Text == "Inactivo")
                  {
                      lblEstado.Visible = true;
                      btnDesactivarRegistro.Enabled = false;
                      btnReactivarRegistro.Enabled = true;
                      HabilitarNuevosRegistros(true);
                  }*/

                lblOperacion.Visible = false;
            }
            catch (Exception ex)
            {
                Alertas.Advertencia($"Error al cargar datos: {ex.Message}");
                lblOperacion.Visible = false;
            }
        }

        void ActualizarProducto()
        {
            string msg = "¿Desea actualizar este Producto?";
            if (Alertas.Confirmacion(msg))
            {
                try
                {
                    // Obtener los valores del formulario
                    int idProducto = int.Parse(txtIdProducto.Text);
                    string codigo = txtCodigo.Text.Trim();
                    string marca = txtMarca.Text.Trim();
                    string modelo = txtModelo.Text.Trim();
                    string precio = txtPrecio.Text.Trim();
                    string cantidad = txtCantidad.Text.Trim();
                    string descripcion = txtDescripcion.Text.Trim();


                    int categoria = Convert.ToInt32(((DataRowView)cmbCategoria.SelectedItem)["IdCategoria"]);
                    int descuento = Convert.ToInt32(((DataRowView)cmbDescuento.SelectedItem)["IdDescuento"]);

                    string actualizar = $"Codigo = '{codigo}', " +
                                        $"Marca = '{marca}', " +
                                        $"Modelo = '{modelo}', " +
                                        $"Precio = '{precio}', " +
                                        $"Stock = '{cantidad}', " +
                                        $"IdCategoria = '{categoria}', " +
                                        $"IdDescuento = '{descuento}', " +
                                        $"Descripcion = '{descripcion}'";

                    string condicion = $"IdProducto = '{idProducto}'";

                    if (consulta.update("Productos", actualizar, condicion) > 0)
                    {
                        Alertas.Realizado("El producto se actualizo con exito");
                        limpiarCampos();
                        MostrarRegistros($"Stock > 0");
                        HabilitarNuevosRegistros(false);                        
                        rbConStock.Checked = true;
                    }
                    else
                    {
                        Alertas.Advertencia("Error al actualizar el producto, intente de nuevo");
                    }
                }
                catch (Exception ex)
                {
                    Alertas.Advertencia($"Error al actualizar, pruebe de otra manera: {ex.Message}");
                }
            }
        }

        private void FormProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoRegistro_Click(object sender, EventArgs e)
        {
            lblOperacion.Text = "Registrando";
            HabilitarNuevosRegistros(true);
        }

        private void btnGuardarRegistro_Click(object sender, EventArgs e)
        {
            if (lblOperacion.Text == "Registrando")
            {
                GuardarProducto();
            }
            else if (lblOperacion.Text == "Editando")
            {
                ActualizarProducto();
            }
        }

        void filtrar()
        {
            string texto = txtFiltrar.Text.Trim();

            DataTable dt = dgvDatos.DataSource as DataTable;
            if (dt != null)
            {
                dt.DefaultView.RowFilter =
                    $"Convert(Codigo, 'System.String') LIKE '%{texto}%' OR " +
                    $"Marca LIKE '%{texto}%' OR " +
                    $"Modelo LIKE '%{texto}%'";
            }
        
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            limpiarCampos();
            HabilitarNuevosRegistros(false);
            
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EnviarDatosParaEditar(e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTestConexion_Click(object sender, EventArgs e)
        {
            conexion.validarConexion();
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            filtrar();
        }

        private void btnActualizarDGV_Click(object sender, EventArgs e)
        {
            MostrarRegistros($"Stock > 0");
            Alertas.Confirmacion("Datos Actualizados con Exito");
            rbConStock.Checked = true;
        }

        private void rbConStock_CheckedChanged(object sender, EventArgs e)
        {
            MostrarRegistros($"Stock > 0");
        }

        private void rbSinStock_CheckedChanged(object sender, EventArgs e)
        {
            MostrarRegistros($"Stock <= 0");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idProducto = txtIdProducto.Text;
            string condicion = $"IdProducto = {idProducto}";

            string msg = "¿Desea actualizar este Producto?";
            if (Alertas.Confirmacion(msg))
            {
                consulta.Eliminar("Productos", condicion.ToString());
                Alertas.Realizado("El producto se elimino con exito");
                MostrarRegistros($"Stock > 0");
            }

        }
    }
}
