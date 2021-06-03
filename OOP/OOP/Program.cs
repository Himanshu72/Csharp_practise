using System;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
             Human john = new Human("john",18);
            john.introduce();

            //Playing with Array and array list
            int[] a = new int[3];
            a[0]= 10;
            a[1] = 20;
            a[2] = 30;
            int[] b = new int[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine(b.Length);
            foreach (int x in a) {
                Console.WriteLine(x);
            }

            int[,] d2 = new int[,]{
                {1,2 ,3},
                {4,5,6 },
                { 7,8,9}
            };

            int[,] ad2 = new int[3, 2];
            Console.WriteLine(ad2.Rank);
            
        }
    }
}
