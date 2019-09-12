using System;

namespace LinkedList
{
    public class DoubleLinkedList<T>
    {
        public DNode head;

        public class DNode
        {
            public T data;
            public DNode prev = null;
            public DNode next = null;

            public DNode(T d)
            {
                data = d;  
            }
        }

        public void InsertFront(T data)
        {
            DNode newNode = new DNode(data);
            newNode.next = this.head;
            newNode.prev = null;
            if (this.head != null)
            {
                this.head.prev = newNode;
            }

            this.head = newNode;
        }

        public void InsertLast(T data)
        {
            DNode newNode = new DNode(data);
            if (this.head == null)
            {
                newNode.prev = null;
                this.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode();
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        public DNode GetLastNode()
        {
            DNode temp = this.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }



    }

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}