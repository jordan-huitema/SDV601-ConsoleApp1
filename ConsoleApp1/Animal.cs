using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Animal
    {
        private string _name;
        private string _sound;

        public string Name { get => _name; set => _name = value; }
        public string Sound { get => _sound; set => _sound = value; }

        public Animal(string name,string sound)
        {
            _name = name;
            _sound = sound;
        }

        public virtual string ToString()
        {
            return _name + " makes the sound " + _sound;
        }
    }
}
