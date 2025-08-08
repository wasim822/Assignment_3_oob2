using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
    {
        private Node head;
        private int count;

        public SLL()
        {
            head = null;
            count = 0;
        }

        public bool IsEmpty()
        {
            return count == 0;
        }

        public void Clear()
        {
            head = null;
            count = 0;
        }

        public void Append(User data)
        {
            Node newNode = new Node(data);
            if (head == null)
                head = newNode;
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
            count++;
        }

        public void Prepend(User data)
        {
            Node newNode = new Node(data)
            {
                Next = head
            };
            head = newNode;
            count++;
        }

        public void Insert(User data, int index)
        {
            if (index < 0 || index > count)
                throw new IndexOutOfRangeException("Index out of bounds");

            if (index == 0)
            {
                Prepend(data);
            }
            else if (index == count)
            {
                Append(data);
            }
            else
            {
                Node newNode = new Node(data);
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                newNode.Next = current.Next;
                current.Next = newNode;
                count++;
            }
        }

        public void Replace(User data, int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            current.Data = data;
        }

        public int Size()
        {
            return count;
        }

        public void Delete(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");

            if (index == 0)
            {
                head = head.Next;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }
                current.Next = current.Next.Next;
            }
            count--;
        }

        public User Retrieve(int index)
        {
            if (index < 0 || index >= count)
                throw new IndexOutOfRangeException("Index out of bounds");

            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Data;
        }

        public int IndexOf(User data)
        {
            Node current = head;
            int index = 0;

            while (current != null)
            {
                if ((data == null && current.Data == null) || (data != null && data.Equals(current.Data)))
                {
                    return index;
                }
                current = current.Next;
                index++;
            }

            return -1;
        }

        public bool Contains(User data)
        {
            return IndexOf(data) != -1;
        }

        // Additional Functionality: Copy the values of the linked list nodes into an array
        public User[] ToArray()
        {
            User[] array = new User[count];
            Node current = head;
            int index = 0;

            while (current != null)
            {
                array[index] = current.Data;
                current = current.Next;
                index++;
            }

            return array;
        }

        // Additional Functionality: Reverse the order of the nodes in the linked list
        public void Reverse()
        {
            if (head == null || head.Next == null)
                return;

            Node previous = null;
            Node current = head;
            Node next = null;

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }

            head = previous;
        }
    }
}