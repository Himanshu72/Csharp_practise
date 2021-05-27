using System;

namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {

            /* Console.ForegroundColor = ConsoleColor.Cyan;
             Console.BackgroundColor = ConsoleColor.Green;
             Console.Clear();
             */
            /**ring s = "10";
             int x = Int32.Parse(s);
             Console.WriteLine(x.ToString());
         */
            /*const int Pi =(int ) 3.14;
            const string s= "constant string ";
            Console.WriteLine(s+" "+Pi);
            */
            //int w = GetInt();
            // bool w = true;
            //Console.WriteLine(w);
            // Console.WriteLine("Number is :{0}", w&20);

            /*
            int W = GetIntWithTryParse();
            Console.WriteLine("num is {0}",W);
            */
            switch (Console.ReadLine()) {
                case "One":
                    Console.WriteLine(1);
                    break;
                case "Two":
                    Console.WriteLine(2);
                    break;
                default:
                    Console.WriteLine("default");
                    break;
                            
            }
        }
        private static void Vraibles()  {
           
            uint x = 19;
            byte y= 20;
            sbyte z= -20;
            ulong  d= 222;


        
        }
        public static  int GetInt() {
            int x=0;
            try {
                string userInput = Console.ReadLine();
                x = Int32.Parse(userInput);
                
            }
            catch (FormatException) {
                Console.WriteLine("invalid Number");
            }
            catch (OverflowException) 
            {
                Console.WriteLine("Number is to big");
            }
            catch (ArgumentNullException) {
                Console.WriteLine("Please pass some value");
            }
            catch (Exception) {
                Console.WriteLine("Somwthig went wrong");
            }
            return x;
        }

        public static int  GetIntWithTryParse() {
            int x = 0;
            if (!int.TryParse(Console.ReadLine(), out x))
                Console.WriteLine("unable to set value");
                return x;
        }
    }
}
