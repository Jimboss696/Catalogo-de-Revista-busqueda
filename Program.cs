﻿using System;
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
            // 1. Crear un catálogo de revistas utilizando un árbol binario de búsqueda
            ArbolBinarioBusqueda catalogo = new ArbolBinarioBusqueda();  // Instancia del árbol binario de búsqueda

            // Insertar títulos en el árbol
            catalogo.Insertar("Estadio");
            catalogo.Insertar("Time");
            catalogo.Insertar("Hogar");
            catalogo.Insertar("Vistazo");
            catalogo.Insertar("Pyx Art");
            catalogo.Insertar("VITAE");
            catalogo.Insertar("Locura");
            catalogo.Insertar("El cometa");
            catalogo.Insertar("Gamer");
            catalogo.Insertar("Estructura de datos");

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

                        // Llamar al método de búsqueda en el árbol binario
                        if (catalogo.Buscar(tituloBuscado))  // Si el título se encuentra
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
    }
}
