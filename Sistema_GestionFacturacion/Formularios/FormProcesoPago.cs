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
    public partial class FormProcesoPago : Form
    {
        int idPedidoGlobal;
        string nombreClienteGlobal;
        string apellidoClienteGlobal;
        decimal totalPagarGlobal;

        public ClaseProcesoPago procesoPago;
        private FormPedidos f1;

        public FormProcesoPago(FormPedidos formPedidos, int idPedido, string nombreCliente, string apellidoCliente, decimal TotalPagar)
        {
            InitializeComponent();

            f1 = formPedidos; 

            idPedidoGlobal = idPedido;
            nombreClienteGlobal = nombreCliente;
            apellidoClienteGlobal = apellidoCliente;
            totalPagarGlobal = TotalPagar;

            cmbMetodoPago.SelectedIndex = 0;
        }


        private void FormProcesoPago_Load(object sender, EventArgs e)
        {
            txtIDPedido.Text = idPedidoGlobal.ToString();
            txtNombre.Text = nombreClienteGlobal;
            txtApellido.Text = apellidoClienteGlobal;
            txtTotalPagar.Text = totalPagarGlobal.ToString("C2");


        }
        void TipoPago()
        {
            string tipoPago = cmbMetodoPago.SelectedItem.ToString();

            string transferencia = "Transferencia";
            string efectivo = "Efectivo";

            if (tipoPago == transferencia)
            {
                lblTarjetaEfectivo.Text = "Número de Tarjeta:";
                lblCvcCambio.Text = "CVC de Tarjeta:";

                txtCVCCambio.Enabled = true;
            }
            else if (tipoPago == efectivo)
            {
                lblTarjetaEfectivo.Text = "Efectivo Recibido:";
                lblCvcCambio.Text = "Cambio a Entregar:";

                txtCVCCambio.Enabled = false;
            }
        }

        void EventoTextChanged()
        {
            string tipoPago = " ";
            string efectivo = "Efectivo";
            
            if (tipoPago == efectivo)
            {
                decimal efectivoRecibido = 0;
                decimal cambio = 0;
                if (decimal.TryParse(txtCVCCambio.Text, out efectivoRecibido))
                {
                    cambio = efectivoRecibido - totalPagarGlobal;
                    txtCVCCambio.Text = cambio.ToString("C2");
                }
                else
                {
                    txtCVCCambio.Text = "00.00";
                }
            }
        }

        void EnviarAFormPedidos()
        {
            string tipoPago = cmbMetodoPago.SelectedItem.ToString();
            string estadopago = "Facturado";

            ClaseProcesoPago procesoPago = new ClaseProcesoPago(estadopago, tipoPago);

            f1.GuardarDetallesPedido(procesoPago);

            this.Close();
        }

        private void cmbMetodoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            TipoPago();
        }

        private void txtCVCCambio_TextChanged(object sender, EventArgs e)
        {
            //EventoTextChanged();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            EnviarAFormPedidos();
        }

        private void txtTarjetaEfectivo_TextChanged(object sender, EventArgs e)
        {
            EventoTextChanged();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
