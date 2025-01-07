using System;
using System.Collections.Generic;

namespace SingleList;
public class Queue
{
    private CustomList list;
    public Queue()
    { list = new CustomList(); }

    public void Enqueue(object data)
    {
        list.InsertEnd(data);
    }
    public object Dequeue()
    {
        if (list.IsEmpty())
            throw new InvalidOperationException("Stack is empty.");
        return list.RemoveFront();
    }
    public bool IsEmpty() { return list.IsEmpty(); }
    public void Display() { list.Display(); }
}