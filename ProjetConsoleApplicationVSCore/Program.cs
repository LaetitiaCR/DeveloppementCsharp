using System;

namespace ProjetConsoleApplicationVSCore
{
    class Program
    {
       static void Main(string[] args){
            Console.WriteLine("Hello World!");
            Compte c = new Compte();
            Compte c1 = new Compte(12345, "toto", 1000, -500);
            Console.WriteLine(c.ToString());

            Console.WriteLine(c1.ToString());
        }
    }

}