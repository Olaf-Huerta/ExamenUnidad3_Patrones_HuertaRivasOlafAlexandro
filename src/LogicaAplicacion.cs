using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlantillaDecoCompo
{
    public class GeneradorPlantillas
    {
        public IComponenteDocumento CrearBaseCV()
        {
            var cv = new SeccionCompuesta("CV");
            cv.Agregar(new ElementoSimple("Datos Personales"));
            cv.Agregar(new SeccionCompuesta("Experiencia"));
            return cv;
        }
        public IComponenteDocumento CrearBaseFactura()
        {
            var factura = new SeccionCompuesta("Factura");
            factura.Agregar(new SeccionCompuesta("Tabla de Conceptos"));
            return factura;
        }
        public IComponenteDocumento CrearBaseFolleto()
        {
            var folleto = new SeccionCompuesta("Folleto");
            folleto.Agregar(new ElementoSimple("Cara Frontal"));
            return folleto;
        }
        public IComponenteDocumento CrearBaseCertificado()
        {
            var certificado = new SeccionCompuesta("Certificado");
            certificado.Agregar(new ElementoSimple("Nombre del Receptor"));
            return certificado;
        }
    }
    public class MenuPersonalizador
    {
        public IComponenteDocumento PersonalizarCV(IComponenteDocumento doc)
        {
            bool personalizando = true;
            var opcionesElegidas = new List<string>();

            while (personalizando)
            {
                Console.Clear();
                Console.WriteLine("Personalizando CV");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opciones de personalización:");
                Console.WriteLine($"1. Añadir Título {(opcionesElegidas.Contains("1") ? "(Elegido)" : "")}");
                Console.WriteLine($"2. Añadir Foto {(opcionesElegidas.Contains("2") ? "(Elegido)" : "")}");
                Console.WriteLine($"3. Añadir Resumen {(opcionesElegidas.Contains("3") ? "(Elegido)" : "")}");
                Console.WriteLine($"4. Añadir Pie de Página {(opcionesElegidas.Contains("4") ? "(Elegido)" : "")}");
                Console.WriteLine("5. Finalizar");
                string opcion = Console.ReadLine();

                if (opcionesElegidas.Contains(opcion))
                {
                    Console.WriteLine("Opción ya seleccionada. Presiona Enter.");
                    Console.ReadKey(true);
                }
                else
                {
                    switch (opcion)
                    {
                        case "1": doc = new TituloDecorator(doc); opcionesElegidas.Add("1"); 
                            break;

                        case "2": doc = new FotoDecorator(doc); opcionesElegidas.Add("2"); 
                            break;

                        case "3": doc = new ResumenDecorator(doc); opcionesElegidas.Add("3"); 
                            break;

                        case "4": doc = new PieDePaginaDecorator(doc); opcionesElegidas.Add("4"); 
                            break;

                        case "5": personalizando = false; 
                            break;

                        default: Console.WriteLine("Opción no válida."); Console.ReadKey(true); 
                            break;
                    }
                }
            }
            return doc;
        }
        public IComponenteDocumento PersonalizarFactura(IComponenteDocumento doc)
        {
            bool personalizando = true;
            var opcionesElegidas = new List<string>(); 

            while (personalizando)
            {
                Console.Clear();
                Console.WriteLine("Personalizando Factura");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opciones de personalización:");
                Console.WriteLine($"1. Añadir Datos Fiscales {(opcionesElegidas.Contains("1") ? "(Elegido)" : "")}");
                Console.WriteLine($"2. Añadir Información de Impuestos {(opcionesElegidas.Contains("2") ? "(Elegido)" : "")}");
                Console.WriteLine($"3. Añadir Sello Digital {(opcionesElegidas.Contains("3") ? "(Elegido)" : "")}");
                Console.WriteLine($"4. Añadir Pie de Página {(opcionesElegidas.Contains("4") ? "(Elegido)" : "")}");
                Console.WriteLine("5. Finalizar");
                string opcion = Console.ReadLine();

                if (opcionesElegidas.Contains(opcion)) 
                {
                    Console.WriteLine("Opción ya seleccionada. Presiona Enter.");
                    Console.ReadKey(true);
                }
                else
                {
                    switch (opcion)
                    {
                        case "1": doc = new DatosFiscalesDecorator(doc); opcionesElegidas.Add("1"); break;
                        case "2": doc = new DesgloseImpuestosDecorator(doc); opcionesElegidas.Add("2"); break;
                        case "3": doc = new SelloDigitalDecorator(doc); opcionesElegidas.Add("3"); break; 
                        case "4": doc = new PieDePaginaDecorator(doc); opcionesElegidas.Add("4"); break;
                        case "5": personalizando = false; break;
                        default: Console.WriteLine("Opción no válida."); Console.ReadKey(true); break;
                    }
                }
            }
            return doc;
        }

        public IComponenteDocumento PersonalizarFolleto(IComponenteDocumento doc)
        {
            bool personalizando = true;
            var opcionesElegidas = new List<string>(); 

            while (personalizando)
            {
                Console.Clear();
                Console.WriteLine("Personalizando Folleto");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opciones de personalización:");
                Console.WriteLine($"1. Añadir Título {(opcionesElegidas.Contains("1") ? "(Elegido)" : "")}");
                Console.WriteLine($"2. Añadir Gráficos de fondo {(opcionesElegidas.Contains("2") ? "(Elegido)" : "")}");
                Console.WriteLine($"3. Añadir Diseño a Doble Cara {(opcionesElegidas.Contains("3") ? "(Elegido)" : "")}");
                Console.WriteLine($"4. Añadir Pie de Página {(opcionesElegidas.Contains("4") ? "(Elegido)" : "")}"); 
                Console.WriteLine("5. Finalizar");
                string opcion = Console.ReadLine();

                if (opcionesElegidas.Contains(opcion))
                {
                    Console.WriteLine("Opción ya seleccionada. Presiona Enter.");
                    Console.ReadKey(true);
                }
                else
                {
                    switch (opcion)
                    {
                        case "1": doc = new TituloDecorator(doc); opcionesElegidas.Add("1"); break;
                        case "2": doc = new GraficosDecorator(doc); opcionesElegidas.Add("2"); break;
                        case "3": doc = new DobleCaraDecorator(doc); opcionesElegidas.Add("3"); break;
                        case "4": doc = new PieDePaginaDecorator(doc); opcionesElegidas.Add("4"); break;
                        case "5": personalizando = false; break;
                        default: Console.WriteLine("Opción no válida."); Console.ReadKey(true); break;
                    }
                }
            }
            return doc;
        }


        public IComponenteDocumento PersonalizarCertificado(IComponenteDocumento doc)
        {
            bool personalizando = true;
            var opcionesElegidas = new List<string>();

            while (personalizando)
            {
                Console.Clear();
                Console.WriteLine("Personalizando Certificado");
                Console.WriteLine("--------------------------------");
                Console.WriteLine("Opciones de personalización:");
                Console.WriteLine($"1. Añadir Título {(opcionesElegidas.Contains("1") ? "(Elegido)" : "")}");
                Console.WriteLine($"2. Añadir Borde Elegante {(opcionesElegidas.Contains("2") ? "(Elegido)" : "")}");
                Console.WriteLine($"3. Añadir Espacio para Firma {(opcionesElegidas.Contains("3") ? "(Elegido)" : "")}");
                Console.WriteLine($"4. Añadir Pie de Página {(opcionesElegidas.Contains("4") ? "(Elegido)" : "")}");
                Console.WriteLine("5. Finalizar");
                string opcion = Console.ReadLine();

                if (opcionesElegidas.Contains(opcion))
                {
                    Console.WriteLine("Opción ya seleccionada. Presiona Enter.");
                    Console.ReadKey(true);
                }
                else
                {
                    switch (opcion)
                    {
                        case "1": doc = new TituloDecorator(doc); opcionesElegidas.Add("1"); break;
                        case "2": doc = new BordeEleganteDecorator(doc); opcionesElegidas.Add("2"); break;
                        case "3": doc = new FirmaAutorizadaDecorator(doc); opcionesElegidas.Add("3"); break;
                        case "4": doc = new PieDePaginaDecorator(doc); opcionesElegidas.Add("4"); break;
                        case "5": personalizando = false; break;
                        default: Console.WriteLine("Opción no válida."); Console.ReadKey(true); break;
                    }
                }
            }
            return doc;
        }
    }
}
