using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedListMethods
    {
        //Creating Both Head and Tail reference
        public Node head;
        public Node tail;
        public void InsertAtLast(int data)
        {
            Node newnode = new Node(data);
            if(head==null)
            {
                //If the list is empty then new node will assign to head and tail
                this.head = this.tail = newnode;
            }
            else
            {
                //linking newnode to tail
                this.tail.next = newnode;
                //changeing the reference
                this.tail = newnode;
            }
        }
        public void DisplayList()
        {
            int count=0;
            Node temp = this.head;
            while(temp!=null)
            {
                Console.WriteLine("At {0} Index We Have {1} value",count,temp.data);
                count++;
                temp = temp.next;
            }
        }
    }
}
