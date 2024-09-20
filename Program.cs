using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Revista_busqueda
{
    class Program
    {
        static void Main()
        {
            // 1. Crear un catálogo de revistas con 10 títulos
            List<string> catalogo = new List<string>  // Creación de una lista de tipo string para almacenar los títulos de las revistas
        {
            "Estadio",  // Título de revista 1
            "Time",  // Título de revista 2
            "Hogar",  // Título de revista 3
            "Vistazo",  // Título de revista 4
            "Pyx Art",  // Título de revista 5
            "VITAE",  // Título de revista 6
            "Locura",  // Título de revista 7
            "El cometa",  // Título de revista 8
            "Gamer",  // Título de revista 9
            "Estructura de datos"  // Título de revista 10
        };

            // Variable para controlar la salida del programa
            bool salir = false;

            // Bucle para mostrar el menú hasta que el usuario decida salir
            while (!salir)
            {
                // 3. Mostrar un menú con opciones
                Console.ForegroundColor = ConsoleColor.DarkGray;
                Console.WriteLine("+===++++++++++++++++++++++++++++++===+");
                Console.WriteLine("+=====++++---*****__*****---++++=====+");
                Console.WriteLine("\n---**** Catálogo de Revistas ****---");  // Título del menú
                Console.WriteLine("+  1. Buscar un título               +");  // Opción para buscar un título
                Console.WriteLine("+  2. Salir                          +");  // Opción para salir del programa
                Console.WriteLine("+===++++++++++++++++++++++++++++++===+");
                Console.Write("\nSeleccione una opción: ");  // Solicitud de entrada del usuario
                string opcion = Console.ReadLine();  // Captura la opción ingresada por el usuario

                // Evaluar la opción seleccionada
                switch (opcion)
                {
                    case "1":  // Caso para buscar un título
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("Ingrese el título que desea buscar: ");  // Solicitar el título a buscar
                        string tituloBuscado = Console.ReadLine();  // Capturar el título que el usuario ingresa

                        // Llamar a la función de búsqueda iterativa para encontrar el título
                        if (BusquedaIterativa(catalogo, tituloBuscado))  // Si el título se encuentra
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                            Console.WriteLine("Resultado de búsqueda: Encontrado");  // Mostrar que el título fue encontrado
                        }
                        else  // Si el título no se encuentra
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Resultado de búsqueda: No encontrado");  // Mostrar que el título no fue encontrado
                        }
                        break;  // Terminar el caso "1"

                    case "2":  // Caso para salir del programa
                        salir = true;  // Cambiar la variable `salir` a true para terminar el bucle
                        break;  // Terminar el caso "2"

                    default:  // Caso para cuando el usuario ingresa una opción inválida
                        Console.WriteLine("Opción no válida.");  // Mensaje de error
                        break;  // Terminar el caso por defecto
                }
            }
        }

        // Método para realizar una búsqueda iterativa en la lista de revistas
        static bool BusquedaIterativa(List<string> catalogo, string titulo)
        {
            // Recorrer cada elemento (revista) en el catálogo
            foreach (string revista in catalogo)
            {
                // Compara el título buscado con el título de la revista actual, ignorando mayúsculas y minúsculas
                if (revista.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                {
                    return true;  // Si el título es igual, retorna verdadero (encontrado)
                }
            }
            return false;  // Si no se encuentra en toda la lista, retorna falso (no encontrado)
        }
    }
}
