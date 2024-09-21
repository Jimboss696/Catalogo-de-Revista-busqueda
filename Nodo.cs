using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Revista_busqueda
{
    // Definición de un nodo para el árbol binario
    class Nodo
    {
        public string Titulo;  // El valor del nodo es el título de la revista
        public Nodo Izquierdo;  // Hijo izquierdo del nodo
        public Nodo Derecho;  // Hijo derecho del nodo

        public Nodo(string titulo)
        {
            Titulo = titulo;
            Izquierdo = null;
            Derecho = null;
        }
    }
}
