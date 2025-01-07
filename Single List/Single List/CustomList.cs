using System;

namespace SingleList
{
    public class CustomList
    {
        private Node head;
        private Node tail;

        public CustomList()
        {
            head = null;
            tail = null;
        }

        public bool IsEmpty()
        {
            return head == null;
        }

        public void InsertFront(object data)
        {
            Node newNode = new Node(data);

            newNode.Next = head;

            head = newNode;

            if (tail == null)
            {
                tail = head;
            }
        }

        public void InsertEnd(object data)
        {
            Node newNode = new Node(data);

            if (IsEmpty())
            {
                head = newNode;
                tail = newNode;
            }
            else
            {
                tail.Next = newNode;
                tail = newNode;
            }
        }

        public object RemoveFront()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            object removedData = head.Element;
            head = head.Next;

            if (head == null)
            {
                tail = null;
            }
            return removedData;
        }

        public object RemoveEnd()
        {
            if (IsEmpty())
            {
                throw new InvalidOperationException("List is empty.");
            }

            if (head == tail)
            {
                object removedData = head.Element;
                head = null;
                tail = null;
                return removedData;
            }

            Node current = head;
            while (current.Next != tail)
            {
                current = current.Next;
            }

            object removedDataTail = tail.Element;

            tail = current;
            tail.Next = null;

            return removedDataTail;
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The list is empty.");
                return;
            }

            Node current = head;
            while (current != null)
            {
                Console.Write($"{current.Element} -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }
    }
}