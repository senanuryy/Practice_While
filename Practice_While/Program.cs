﻿using System;

namespace Practice_For
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 -> Konsol ekranına 10 kere \"Kendime inanıyorum, ben bu yazılım işini hallederim!\" yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------------------------------------");

            int i = 1;

            while (i <= 10)
            {
                Console.WriteLine($"{i}. Kendime inanıyorum, ben bu yazılım işini hallederim!");
                i++;
            }

            Console.WriteLine("\n2 -> 1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.");
            Console.WriteLine("---------------------------------------------------------------");

            int j = 1;
            
            while (j <=20 )
            {
                Console.WriteLine(j);
                j++;
            }

            Console.WriteLine("\n3 -> 1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.");
            Console.WriteLine("--------------------------------------------------------------------");
            
            int k = 1;
           
            while (k <= 20 )
            {
                if (k % 2 == 0)
                {
                    Console.WriteLine(k);
                }
                k++;
            }

            Console.WriteLine("\n4 -> 50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------");

            int l = 50;
            int sum = 0;

            while (l <= 150)
            {
                sum += l;
                l++;
            }

            Console.WriteLine(sum);

            Console.WriteLine("\n5 -> 1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.");
            Console.WriteLine("-------------------------------------------------------------------------------------------");

            int m = 1;
            int sumOdd = 0;
            int sumEven = 0;

            while(m <=120)
            {
                if(m % 2 == 0)
                {
                    sumEven += m;
                }
                else
                {
                    sumOdd += m;
                }

                m++;
            }
            Console.WriteLine($"Tek sayıların toplamı: {sumOdd}");
            Console.WriteLine($"Çift sayıların toplamı: {sumEven}");
        }
    }
}