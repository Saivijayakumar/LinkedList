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
            linked.InsertAtFirst(30);
            linked.InsertAtFirst(56);
            linked.DisplayList();
            Console.ReadLine();
        }
    }
}
