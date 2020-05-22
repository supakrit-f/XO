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
            int a = Int32.Parse(num)-1;
            for (int i = 0; i < 9; i++)
            {
                if (i == a)
                {
                    if(player == 1)
                    {
                        b[i] = "x";
                    }
                    if(player == 0)
                    {
                        b[i] = "o";
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
        public string Check
        {
            if (b[0] == b[4] & b[4] == b[8])
            {
                if (b[0] == "x")
                {
                   return "x is Winner";
                }
                else
                {
                   return "o is Winner";
                }
              
            }
            if (b[2] == b[4] & b[4] == b[6])
            {
                if (b[3] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
               
            }
            if (b[0] == b[3] & b[3] == b[6])
            {
                if (b[0] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
            if (b[1] == b[4] & b[4] == b[7])
            {
                if (b[1] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
            if (b[2] == b[5] & b[5] == b[8])
            {
                if (b[2] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
            if (b[0] == b[1] & b[1] == b[2])
            {
                if (b[0] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
            if (b[3] == b[4] & b[4] == b[5])
            {
                if (b[3] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
            if (b[6] == b[7] & b[7] == b[8])
            {
                if (b[6] == "x")
                {
                    return "x is Winner";
                }
                else
                {
                    return "o is Winner";
                }
                
            }
        }
    }
}
