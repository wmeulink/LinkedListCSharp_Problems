using System;

namespace LinkedList
{
   
    internal class DoubleLinkedList<T>
    {
        internal DNode head;

        internal class DNode
        {
            internal T data;
            internal DNode prev;
            internal DNode next;
            public DNode(T d)
            {
                data = d;
                prev = null;
                next = null;
            }
        }



        internal void InsertFront(DoubleLinkedList<T> doubleLinkedList, T data)
        {
            DNode newNode = new DNode(data);
            newNode.next = doubleLinkedList.head;
            newNode.prev = null;
            if (doubleLinkedList.head != null)
            {
                doubleLinkedList.head.prev = newNode;
            }
            doubleLinkedList.head = newNode;
        }

        internal void InsertLast(DoubleLinkedList<T> doubleLinkedList, T data)
        {
            DNode newNode = new DNode(data);
            if (doubleLinkedList.head == null)
            {
                newNode.prev = null;
                doubleLinkedList.head = newNode;
                return;
            }
            DNode lastNode = GetLastNode(doubleLinkedList);
            lastNode.next = newNode;
            newNode.prev = lastNode;
        }
        internal DNode GetLastNode(DoubleLinkedList<T> myList)
        {
            DNode temp = myList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        internal void InsertAfter(DNode prev_node, T data)
        {
            if (prev_node == null)
            {
                Console.WriteLine("The given prevoius node cannot be null");
                return;
            }
            DNode newNode = new DNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
            newNode.prev = prev_node;
            if (newNode.next != null)
            {
                newNode.next.prev = newNode;
            }
        }

        internal void DeleteNodebyKey(DoubleLinkedList<T> doubleLinkedList, T key)
        {
            DNode temp = doubleLinkedList.head;
            if (temp != null && temp.data.Equals(key))
            {
                doubleLinkedList.head = temp.next;
                doubleLinkedList.head.prev = null;
                return;
            }
            while (temp != null && temp.data.Equals(key))
            {
                temp = temp.next;
            }
            if (temp == null)
            {
                return;
            }
            if (temp.next != null)
            {
                temp.next.prev = temp.prev;
            }
            if (temp.prev != null)
            {
                temp.prev.next = temp.next;
            }
        }


    }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

