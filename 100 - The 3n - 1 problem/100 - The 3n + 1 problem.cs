using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100___The_3n___1_problem
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] lines = File.ReadAllLines("text.txt");

            foreach (String lines1 in lines)
            {
                int min = 0;
                int max = 0;
                int maxlen = 0;
                int temp = 0;
                String[] word = lines1.Split();

                for (int i = 0; i < word.Length; i++)
                {
                    min = Int32.Parse(word[i]);

                    for (int j = 1; j < word.Length; j++)
                    {
                        max = Int32.Parse(word[j]);

                        while (min <= max)
                        {
                            //Console.WriteLine(min);
                            if (min != 1)
                            {
                                if (min % 2 == 1)
                                {
                                    temp = 3 * min + 1;
                                    //Console.WriteLine(temp);
                                    cycle(temp);
                                }
                                else if (min % 2 == 0)
                                {
                                    temp = min / 2;
                                    //Console.WriteLine(temp);
                                    cycle(temp);
                                }
                            }
                            min++;

                            int c = cycle(min) + 1;
                            if (c > maxlen)
                            {
                                maxlen = c;
                            }
                        }
                    }
                }
              
                Console.WriteLine(min +" "+ max +"  " +  maxlen);
            }
        }

        public static int cycle(int temp)
        {
            int cycle = 0;
            while (temp != 1)
            {
                if (temp % 2 == 1)
                {
                    temp = 3 * temp + 1;
                    //Console.WriteLine(temp);
                }
                else if (temp % 2 == 0)
                {
                    temp = temp / 2;
                    //Console.WriteLine(temp);
                }
                cycle++;
            }
            return cycle;
        }
    }
}
