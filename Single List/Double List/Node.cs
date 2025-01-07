using System;

namespace DoubleList
{
    public class Node
    {
        public object Element
        {
            get;
            private set;
        }
        public Node Next { get; set; }
        public Node Prev { get; set; }
        public Node()
        {
            Element = null;
            Next = null;
            Prev = null;
        }

        public Node(Object element, Node next, Node prev)
        {
            Element = element;
            Next = next;
            Prev = prev;
        }
    }

}