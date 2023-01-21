using System;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Channels;

namespace overload
{
    public class Program
    {
        static void Main()
        {
            //    int number = Convert.ToInt32(Console.ReadLine());

            //    FindOut(number);    
            //}

            //static void FindOut(int number)
            //{
            //    if (number % 7 == 0)
            //    {
            //        number = number;
            //    }
            //    else if (number % 7 < 3)
            //    {
            //        number = number - 2;
            //    }
            //    else
            //    {
            //        number = number + 1;
            //    }
            //    Console.WriteLine(number);



            //int number = Convert.ToInt32(Console.ReadLine());
            //SumOfElements(number);

            //static void SumOfElements(int number)
            //{
            //    int sum = 0;
            //    for (int i = 0; i <= number; i++)
            //    {
            //        sum += i;
            //    }
            //    Console.WriteLine(sum);
            //}


            string word = Console.ReadLine();
            string word2 = Console.ReadLine();  

            Compare(word, word2);

        }


        static void Compare(string word, string word2)
        {
            if (word.Length > word2.Length)
            {
                Console.WriteLine($"{word} uzundur");
            }
            else
            {
                Console.WriteLine($"{word2} uzundur");
            }
        }
    }
}