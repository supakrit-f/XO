using System;
using System.IO;

namespace xo
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 1;
            Console.WriteLine(" 1 | 2 | 3 ");
            Console.WriteLine("------------");
            Console.WriteLine(" 6 | 5 | 4 ");
            Console.WriteLine("------------");
            Console.WriteLine(" 7 | 8 | 9 ");
            process p = new process();
            string num1 = "";
            string num2 = "";
            do
            {
                int player = 0;
                player++;
                if (player == 1)
                {
                    Console.WriteLine("X select number:");
                    num1 = Console.ReadLine();
                    p.game(num1,player);
                    p.show();
                    p.Check();
                    player-- ;
                }
                if(player == 0)
                {
                    Console.WriteLine("O select number:");
                    num2 = Console.ReadLine();
                    p.game(num2, player);
                    p.show();
                    p.Check();

                }
            } while (count == 1);

        }
        
    }
}
