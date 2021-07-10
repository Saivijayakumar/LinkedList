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
        //This will work for this UC only.
        public void InsertNode(int data)
        {
            Node newnode = new Node(data);
            if(this.head == null)
            {
                Console.WriteLine("The List is empty");
            }
            else
            {
                this.head.next = newnode;
                newnode.next = this.tail;
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
