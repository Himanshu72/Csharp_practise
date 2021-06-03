using System;

namespace tictactoe
{
    class Program
    {
        static char[,] boardLogic ={
            { '1','2','3'},
            { '4','5','6'},
            { '7','8','9'}
        };
        static void Main(string[] args)
        {
            int player = 1;
            int input = 0;
            bool isValidInput=true;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            do {
                drawBorad();
                
                isValidInput = getUserInput(player);
                if (!isValidInput)
                {
                    Console.Clear();
                    continue;
                }      
        

               
                if (checkResult()) {
                    Console.WriteLine("Game Over Player{0} Won...............",player);
                    break;
                }

                if (player == 1)
                    player = 2;
                else
                    player = 1;

                Console.Clear();
            } while (true);
                
        }
        static void drawBorad() {
            Console.WriteLine(" {0} | {1} | {2} ",boardLogic[0,0], boardLogic[0, 1], boardLogic[0, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.WriteLine(" {0} | {1} | {2} ", boardLogic[1, 0], boardLogic[1, 1], boardLogic[1, 2]);
            Console.WriteLine("___|___|___");
            Console.WriteLine("   |   |   ");

            Console.WriteLine(" {0} | {1} | {2} ", boardLogic[2, 0], boardLogic[2, 1], boardLogic[2, 2]);
               }

        static bool getUserInput(int player)
        {
            int x = -1,row=0,col=0;

            try
            {
                Console.Write("Enter Number Player{0} :",player);
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    row = (x - 1) / 3;
                    col = (x - (row * 3)) - 1;

                    if (char.IsDigit(boardLogic[row, col]))
                    {
                        boardLogic[row, col] = (player == 1) ? 'X' : 'Y';
                        return true;
                    }
                    else
                        throw new Exception("Spot is already use try another sport");

                }
                else {
                    throw new Exception("Invalid Input Forme user");
                    
                } 

            }
            catch (Exception e) {
                
                Console.WriteLine(e.Message+"..........");
                Console.ReadKey();         
                return false;  
            }

        }
        static bool checkResult() {
            char[] res = { 'X', 'Y' };
            foreach (char s in res) {
                if (
                    (boardLogic[0, 0] == s && boardLogic[0, 1] == s && boardLogic[0, 2] == s) ||
                    (boardLogic[1, 0] == s && boardLogic[1, 1] == s && boardLogic[1, 2] == s) ||
                    (boardLogic[2, 0] == s && boardLogic[2, 1] == s && boardLogic[2, 2] == s) ||
                    (boardLogic[0, 0] == s && boardLogic[1, 1] == s && boardLogic[2, 2] == s) ||
                    (boardLogic[0, 2] == s && boardLogic[1, 1] == s && boardLogic[2, 0] == s)

                    )
                    return true;
                    
            }
            
            return false;
        }
    }
    

}
