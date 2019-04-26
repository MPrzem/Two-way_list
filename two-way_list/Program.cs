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
            lista.InsertFront(5);
            lista.InsertFront(6);
            lista.InsertFront(7);
            Console.WriteLine(lista.Last.data);
            Console.ReadKey();
        }
    }
}
