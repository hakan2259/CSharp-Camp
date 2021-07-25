using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> names = new MyList<string>();
            names.Add("Hakan");
            Console.WriteLine(names.Length);
            names.Add("Betül");
            Console.WriteLine(names.Length);

            foreach(var item in names.Items)
            {
                Console.WriteLine(item);
            }
            

        }
    }
}
