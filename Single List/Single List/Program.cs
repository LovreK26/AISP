using System;

namespace SingleList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomList list = new CustomList();
            list.InsertFront("Ivo");
            list.InsertEnd(1);
            list.InsertEnd(3.14);
            list.InsertFront(true);
            list.InsertEnd(100m);
            list.Display();
            try
            {
                list.RemoveEnd();
                list.RemoveFront();
                list.Display();
                list.RemoveEnd();
                list.RemoveFront();
                list.RemoveFront();
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            list.Display();
        }
    }
}