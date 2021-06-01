using System;
using System.Collections.Generic;

namespace Масивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[] { 6, 9, 6, 1, 9, 6, 9 };

            Console.WriteLine("Задание 1");

            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
            
            Console.WriteLine("Задание 2");
           
            int n = num.Length;
            int k = n / 2;
            int temp;
            for (int i = 0; i < k; i++)
            {
                temp = num[i];
                num[i] = num[n - i - 1];
                num[n - i - 1] = temp;

            }
            foreach (int i in num) 
            {
                Console.Write($" {i} \t");
            }
           
            Console.WriteLine(" ");
            Console.WriteLine("Задание 3");

            List<int> set = new List<int>();

            for (int f = 0; f < num.Length; f++) 
            {
                if (!set.Contains(num[f]))
                    set.Add(num[f]);
            }
            foreach (int f in set)
            {
                Console.WriteLine($" {f} \t");
            }
            //либо ShowArray(f); как замена методу foreach

           

        }

    }
    
    

}
