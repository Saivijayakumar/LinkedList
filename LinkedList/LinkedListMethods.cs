using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListMethods
    {
        //Creating Both Head and Tail reference
        public Node head;
        public Node tail;
        public void InsertAtLast(int data)
        {
            Node newnode = new Node(data);
            if (head == null)
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
        public int search(int data)
        {
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return default;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Console.WriteLine("The value {0} is Present in Linked List", data);
                        return data;
                    }
                    temp = temp.next;
                }
                Console.WriteLine("The value {0} is Present in Linked List", data);
                return default;
            }
        }
        //here we taking two parameters one for value and other for reference
        public void InsertAtSpecifiedposition(int reference, int data)
        {
            Node newnode = new Node(data);
            Node temp = this.head;
            if (this.head == null)
            {
                this.head = this.tail = newnode;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == reference)
                    {
                        newnode.next = temp.next;
                        temp.next = newnode;
                        break;
                    }
                    temp = temp.next;
                }
            }
        }
        public void DisplayList()
        {
            int count = 0;
            Node temp = this.head;
            while (temp != null)
            {
                Console.WriteLine("At {0} Index We Have {1} value", count, temp.data);
                count++;
                temp = temp.next;
            }
        }
    }
}
        

