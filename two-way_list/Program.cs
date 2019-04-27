using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_way_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lista = new List<int>();
            lista.InsertLast(5);
            lista.InsertLast(6);
            lista.InsertLast(7);
            lista.Iteratorforward = lista.Head;
            lista.Iteratorforward++;
            Console.WriteLine(lista.Iteratorforward.data);
            Console.WriteLine(lista.Last.data);
            Console.ReadKey();
        }
    }
}
