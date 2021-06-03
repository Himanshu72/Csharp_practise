using System;

namespace FileHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            string all = System.IO.File.ReadAllText(@"C:\Users\Himanshu Joshi\source\repos\C#\FileHandling\FileHandling\assets\file.txt");
            Console.WriteLine(all);
            string[] lines = System.IO.File.ReadAllLines(@"C:\Users\Himanshu Joshi\source\repos\C#\FileHandling\FileHandling\assets\file.txt");
            foreach (string line in lines) {
                Console.WriteLine(line);
            }
            string[] datas = {
                "One ",
                "Two",
                "Three"
            };
            System.IO.File.WriteAllLines(@"C:\Users\Himanshu Joshi\source\repos\C#\FileHandling\FileHandling\assets\file2.txt", datas);
            //line by line
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"C:\Users\Himanshu Joshi\source\repos\C#\FileHandling\FileHandling\assets\file3.txt")) {
                foreach (var data in datas) {
                    file.WriteLine(data);
                }          
              }

            using (System.IO.StreamReader file=new System.IO.StreamReader(@"C:\Users\Himanshu Joshi\source\repos\C#\FileHandling\FileHandling\assets\file3.txt")) {
                string line;
                while ((line=file.ReadLine())!=null){
                    Console.WriteLine(line); 
                }
            }
        }
    }
}
