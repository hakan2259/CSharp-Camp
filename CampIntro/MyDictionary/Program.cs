using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> users = new MyDictionary<int, string>();
            users.Add(1, "Hakan");
            users.Add(2, "Betul");
            
            foreach (var item in users.value)
            {
                Console.WriteLine(item);
                
            }
            Console.WriteLine("Number of elements => " + users.Count);
        }
    }
}
