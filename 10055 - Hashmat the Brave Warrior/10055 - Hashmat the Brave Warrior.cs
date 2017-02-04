using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("text.txt");
            
            foreach (String lines1 in lines)
            {
                int a, b, c;
                String[] word = lines1.Split();

                for (int i = 0; i < word.Length; i++)
                {
                    a = Int32.Parse(word[i]);

                    for (int j = 1; j < word.Length; j++)
                    {
                        b = Int32.Parse(word[j]);

                        if (b > a)
                        {
                            c = b - a;
                            Console.WriteLine(c);
                        }

                    }
                }

            }
        }
    }
}
