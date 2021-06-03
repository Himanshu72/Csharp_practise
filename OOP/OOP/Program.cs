using System;
using System.Collections;

namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Human john = new Human("john", 18);
            john.introduce();

            //Playing with Array 
            int[] a = new int[3];
            a[0] = 10;
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
            // jagged array
            int[][] jaggedArray1 = new int[2][];
            jaggedArray1[0] = new int[3] { 1, 2, 3 };
            jaggedArray1[1] = new int[2] { 4, 5 };

            int[][] jaggedArray2 = new int[][]{
                    new int [3]{ 1,2,3},
                    new  int [4]{1,2,3,4}
            };

            foreach (int[] ele in jaggedArray2) {
                foreach (int e in ele) {
                    Console.Write(e + " ");
                }
                Console.WriteLine();
            }
            //ArrayList......
            // Can store mix type of value
            ArrayList arr = new ArrayList(5);
            Console.WriteLine("Count:{0}", arr.Count);
            arr.Add(1);
            arr.Add(1.2);
            arr.Add("Hello");
            arr.Add('h');
            arr.Add(555L);
            arr.Remove(555L);
            arr.RemoveAt(0);
            foreach (object obj in arr) {
                //print only string and char
                if(obj is char || obj is string)
                Console.WriteLine(obj);

            }
        }
    }
}
