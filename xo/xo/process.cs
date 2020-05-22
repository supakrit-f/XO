using System;
using System.Collections.Generic;
using System.Text;

namespace xo
{
    class process
    {
        String[] b = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        public void game(string num,int player)
        {
            int e = 0;
            int a = Int32.Parse(num)-1;
            for (int i = 0; i < 9; i++)
            {
                if (i == a )
                {
                    if (b[i] == "X" | b[i] == "O")
                    {
                        Console.WriteLine("Error");
                        break;
                    }
                    else
                    {
                        if (player == 1)
                        {
                            b[i] = "X";
                        }
                        if (player == 0)
                        {
                            b[i] = "O";
                        }
                    }
                }
            }
        }
        public void show()
        {
            
            Console.WriteLine(" {0} | {1} | {2} ", b[0], b[1], b[2]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2} ", b[3], b[4], b[5]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2} ", b[6], b[7], b[8]);
            Console.WriteLine("------------");
        }
        public int Check(int count)
        {
            int c = count;
            if (b[0] == b[4] & b[4] == b[8])
            {
                if (b[0] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
    
            }
            if (b[2] == b[4] & b[4] == b[6])
            {
                if (b[3] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[0] == b[3] & b[3] == b[6])
            {
                if (b[0] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[1] == b[4] & b[4] == b[7])
            {
                if (b[1] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[2] == b[5] & b[5] == b[8])
            {
                if (b[2] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[0] == b[1] & b[1] == b[2])
            {
                if (b[0] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[3] == b[4] & b[4] == b[5])
            {
                if (b[3] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            if (b[6] == b[7] & b[7] == b[8])
            {
                if (b[6] == "x")
                {
                    Console.WriteLine("x is Winner");
                    return 0;
                }
                else
                {
                    Console.WriteLine("o is Winner");
                    return 0;
                }
                
            }
            return 1;
        }
    }
}
