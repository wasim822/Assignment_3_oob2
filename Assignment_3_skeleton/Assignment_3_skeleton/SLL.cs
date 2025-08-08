using System;

namespace Utility
{
    public class Node
    {
        public object Data;
        public Node Next;

        public Node(object data)
        {
            Data = data;
            Next = null;
        }
    }

    public interface ILinkedListADT
    {
        void Insert(object data, int index);
        void RemoveFirst();
        void RemoveLast();
    }

    public class SLL : ILinkedListADT
    {
        private Node head;
        private int size;

        public SLL()
        {
            head = null;
            size = 0;
        }

        public void Insert(object data, int index)
        {
            if (index < 0 || index > size)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            if (index == 0)
            {
                Node newHead = new Node(data);
                newHead.Next = head;
                head = newHead;
                size++;
                return;
            }

            Node newNode = new Node(data);
            Node current = head;

            for (int i = 0; i < index - 1; i++)
            {
                current = current.Next;
            }

            newNode.Next = current.Next;
            current.Next = newNode;
            size++;
        }

        public void RemoveFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            head = head.Next;
            size--;
        }

        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
                return;
            }

            if (head.Next == null)
            {
                head = null;
            }
            else
            {
                Node current = head;
                while (current.Next.Next != null)
                {
                    current = current.Next;
                }
                current.Next = null;
            }

            size--;
        }
    }
}
