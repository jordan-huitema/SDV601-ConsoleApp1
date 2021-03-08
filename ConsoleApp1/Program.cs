using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo z = new Zoo();
            bool run = true;
            while (run)
            {
                Console.Clear();
                Console.WriteLine("What do you waaaaannt?");
                Console.WriteLine("0 = Add Animal");
                Console.WriteLine("1 = List Animal");
                Console.WriteLine("2 = List All Animals");
                Console.WriteLine("3 = GTF outtta here Boi");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "0":
                        z.Add();
                        break;
                    case "1":
                        z.List();
                        break;
                    case "2":
                        z.ListAll();
                        break;
                    case "3":
                        run = false;
                        break;
                }
            }
        }
    }
}
