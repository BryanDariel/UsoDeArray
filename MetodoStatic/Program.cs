using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsoDeArrays
{
    public class UsoDeArray
    {
        private static int[] valoresInt = { 1, 2, 3, 4, 5, 6 };
        private static double[] valoresDouble = { 8.4, 9.3, 0.2, 7.9, 3.4 };
        private static int[] copiaValoresInt;
        public static void Main(string[] args)
        {
            copiaValoresInt = new int[valoresInt.Length]; // los valores predeterminados son cero
            Console.WriteLine("Valores iniciales del arreglo:\n");
            ImprimirArreglos();   // imprime el contenido inicial del arreglo

            // ordena valoresDouble
            Array.Sort(valoresDouble);

            //copia valoresInt a copiaValoresInt
            Array.Copy(valoresInt, copiaValoresInt, valoresInt.Length);
            Console.WriteLine("\nValores del arreglo después de Sort y Copy:\n");

            ImprimirArreglos();   // imprime el contenido del arreglo
            Console.WriteLine();

            // busca el 5 en valoresInt
            int resultado = Array.BinarySearch(valoresInt, 5);
            if (resultado >= 0)
                Console.WriteLine("Se encontró el 5 en el elemento {0} de valoresInt", resultado);
            else
                Console.WriteLine("No se encontró el 5 en valoresInt");

            // busca el 8763 en valoresInt
            resultado = Array.BinarySearch(valoresInt, 8763);
            if (resultado >= 0)
                Console.WriteLine("Se encontró el 8763 en el elemento {0} de valoresInt", resultado);
            else
                Console.WriteLine("No se encontró el 8763 en valoresInt");
        }// fin del método Main

        //Imprime el contenido del arreglo con enumeradores
        private static void ImprimirArreglos()
        {
            Console.Write("valoresDouble: ");

            // Itera a través del arreglo double con un enumerador  
            IEnumerator enumerador = valoresDouble.GetEnumerator();
            while (enumerador.MoveNext())
                Console.Write(enumerador.Current + " ");
            Console.Write("\nvaloresInt: ");

            // itera a través del arreglo int con un enumerador
            enumerador = valoresInt.GetEnumerator();
            while (enumerador.MoveNext())
                Console.Write(enumerador.Current + " ");
            Console.Write("\ncopiaValoresInt: ");

            //Itera a través del segundo arreglo int con una instrucción foreach
            foreach (int elemento in copiaValoresInt)
                Console.Write(elemento + " ");
            Console.WriteLine();

        }// Fin del método ImprimirArreglos
    }// Fin de la clase UsoDeArray
}