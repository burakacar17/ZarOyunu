using System;

namespace ZarOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            ZarAt zarAt = new ZarAt(6);

            Console.WriteLine(zarAt.go());
          
        }
    }
}
