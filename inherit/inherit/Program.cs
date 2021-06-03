using System;
using System.Collections.Generic;

namespace inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Post p1 = new Post("Myfirstpost","HJ");
             ImagePost p2 = new ImagePost("Image Post", "www.google.com/img", "HJ");
             VideoPost p3 = new VideoPost("Video Post","www.youtube.com/video",100,"HJ");
             Console.WriteLine(p1.ToString());
             Console.WriteLine(p2.ToString());
             Console.WriteLine(p3.ToString());
             */

            List<Car> cars = new List<Car> {
                new BMW(100,"red","A4"),
                new BMW(1000,"blue","A5"),
                new BMW(1000,"green","A6"),
            };
            /*
             we can sealed overide method(prevent further overrride of method)
                public sealed ovrride method(){---}
              we can also sealed  class so no other class can inherit sealed class
                sealed class A{----}
             */
            foreach (var car in cars) {
                car.showDetails();
                car.repair(); //virtual late binding
            }
            
        }
    }
}
