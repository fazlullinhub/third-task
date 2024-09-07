using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabetArr = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };

            Console.Write("Enter a phrase: ");
            string phrase = Console.ReadLine();

            char[] phraseArr = phrase.ToCharArray();
            char[] finalArr = phraseArr;
            char[] finalArr2 = phraseArr;

            for (var k = 0; k < phraseArr.Length; k++)
            {
                var ch = phraseArr[k];
                for (int i = 0; i < alphabetArr.Length; i++)
                {
                    if (ch == alphabetArr[i])
                    {
                        int n = i + 3;
                        if (n > 33)
                        {
                            n = n % 33;
                        }

                        finalArr[k] = alphabetArr[n];
                    }
                    if (ch == ' ')
                    {
                        finalArr[k] = ' ';
                    }
                }
            }
            Console.WriteLine("encrypting:");
            foreach (char item in finalArr)
            {
                Console.Write(item);
            }

            for (var q = 0; q < phraseArr.Length; q++)
            {
                var chr = phraseArr[q];
                for (int r = 0; r < alphabetArr.Length; r++)
                {
                    if (chr == alphabetArr[r])
                    {
                        int m = r - 3;
                        if (m < 0)
                        {
                            m = 33 + m;
                        }

                        finalArr2[q] = alphabetArr[m];
                    }
                    if (chr == ' ')
                    {
                        finalArr2[q] = ' ';
                    }
                }
            }

            Console.WriteLine("\nencrypting:");
            foreach (char item in finalArr2)
            {
                Console.Write(item);
            }

            Console.ReadKey();
        }
    }
}
