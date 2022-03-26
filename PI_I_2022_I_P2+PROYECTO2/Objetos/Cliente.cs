using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_I_2022_I_P2_PROYECTO2.Objetos
{
    internal class Cliente
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Id { get; set; }
        public string NumeroTelefono { get; set; }
        public string RTN { get; set; }
        public string TarjetaoEfectivo { get; set; }
        public string LLeveroComerRestaurante { get; set; }
        private decimal facturaTotal;

        public Cliente(string pNombre, string pApellido, string pId, string pNumeroTelefono, string pRTN, 
            string pTarjetaoEfectivo, string plLeveroComerRestaurante)
        {
            this.Nombre                   = pNombre;
            this.Apellido                 = pApellido;
            this.Id                       = pId;
            this.NumeroTelefono           = pNumeroTelefono;
            this.RTN                      = pRTN;
            this.TarjetaoEfectivo         = pTarjetaoEfectivo;
            this.LLeveroComerRestaurante  = plLeveroComerRestaurante;
            
           
        }

        public Cliente()
        {
        }

        public decimal FacturaTotal
        {
            get { return facturaTotal; }
            set
            {

                if (value < 0)
                {
                    WriteLine("DEBE DE SER MAYOY A CERO SU FACTURA");
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(facturaTotal)} deberia ser > 0 el pago");
                }
                if (value > 1)
                {
                    WriteLine("EXITOSO");
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(facturaTotal)} deberia ser > 0 el pago");
                }
                facturaTotal = value;
            }

        }
        public override string ToString() =>
            $"Nombre es:{Nombre}\n" +
            $"Numero de Apellido:{Apellido}\n" +
            $"Numero de Telefeno{NumeroTelefono}\n" +
            $"Su id es:{Id}\n" +
            $"Para comer aqui o para llevar:{LLeveroComerRestaurante}\n" +
            $"RTN:{RTN}\n" +
            $"paga con Tarjeta o Efetivo:{TarjetaoEfectivo}\n";

    }
}
