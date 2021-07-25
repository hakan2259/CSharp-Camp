using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var users = new Dictionary<int, string>();
            //Diğer listelerde olduğu gibi Add() metodu ile ekleme yapıyoruz..
            users.Add(1, "Hakan Sandal");
            users.Add(2, "Betül Yeşildağ");
            users.Add(3, "Buse Kır");
            users.Add(4, "Erkan Sandal");
            users.Add(5, "Yiğit Yeşildağ");
            users.Add(6, "Merve Kara");
            users.Add(7, "Sedef Gunes");
            

            foreach (KeyValuePair<int,string> user in users)
            {
                Console.WriteLine("ID => " + user.Key+ " " + " Name Surname => " + user.Value);
            }

            Console.WriteLine("number of elements : "+ users.Count);
            




        }
    }
}
