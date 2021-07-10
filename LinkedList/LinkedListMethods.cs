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
        public void InsertAtFirst(int data)
        {
            Node newnode = new Node(data);
            if(this.head == null)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                //linking newnode to head
                newnode.next = this.head;
                //Updating head pointer
                this.head = newnode;
            }
        }
        public void PopLast()
        {
            Node previous = null;
            Node temp = this.head;
            if(head == null)
            {
                Console.WriteLine("LinkedList Is Empty");
            }
            else
            {
                while (temp.next != null)
                {
                    previous = temp;
                    temp = temp.next;
                }
                this.tail = previous;
                previous.next = null;
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
