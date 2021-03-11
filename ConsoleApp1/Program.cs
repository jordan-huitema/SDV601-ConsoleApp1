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
                Console.WriteLine(" ");
                Console.WriteLine("0 = Add Animal");
                Console.WriteLine("1 = Add Preset Animals");
                Console.WriteLine(" ");
                Console.WriteLine("2 = List Animal");
                Console.WriteLine("3 = List All Animals");
                Console.WriteLine(" ");
                Console.WriteLine("4 = GTF outtta here Boi");

                string answer = Console.ReadLine();
                switch (answer)
                {
                    case "0":
                        z.Add();
                        break;
                    case "1":
                        string[,] arr =
                        {
                            {"Lion", "Weef Woof" },
                            {"Mouse", "WEEE WOOOO" },
                            {"Elephant", "Meow Meow" }
                        };
                        z.AddPreset(arr);
                        break;
                    case "2":
                        z.List();
                        break;
                    case "3":
                        z.ListAll();
                        break;
                    case "4":
                        run = false;
                        break;
                }
            }
        }
    }
}
