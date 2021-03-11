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

        public void AddPreset(string[,] arr)
        {
            
            for (int i = 0; i < (arr.Length / 2); i++)
            {
                _animals[i] = new Animal(arr[i,0], arr[i,1]);
                current++;
            }
        }

        public void List()
        {
            int answer;
            Console.WriteLine("Type the Name or index of the animal");
            answer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(answer.ToString() + ": " + _animals[answer].ToString());
            Console.WriteLine("press any key to continue");
            Console.ReadKey();     
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
