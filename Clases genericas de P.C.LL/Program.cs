using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_genericas_de_P.C.LL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Pila
            int res = 0;
            Stack<int> Mi_pila = new Stack<int>();
            Mi_pila.Push(20);
            Mi_pila.Push(13);
            Mi_pila.Push(53);
            Console.WriteLine(" == Mi pila == ");
            foreach (var i in Mi_pila)
            {
                Console.WriteLine("-- " + i);
                res += i;
            }
            Console.WriteLine("La suma de los elemntos de la pila es: " + res);
            Console.ReadKey();
            #endregion

            #region Cola
            Console.Clear();
            double dou_res = 1.00;
            Queue<double> Mi_cola = new Queue<double>();
            Mi_cola.Enqueue(1.5);
            Mi_cola.Enqueue(12.4);
            Mi_cola.Enqueue(32.8);
            Mi_cola.Enqueue(.89);
            Mi_cola.Enqueue(18.9);
            Console.WriteLine("== Mi cola == ");
            foreach (var i in Mi_cola)
            {
                Console.WriteLine("-- " + i);
                dou_res *= i;
            }
            Console.WriteLine("Multiplicacion es: " + dou_res);
            Console.ReadKey();
            #endregion

            #region Lista_enlazada
            Console.Clear();
            LinkedList<string> Mi_linked_list = new LinkedList<string>();
            Mi_linked_list.AddLast("A");
            Mi_linked_list.AddLast("B");
            Mi_linked_list.AddLast("C");

            Console.WriteLine("== Lista enlazada == ");
            foreach (var item in Mi_linked_list)
            {
                Console.WriteLine("-- " + item);
            }

            LinkedListNode<string> nodo = Mi_linked_list.Find("B");
            if (nodo != null)
            {
                Mi_linked_list.AddAfter(nodo, "D");
            }

            Console.WriteLine("\n== Lista enlazada después de insertar 'D' ==");
            foreach (var item in Mi_linked_list)
            {
                Console.WriteLine("-- " + item);
            }
            Console.ReadKey();
            #endregion
        }
    }
}
