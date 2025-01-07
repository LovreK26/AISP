using SingleList;

using System;
using System.Collections.Generic;
public class Stack
{
    private CustomList list;
    public Stack()
    {
        list = new CustomList();
    }
    public void Push(object data)
    {
        list.InsertFront(data);
    }
    public object Pop()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Stack is empty.");
        }
        return list.RemoveFront();
    }
    public bool IsEmpty() { return list.IsEmpty(); }
    public void Display() { list.Display(); }
}