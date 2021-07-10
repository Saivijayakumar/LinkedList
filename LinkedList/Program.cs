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
            linked.InsertAtFirst(70);
            linked.InsertAtFirst(56);
            Console.WriteLine("\nBefore Inser the linkedlist contains");
            linked.DisplayList();
            Console.WriteLine("\nAfter Inser the linkedlist contains");
            linked.InsertNode(30);
            linked.DisplayList();
            Console.ReadLine();
        }
    }
}
