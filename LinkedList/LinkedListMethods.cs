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
        //For storing user values
        public List<int> array = new List<int>();
        public void InsertForSort(int data)
        {
            array.Add(data);
            Node newnode = new Node(data);
            if(head == null)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                Node previous = null;
                Node current = this.head;
                while(current != null && current.data < data)
                {
                    previous = current;
                    current = current.next;
                }
                if(current == this.head)
                {
                    //Insert At Start logic
                    newnode.next = current;
                    this.head = newnode;//update head
                }
                else
                {
                    //Insert At Middle and Last logic
                    newnode.next = current;
                    previous.next = newnode;
                    this.tail = newnode;//update tail
                }
            }
        }
        //Displaying user values 
        public void ValueAre()
        {
            Console.WriteLine("The values given by user");
            foreach(int i in array)
            {
                Console.Write(i+" , ");
            }
        }
        public void DisplayList()
        {
            Console.WriteLine("\nValues  In Linkedlist Now In Assending Order ");
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
