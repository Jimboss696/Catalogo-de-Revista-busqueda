using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo_de_Revista_busqueda
{
    // Definición del árbol binario de búsqueda
    class ArbolBinarioBusqueda
    {
        public Nodo Raiz;  // Nodo raíz del árbol

        public ArbolBinarioBusqueda()
        {
            Raiz = null;
        }

        // Método para insertar un nuevo nodo en el árbol
        public void Insertar(string titulo)
        {
            Raiz = InsertarRecursivo(Raiz, titulo);  // Llamar al método recursivo para insertar
        }

        private Nodo InsertarRecursivo(Nodo nodo, string titulo)
        {
            if (nodo == null)  // Si el nodo es null, se ha encontrado el lugar correcto para insertar
            {
                nodo = new Nodo(titulo);
                return nodo;
            }

            // Si el título es menor al nodo actual, va al subárbol izquierdo
            if (string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
                nodo.Izquierdo = InsertarRecursivo(nodo.Izquierdo, titulo);
            // Si el título es mayor al nodo actual, va al subárbol derecho
            else if (string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) > 0)
                nodo.Derecho = InsertarRecursivo(nodo.Derecho, titulo);

            return nodo;  // Retorna el nodo (sin cambios si ya existe)
        }

        // Método para buscar un título en el árbol
        public bool Buscar(string titulo)
        {
            return BuscarRecursivo(Raiz, titulo);  // Llamar al método recursivo para buscar
        }

        private bool BuscarRecursivo(Nodo nodo, string titulo)
        {
            if (nodo == null)  // Si el nodo es null, el título no se encontró
                return false;

            // Si el título es igual al nodo actual, lo hemos encontrado
            if (nodo.Titulo.Equals(titulo, StringComparison.OrdinalIgnoreCase))
                return true;

            // Si el título buscado es menor, sigue buscando en el subárbol izquierdo
            if (string.Compare(titulo, nodo.Titulo, StringComparison.OrdinalIgnoreCase) < 0)
                return BuscarRecursivo(nodo.Izquierdo, titulo);

            // Si el título buscado es mayor, sigue buscando en el subárbol derecho
            return BuscarRecursivo(nodo.Derecho, titulo);
        }
    }
}
