using System;
using System.Security.Cryptography;

namespace Homework4
{
    internal class Program
    {
        public static int GetSymbolCount(char symbol, char[] source)
        {
            int count = 0;
            foreach (char c in source)
            {
                if (c == symbol)
                {
                    count++;
                }
            }

            return count;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter size arrayN:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Array N numbers:");
            int[] arrayN = new int[n];
            for (int i = 0; i < arrayN.Length; i++)
            {
                arrayN[i] = new Random().Next(1, 27);
                Console.Write(arrayN[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Array even numbers:");
            int[] arrayEven = new int[n];
            int[] arrayOdd = new int[n];

            for (int i = 0; i < arrayN.Length; i++)
            {
                if (arrayN[i] % 2 == 0)
                {
                    arrayEven[i] = arrayN[i];
                    Console.Write(arrayEven[i] + ",");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Array odd  numbers:");
            for (int i = 0; i < arrayN.Length; i++)
            {
                if (arrayN[i] % 2 != 0)
                {
                    arrayOdd[i] = arrayN[i];
                    Console.Write(arrayOdd[i] + ",");
                }
            }

            Console.WriteLine();
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            char[] arrayEvenA = new char[n];
            for (int i = 0; i < arrayEven.Length; i++)
            {
                if (arrayEven[i] > 0)
                {
                    arrayEvenA[i] = alphabet[arrayEven[i] - 1];
                }
            }

            Console.WriteLine("Array even with suppercase characters:");
            char[] arrayOddA = new char[n];
            for (int i = 0; i < arrayOdd.Length; i++)
            {
                if (arrayOdd[i] > 0)
                {
                    arrayOddA[i] = alphabet[arrayOdd[i] - 1];
                }
            }

            int count1 = 0;
            for (int i = 0; i < arrayEvenA.Length; i++)
            {
                if (char.IsDigit(arrayEvenA[i]))
                {
                    continue;
                }

                var symbolCount = GetSymbolCount(arrayEvenA[i], arrayEvenA);
                if (symbolCount == 1)
                {
                    arrayEvenA[i] = char.ToUpper(arrayEvenA[i]);
                    count1++;
                }
            }

            int count2 = 0;
            for (int i = 0; i < arrayEvenA.Length; i++)
            {
                if (arrayEvenA[i] != 0)
                {
                    Console.Write(arrayEvenA[i] + " ");
                }
            }

            Console.WriteLine();
            for (int i = 0; i < arrayOddA.Length; i++)
            {
                if (char.IsDigit(arrayOddA[i]))
                {
                    continue;
                }

                var symbolCount = GetSymbolCount(arrayOddA[i], arrayOddA);
                if (symbolCount == 1)
                {
                    arrayOddA[i] = char.ToUpper(arrayOddA[i]);
                    count2++;
                }
            }

            Console.WriteLine("Array odd with suppercase characters:");
            for (int i = 0; i < arrayOddA.Length; i++)
            {
                if (arrayOddA[i] != 0)
                {
                    Console.Write(arrayOddA[i] + " ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Outcome:");

            if (count1 == count2)
            {
                Console.WriteLine("Arrays have an equal number of uppercase characters!!!");
            }
            else if (count1 < count2)
            {
                Console.WriteLine("Odd array contains more uppercase characters!!!");
            }
            else
            {
                Console.WriteLine("Even array contains more uppercase characters!!!");
            }
        }
    }
}