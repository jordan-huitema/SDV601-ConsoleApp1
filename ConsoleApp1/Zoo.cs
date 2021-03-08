using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Zoo
    {
        Animal[] _animals = new Animal[255];
        int current = 0;
        public void Add()
        {
            Console.WriteLine("Whats the name of your animal of choice?");

            string name = Console.ReadLine();

            Console.WriteLine("Whats the sound it makes?");

            string sound = Console.ReadLine();

            _animals[current] = new Animal(name, sound);
            current++;
        }

        public void List()
        {
            bool IsString = false;
            int answerInt;
            string answerString;
            Console.WriteLine("Type the Name or index of the animal");
            try
            {
                answerInt = Convert.ToInt32(Console.ReadLine());
            }
            catch (InvalidCastException e)
            {
                string answerString = Console.ReadLine();
                IsString = true;
            }

            switch (IsString)
            {
                case true:
                    break;
                case false:
                    Console.WriteLine(answerInt.ToString() + ": " + _animals[answerInt].ToString());
                    Console.WriteLine("press any key to continue");
                    Console.ReadKey();
                    break;
            }            
        }

        public void ListAll()
        {
            for(int i = 0; i < current; i++)
            {
                Console.WriteLine(i.ToString() + ": " + _animals[i].ToString());
            }
            Console.WriteLine("press any key to continue");
            Console.ReadKey();
        }
    }
}
