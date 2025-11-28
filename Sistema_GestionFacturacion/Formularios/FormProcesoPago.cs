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
        AlertasDelSistema Alertas = new AlertasDelSistema();
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
            txtTotalPagar.Text = totalPagarGlobal.ToString(/*"C2"*/);


        }
        void TipoPago()
        {
            if (cmbMetodoPago.SelectedItem == null)
                return;

            string tipoPago = cmbMetodoPago.SelectedItem.ToString();

            string transferencia = "Transferencia";
            string efectivo = "Efectivo";

            if (tipoPago == transferencia)
            {
                lblTarjetaEfectivo.Text = "Número de Tarjeta:";
                lblCvcCambio.Text = "CVC de Tarjeta:";

                txtTarjetaEfectivo.Enabled = true;
                txtTarjetaEfectivo.ReadOnly = false;

                txtCVCCambio.Enabled = true;
                txtCVCCambio.ReadOnly = false;

                txtTarjetaEfectivo.Clear();
                txtCVCCambio.Clear();

                txtTarjetaEfectivo.PlaceholderText = "0000 0000 0000 0000";
                txtCVCCambio.PlaceholderText = "000";
            }
            else if (tipoPago == efectivo)
            {
                lblTarjetaEfectivo.Text = "Efectivo Recibido:";
                lblCvcCambio.Text = "Cambio a Entregar:";

                txtTarjetaEfectivo.Enabled = true;
                txtTarjetaEfectivo.ReadOnly = false;

                txtCVCCambio.Enabled = false;  
                txtCVCCambio.ReadOnly = true;

                txtTarjetaEfectivo.Clear();
                txtCVCCambio.Clear();

                txtTarjetaEfectivo.PlaceholderText = "00.00";
                txtCVCCambio.PlaceholderText = "00.00";
            }
        }

        bool ValidarTransferencia()
        {
            // Validar tarjeta: exactamente 16 digitos
            if (!txtTarjetaEfectivo.Text.All(char.IsDigit) || txtTarjetaEfectivo.Text.Length != 16)
            {
                Alertas.Advertencia("El numero de tarjeta debe tener exactamente 16 digitos numericos.");
                return false;
            }

            // Validar CVC: exactamente 3 digitos
            if (!txtCVCCambio.Text.All(char.IsDigit) || txtCVCCambio.Text.Length != 3)
            {
                Alertas.Advertencia("El CVC debe tener exactamente 3 dígitos numericos.");
                return false;
            }

            return true;
        }

        bool ValidarEfectivo()
        {
            decimal efectivo;

            // Verificar que sea numero decimal valido
            if (!decimal.TryParse(txtTarjetaEfectivo.Text, out efectivo))
            {
                MessageBox.Show("Ingrese un monto válido en efectivo.");
                return false;
            }

            if (efectivo < totalPagarGlobal)
            {
                MessageBox.Show("El efectivo recibido es menor al total a pagar.");
                return false;
            }

            return true;
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

            string tipoPago = cmbMetodoPago.SelectedItem.ToString();

            if (tipoPago == "Transferencia")
            {
                if (!ValidarTransferencia())
                    return;

                Alertas.Realizado("Pago por transferencia validado.");
            }
            else if (tipoPago == "Efectivo")
            {
                if (!ValidarEfectivo())
                    return;

                Alertas.Realizado("Pago en efectivo validado.");
            }

            EnviarAFormPedidos();
        }

        private void txtTarjetaEfectivo_TextChanged(object sender, EventArgs e)
        {
            if (cmbMetodoPago.SelectedItem == null)
                return;

            // solo calcula cambio si es efectivo
            if (cmbMetodoPago.SelectedItem.ToString() != "Efectivo")
                return;

            // si esta vacio, limpiar y salir SIN BLOQUEAR
            if (string.IsNullOrWhiteSpace(txtTarjetaEfectivo.Text))
            {
                txtCVCCambio.Text = "";
                return;
            }

            // convertir de manera segura
            decimal efectivo;
            bool ok = decimal.TryParse(txtTarjetaEfectivo.Text, out efectivo);

            if (!ok)
            {
                txtCVCCambio.Text = "";
                return;
            }

            // calcular el cambio
            decimal cambio = efectivo - totalPagarGlobal;

            // mostrar con formato monetario
            txtCVCCambio.Text = cambio.ToString("C2");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
