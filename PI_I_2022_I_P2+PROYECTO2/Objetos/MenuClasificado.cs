using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_I_2022_I_P2_PROYECTO2.Objetos
{
    internal class MenuClasificado
    {
        public void AgregarCliente()
        {
            var clientenew = new Cliente();

            try
            {
                WriteLine("Ingrese el Nombre");
                var nombre = ReadLine();
                var clienteSerach =  != null ? cliente.Search(nombre):null;
                if (clienteSearch == null)
                {
                    clientenew.Nombre= nombre;
                    WriteLine("Nombre");
                    clientenew.Nombre = ReadLine();

                    WriteLine("Apellido");
                    clientenew.Apellido= ReadLine();

                    WriteLine("su ID");
                    clientenew.Id= ReadLine();

                    WriteLine("Numero de telefono");
                    clientenew.NumeroTelefono= ReadLine();

                    WriteLine("Rtn");
                    clientenew.RTN = ReadLine();

                    WriteLine("Llevar  o comer  en el restaurante");
                    clientenew.LLeveroComerRestaurante= ReadLine();

        
                    WriteLine("Tarjeta  o efectivo");
                    clientenew.TarjetaoEfectivo = ReadLine();
                    clienteList.Add(clientenew);
                    JsonText = JsonConvert.SerializeObject(clienteList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsonText);
                    WriteLine("Guardano exitosamente");
                }

                else
                {
                    WriteLine("Nombre del cliente Icorrecto intente otra vez");
                    AgregarCliente();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

                WriteLine(ex.Message);
            }
        }



        public void ACtualizarCliente()
        {
            try
            {
                WriteLine("Ingrese el Nombre");
                var nombre = ReadLine();
                var clienteSearch = cliente.Search(nombre);
                if (clienteSearch != null)
                {
                    clienteSearch.Nombre = nombre;
                    WriteLine("Nombre");
                    clienteSearch.Nombre = ReadLine();

                    WriteLine("Apellido");
                    clienteSearch.Apellido = ReadLine();

                    WriteLine("su ID");
                    clienteSearch.Id = ReadLine();

                    WriteLine("Numero de telefono");
                    clienteSearch.NumeroTelefono = ReadLine();

                    WriteLine("Rtn");
                    clienteSearch.RTN = ReadLine();

                    WriteLine("Llevar  o comer  en el restaurante");
                    clienteSearch.LLeveroComerRestaurante = ReadLine();


                    WriteLine("Tarjeta  o efectivo");
                    clientenew.TarjetaoEfectivo = ReadLine();
                    clienteList.Update(clientenew);
                    JsonText = JsonConvert.SerializeObject(clienteList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsonText);
                    WriteLine("Actuaiozado  exitosamente");
                }

                else
                {
                    WriteLine("Nombre del Cliente  Icorrecto intente otra vez");
                    ACtualizarCliente();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine(ex.Message);

            }
        }


        public void ElimiarCliente()
        {
            try
            {
                WriteLine("Ingrese el Nombre");
                var nombre = ReadLine();
                var clienteSearch = cliente.Search(nombre);
                if (clienteSearch != null)
                {
                    clienteList.Delete(nombre);
                    jsonText = JsonConvert.SerializeObject(clienteList, Formatting.Indented);
                    File.WriteAllText(FILENAME, jsonText);
                    WriteLine("Actualizado exitosamente");
                }

                else
                {
                    WriteLine(" Nombre del cliente Icorrecto intente, otra vez");
                    ElimiarCliente();
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {

                WriteLine(ex.Message);
            }
        }


        public void ListarCliente()
        {
            try
            {
                if (clienteList != null)
                {
                    WriteLine("Clientes  Existentes");
                    foreach (var cliente in clienteList.clienteList)
                    {
                        WriteLine($"Nombre:{cliente.Nombre}");
                        WriteLine($"Apellido:{cliente.Apellido}");
                        WriteLine($"RTN:{cliente.RTN}");
                        WriteLine($"NUmero de telefono{cliente.Numerotelefono}");
                        WriteLine($"Llevar o comer en restaurante{cliente.LLevarocomerrestaurante}");
                        WriteLine($"pago contar targenta  o  efectivo{cliente.Targetaoefectivo}");
                    }
                    WriteLine("Cliente final");
                }

                else
                {
                    WriteLine("Arcvho vacio del cliente , intente otra vez");
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {

                WriteLine(ex.Message);
            }
        }


        public void BuscarBook()
        {
            try
            {
                bool found = false;
                WriteLine("Ingrese el Id");
                var nombre = ReadLine();

                if (clienteList != null)
                {
                    foreach (var cliente in clienteList.clienteList)
                    {
                        if (nombre.nombre == nombre)
                        {
                            WriteLine($"Nombre:{cliente.Nombre}");
                            WriteLine($"Apellido:{cliente.Apellido}");
                            WriteLine($"RTN:{cliente.RTN}");
                            WriteLine($"NUmero de telefono{cliente.Numerotelefono}");
                            WriteLine($"Llevar o comer en restaurante{cliente.LLevarocomerrestaurante}");
                            WriteLine($"pago contar targenta  o  efectivo{cliente.Targetaoefectivo}");
                            found = true;
                        }

                    }
                    if (found)
                    {
                        WriteLine("Sacticfatorio");
                    }
                    else
                    {
                        WriteLine("No encontrado");
                    }

                }
                else
                {
                    WriteLine("Archivo vacio del Cliente ");
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine(ex.Message);

            }
        }
    } 
}
