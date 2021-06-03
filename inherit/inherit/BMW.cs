using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class BMW:Car
    {
        string brand="BMW";
        public string Model { get; set; }
        public BMW(int HP,string Color,String Model) : base(HP,Color) {
            this.Model = Model;
        }
        public new void showDetails()
        {
            Console.WriteLine("Brand:{0} HP:{1},Color:{2}",brand,HP, Color);
        }
        public override void  repair()
        {
            Console.WriteLine("BMW Model {0} Car Got Repair",Model);
        }

    }
}
