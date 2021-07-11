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
        public bool DeleteAtSpecifiedPosition(int data)
        {
            Node previous = null;
            Node temp = this.head;
            if (this.head == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return false;
            }
            else
            {
                while(temp != null)
                {
                    if(temp.data == data)
                    {
                        previous.next = temp.next;
                        temp.next = null;
                        return true;
                    }
                    previous = temp;
                    temp = temp.next;
                }
                return false;
            }
        }
        public int LinkedlistCount()
        {
            int count = 0;
            Node temp = this.head;
            while(temp!=null)
            {
                count++;
                temp = temp.next;
            }
            return count;
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
