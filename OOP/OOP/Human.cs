using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Human
    {
        private string name{ get; set; }
        private byte age;

        byte Age { get => age; set {
                if (value > 0)
                    this.age = value;
                else
                    throw new Exception("Age must be greater then 0");
            } }

        
        public Human(string name,byte age) {
            this.name = name;
            this.Age = age;
        }
        public Human() { }

        public void introduce() {
            Console.WriteLine("Hello, My name is {0} and  I am {1} year old",name,age);
        }
        ~Human() {
            Console.WriteLine("Object Destroyed");
           
        }

    }
}
