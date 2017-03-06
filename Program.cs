using System;
using System.Collections.Generic;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            UserCollection<string> bc = new UserCollection<string>();
            bc.FillList("One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eigth", "Nine", "Ten");

            foreach (string word in bc)
                Console.WriteLine(word);

            Console.ReadLine();
        }
    }
}
