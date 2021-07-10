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
            linked.InsertAtLast(56);
            linked.InsertAtLast(30);
            linked.InsertAtLast(70);
            linked.search(70);
            linked.DisplayList();
            Console.ReadLine();
        }
    }
}
