using System;

namespace DoubleList
{

    public class BllList
    {
        private Node head;
        private int count;

        public object Count
        {
            get { return count; }
        }
        public BllList()
        {
            head = new Node(null, null, null);
            head.Next = head;
            head.Prev = head;
            count = 0;
        }
        private bool IsEmpty()
        {
            if (count == 0) return true;
            return false;
        }

        public void Append(object data)
        {
            Node newNode = new Node(data, head, head.Prev);
            head.Prev.Next = newNode;
            head.Prev = newNode;
            count++;
        }

        private Node Find(object data)
        {
            Node current = head.Next;
            while (current != head)
            {
                if (current.Element.Equals(data))
                {
                    return current;
                }
                current = current.Next;
            }
            return null;
        }

        public void Remove(object data)
        {
            Node nodeToRemove = Find(data);
            if (nodeToRemove != null)
            {
                nodeToRemove.Prev.Next = nodeToRemove.Next;
                nodeToRemove.Next.Prev = nodeToRemove.Prev;
                count--;
            }
            else
            {
                Console.WriteLine("Element not found.");
            }
        }

        public bool Search(object data)
        {
            return Find(data) != null;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            Node current = head.Next;
            while (current != head)
            {
                Console.WriteLine(current.Element + " ");
                current = current.Next;
            }
            Console.WriteLine();
        }
    }
}