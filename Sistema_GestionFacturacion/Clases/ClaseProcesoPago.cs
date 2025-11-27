using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_GestionFacturacion.Clases
{
    public class ClaseProcesoPago
    {

        public string MetodoPago { get; set; }
        public string EstadoPago { get; set; }

        public ClaseProcesoPago(string estadoPago, string metodoPago)
        {
            EstadoPago = estadoPago;
            MetodoPago = metodoPago;            
        }
    }
}
