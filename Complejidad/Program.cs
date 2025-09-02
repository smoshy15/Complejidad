namespace Complejidad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProfundidadDeArbolBinario arbolito = new ProfundidadDeArbolBinario(10);

            // Insertamos hijos
            arbolito.Arbol.insertarhijoizquierdo(5);
            arbolito.Arbol.insertarhijoderecho(15);

            arbolito.Arbol.HijoIzquierdo.insertarhijoizquierdo(3);
            arbolito.Arbol.HijoIzquierdo.insertarhijoderecho(7);

            arbolito.Arbol.HijoDerecho.insertarhijoderecho(20);

            // Probamos el método SumaElementosProfundidad
            Console.WriteLine("Suma en profundidad 0: " + arbolito.SumaElementosProfundidad(0)); // 10
            Console.WriteLine("Suma en profundidad 1: " + arbolito.SumaElementosProfundidad(1)); // 5 + 15 = 20
            Console.WriteLine("Suma en profundidad 2: " + arbolito.SumaElementosProfundidad(2)); // 3 + 7 + 20 = 30
        }
    }
}
