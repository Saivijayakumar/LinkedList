using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        /// <summary>
        /// ---------->Welcome To LinkedList<--------------
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("\t\t---------->Welcome To LinkedList<--------------\n");
            LinkedListMethods linked = new LinkedListMethods();
            linked.InsertForSort(56);
            linked.InsertForSort(30);
            linked.InsertForSort(40);
            linked.InsertForSort(70);
            linked.ValueAre();
            linked.DisplayList();
            Console.ReadLine();
        }
    }
}
