namespace Delegates


    //ZADATAK 4.


{
    internal class Program
    {

        delegate void Invoker(int i);

        static void Method(Invoker invoker, int value)
        {
            invoker(value);
        }
        static void Display(int i)
        {
            Console.WriteLine("Displaying " + i);
        }
        static void Print(int i)
        {
            Console.WriteLine("Printing " + i);
        }


        static void Main(string[] args)
        {
            Invoker invoker = Display;

            invoker(1);
            //invoker.Invoke(1);
            invoker =   Print;
            //invoker(2);
            invoker.Invoke(2);
            invoker += Display;
            invoker.Invoke(3);
            Method(Display, 4);
            Method(Print, 5);
            invoker = delegate (int i)
            {
                Console.WriteLine("Anonymousing " + i);
            };
            invoker(6);
            invoker = i => Console.WriteLine("Lamdaing " + i);
            invoker(7);
        }
    }
}
