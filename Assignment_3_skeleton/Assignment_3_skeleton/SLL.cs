using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_skeleton
{
    public class SLL : LinkedListADT
        
    {
        public void Append(object data) //1
        {
            throw new NotImplementedException();
        }

        public void Clear()//2
        {
            throw new NotImplementedException();
        }

        public bool Contains(object data)//3
        {
            //head is frist node
            // current go through each node
            Node current = head;

            while (current != null)
            {
                if (current.Data == null && data == null)
                    return true;
                else if (current.Data != null && current.Data.Equals(data))
                    return true;

                current = current.Next;
            }

            return false;


        }

        public void Delete(int index)//4
        {
            IDictionary (index < 0 || index >= Size())
            {
                throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");
            }
            if (index == 0)
            {
                head = head.Next;
                size--;
                return;
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

            size--1;

        }

        public int IndexOf(object data)//5
                      // cant return true because its int
        {
            Node current = head;
            // keep track on nodes index
            int index = 0;

            while (current != null)
            {
                if ((current.Data == null && data == null) ||
                    (current.Data != null && current.Data.Equals(data)))
                {
                    return index;
                }

                current = current.Next;
                index++;
            }

            return -1;

        }

        public void Insert(object data, int index)//6
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()//7
        {
            throw new NotImplementedException();
        }

        public void Prepend(object data)//8
        {
            throw new NotImplementedException();
        }

        public void Replace(object data, int index)//9
        {
            throw new NotImplementedException();
        }

        public object Retrieve(int index)//10
        {
            throw new NotImplementedException();
        }

        public int Size()//11
        {
            throw new NotImplementedException();
        }
    }
}
