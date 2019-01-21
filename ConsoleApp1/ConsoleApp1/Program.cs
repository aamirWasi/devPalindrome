using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            for(int i = 0; i < T; i++)
            {
                string str = "";
                string reverse = "";
                int index = 0;
                str = Console.ReadLine();
                index = str.Length - 1;
                while(index >= 0) {
                    reverse += str.Substring(index, 1);
                    index--;
                }
                if(str == reverse)
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
        }
    }
}