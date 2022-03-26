using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_I_2022_I_P2_PROYECTO2.Objetos
{
    internal class ClienteList
    {
        public List<Cliente> clienteList { get; set; }

        public ClienteList()
        {
            this.clienteList = new List<Cliente>();
        }

        public void Add (Cliente pNombre)
        {

            clienteList.Add (pNombre);

        }
        public  Cliente Search (string pNombre)
        {
            if (clienteList==null)
            {
                return null;
            }
            foreach (var cliente in clienteList)
            {
                if (cliente.Nombre== pNombre)
                {
                    return cliente;
                }
            }
            return null;

        }

        public void Delete (string pNombre)
        {

            foreach (var Cliente in clienteList)
            {
                if (Cliente.Nombre == pNombre)
                {
                    clienteList.Remove(Cliente);
                    break;
                }
            }
        }

        public Cliente Update (Cliente PNombre)
        {
            if (clienteList == null)
            {
                return null;
            }
            foreach (var cliente in clienteList)
            {
                if (cliente.Nombre == PNombre.Nombre)
                {
                    cliente.Nombre = PNombre.Nombre;
                    cliente.Apellido= PNombre.Apellido;
                    cliente.Id = PNombre.Id;
                    cliente.RTN = PNombre.RTN;
                    cliente.TarjetaoEfectivo= PNombre.TarjetaoEfectivo;
                    cliente.LLeveroComerRestaurante = PNombre.LLeveroComerRestaurante;
                    cliente.FacturaTotal = PNombre.FacturaTotal;

                    return cliente;
                }
            }
            return null;

        }

        }
    }
