namespace Complejidad
{
    public class ProfundidadDeArbolBinario
    {
        private ArbolBinario<int> arbol;

        
        public ProfundidadDeArbolBinario(int nodoraiz)
        {
            arbol = new ArbolBinario<int>(nodoraiz);
        }

        public ArbolBinario<int> Arbol 
        { 
            get { return arbol; } 
        }

        // Método que devuelve la suma de todos los nodos en la profundidad p
        public int SumaElementosProfundidad(int p)
        {
            return SumaRecursiva(arbol, 0, p);
        }

        private int SumaRecursiva(ArbolBinario<int> nodo, int nivelActual, int nivelBuscado)
        {
            if (nodo == null) return 0;

            if (nivelActual == nivelBuscado)
                return nodo.Dato;

            return SumaRecursiva(nodo.HijoIzquierdo, nivelActual + 1, nivelBuscado) +
                   SumaRecursiva(nodo.HijoDerecho, nivelActual + 1, nivelBuscado);
        }
    }
}
