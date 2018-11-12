using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSAssignment4
{
    class DoubleLinkedList
    {
        Node head, tail;
        public void PrintFwd()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.data[0] + "," + current.data[1] + "," + current.data[2] + "\n");
                current = current.NextNode;
            }
            Console.WriteLine("");
        }
        public void PrintBwd()
        {
            Node current = tail;
            while (current != null)
            {
                Console.Write(current.data[0] + "," + current.data[1] + "," + current.data[2] +"\n");
                current = current.PreviousNode;
            }
            Console.WriteLine("");
        }

        public void InsertAtHead(string [] _data)
        {
            Node node = new Node(_data);
            if (head == null)
            {
                head = node;
                tail = node;
            }
            else
            {
                node.NextNode = head;
                node.PreviousNode = null;
                head.PreviousNode = node;
                head = node;
            }
        }

        public void InsertAtTail(string[] _data)
        {
            Node node = new Node(_data);
            if (tail == null)
            {
                head = node;
                tail = node;
            }

            else
            {
                node.PreviousNode = tail;
                tail.NextNode = node;
                tail = node;
            }
        }

        //public void insertafter(string _afterdata, string[] _data)
        //{
        //    Node current = head;
        //    Node newnode = new Node(_data);
        //    while (current != null)
        //    {
        //        if (current.Data == _afterdata)
        //        {
        //            newnode.NextNode = current.NextNode;
        //            if (current.NextNode == null)
        //            {
        //                InsertAtTail(_data);
        //                return;
        //            }
        //            current.NextNode.PreviousNode = newnode;
        //            current.NextNode = newnode;
        //            newnode.PreviousNode = current;
        //            return;

        //        }
        //        current = current.NextNode;
        //    }

        //}
    }
}
