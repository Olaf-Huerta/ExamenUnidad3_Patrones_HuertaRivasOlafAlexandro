using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaDecoCompo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
 
                var generador = new GeneradorPlantillas();
                var menu = new MenuPersonalizador();

                IComponenteDocumento documentoBase = null;
                string nombrePlantilla = "";

                bool plantillaValida = false;
                while (!plantillaValida)
                {
                    Console.Clear();
                    Console.WriteLine("Generador de Documentos");
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("1. CV");
                    Console.WriteLine("2. Folleto");
                    Console.WriteLine("3. Certificado");
                    Console.WriteLine("4. Factura");
                    Console.WriteLine("5. Salir"); 
                    Console.Write("\nElige la plantilla deseada: ");
                    string tipo = Console.ReadLine();

                    switch (tipo)
                    {
                        case "1":
                            documentoBase = generador.CrearBaseCV();
                            documentoBase = menu.PersonalizarCV(documentoBase);
                            nombrePlantilla = "CV";
                            plantillaValida = true;
                            break;
                        case "2":
                            documentoBase = generador.CrearBaseFolleto();
                            documentoBase = menu.PersonalizarFolleto(documentoBase);
                            nombrePlantilla = "Folleto";
                            plantillaValida = true;
                            break;
                        case "3":
                            documentoBase = generador.CrearBaseCertificado();
                            documentoBase = menu.PersonalizarCertificado(documentoBase);
                            nombrePlantilla = "Certificado";
                            plantillaValida = true;
                            break;
                        case "4":
                            documentoBase = generador.CrearBaseFactura();
                            documentoBase = menu.PersonalizarFactura(documentoBase);
                            nombrePlantilla = "Factura";
                            plantillaValida = true;
                            break;
                        case "5":
                            return;
                        default:
                            Console.WriteLine("Opción no válida."); Console.ReadKey(true);
                            break;
                    }
                }

                Console.Clear();
                Console.WriteLine("PLANTILLA PERSONALIZADA GENERADA");
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Plantilla Base: {nombrePlantilla}");
                Console.WriteLine("Componentes Añadidos:");

                string componentesAñadidos = documentoBase.GenerarDescripcion();

                if (string.IsNullOrEmpty(componentesAñadidos))
                {
                    Console.WriteLine("(Ninguno)");
                }
                else
                {
                    Console.Write(componentesAñadidos);
                }

                Console.WriteLine("--------------------------------");

       
                Console.WriteLine("\nPresiona Enter para regresar al menú.");
                Console.ReadLine();
            }
        }
    }
}
