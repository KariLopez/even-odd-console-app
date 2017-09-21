using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            int inputParsed;
            Console.WriteLine("Please enter a number between 1 and 100");
            input = Console.ReadLine();
            inputParsed = int.Parse(input);
            if (inputParsed % 2 != 0)
            {
                if (inputParsed >= 60)
                {
                    Console.WriteLine(inputParsed + " odd");
                }
                else
                {
                    Console.WriteLine(inputParsed + " odd");
                }
                
            }
            while (inputParsed % 2 == 0)
            {
                if (inputParsed >= 2 && inputParsed <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else if(inputParsed>=26 && inputParsed<=60)
                {
                    Console.WriteLine("Even");
                }
                else
                {
                    Console.WriteLine(inputParsed + " even");
                }
                Console.ReadLine();
            }
            
        }
    }
}
