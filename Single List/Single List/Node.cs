using System;

namespace SingleList
{
    public class Node
    {
        public object Element { get; private set; }

        public Node Next { get; set; }

        public Node(object element, Node next = null)
        {
            Element = element;
            Next = next;
        }
    }
}