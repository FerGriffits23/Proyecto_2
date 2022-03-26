using Newtonsoft.Json;
using PI_I_2022_I_P2_PROYECTO2.Objetos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PI_I_2022_I_P2_PROYECTO2
{
    internal class Program
    {
         const string FILENAME = @"C:\Users\Fernando\source\repos\PI_I_2022_I_P2+PROYECTO2\PI_I_2022_I_P2+PROYECTO2\bin\Debug\ClienteList.json";
        static ClienteList clienteList= new ClienteList();
         static string jsonText ="";
        static void Main(string[] args)
        {

            jsonText = File.ReadAllText(FILENAME);
            clienteList = JsonConvert.DeserializeObject<ClienteList>(jsonText);
            Program objPogram = new Program();
            char seguir = 'N';

            do
            {
                WriteLine("Selecione una opcion\n1 - Agregar\n2- Actualizar\n3- Eliminar\n4- Listar\n5 -Buscar");
                var opcion = ReadLine();
                switch (opcion)
                {
                    case "1":
                        objPogram.AgregarCliante();
                       
                        break;
                    case "2":
                        objPogram.ActualizarCliente();
                        break;
                    case "3":
                        objPogram.EliminarCliente();
                        break;
                    case "4":
                        objPogram.ListarCliente();
                        break;
                    case "5":
                        objPogram..BuscarCliente();
                        break;
                    default:
                        Main(null);
                        break;
                }
                WriteLine("si desear seguir, tecle s ");
                seguir = char.Parse(ReadLine().Trim());
            } while (seguir.ToString().ToString() == "s");
            ReadLine();
        }



    }
}

