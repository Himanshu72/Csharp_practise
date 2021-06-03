using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LamdaExpAndMore
{
   

   
    class Program

    {
        public struct human {
            string name;
            int age;
            public human(string name,int age) {
                this.name = name;
                this.age = age;
            }
            public void display() {
                Console.WriteLine("name:{0},age:{1}",name,age);
            }
        }
        delegate int math(int x);
        static int Plus1(int x) {

            return x + 1;
        }

        enum days{mo=1,tu,we,th,fr,sa,su};
        static void Main(string[] args)
        {
            math inc = new math(Plus1);
            Console.WriteLine( inc(5));
            math inc2 = (a) => a + 2;
            Console.WriteLine(inc2(5));
            List<int> L=new List<int> { 1,2,3,4,5,6};
            Console.WriteLine("Evens:");
            foreach(int x in L.FindAll(ele => ele % 2 == 0)){
                Console.WriteLine(x);
            }
            Console.WriteLine("Odds");
            foreach (int x in L.FindAll(delegate (int x) {
                return x % 2 == 1;
            })) {
                Console.WriteLine(x);
            };

            //struct
            human h = new human("Himanshu",23);
            h.display();
            days d = days.fr;
            Console.WriteLine(d);
            Console.WriteLine((int)d);

            //Math Class

            Console.WriteLine(Math.Min(1, 4));
            Console.WriteLine(Math.Abs(-23));
            Console.WriteLine(Math.Ceiling(22.4));
            //Random Class
            Random dic = new Random();
            Console.WriteLine("Roll:{0}",dic.Next(1,7));
            //Regex
            string text = "12345 12345 orom momomo omom 65432 434 3 3";
            Regex regex = new Regex(@"\d{5}");
            MatchCollection matches = regex.Matches(text);
            Console.WriteLine("Hits:{0}", matches.Count);
            foreach (Match match in matches) {
                GroupCollection group = match.Groups;
                Console.WriteLine("{0} found at {1}",group[0].Value,group[0].Index);
                //Datetime
                DateTime date = new DateTime(2021,01,01);
                DateTime cur = DateTime.Now;
                DateTime tommorow = cur.AddDays(1);
                Console.WriteLine(tommorow);
                Console.WriteLine("Days in cur month: {0}",DateTime.DaysInMonth(cur.Year,cur.Month));
                TimeSpan days = cur.Subtract(new DateTime(1999,2,1));
                Console.WriteLine("I Lived {0} days",days);
                //Nullables
                int? x = null; //nullable int
                x = x??100; //if x is null assign 100
            }
        }
    }
}
