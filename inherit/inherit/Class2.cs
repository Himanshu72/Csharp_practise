using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Car
    {
        public int HP { set; get; }
        public string Color { set; get; }
        public Car(int HP,string color) {
            this.HP = HP;
            this.Color = color;
        }
        public void showDetails() {
            Console.WriteLine("HP:{0},Color:{1}", HP, Color);
        }
        public virtual void repair() {
            Console.WriteLine("Car Got Repair");
        }
             
    }
}
