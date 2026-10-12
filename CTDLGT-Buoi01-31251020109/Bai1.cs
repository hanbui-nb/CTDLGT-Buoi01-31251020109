using System;
using System.Collections.Generic;
using System.Text;

namespace CTDLGT_Buoi01_31251020109
{
    internal class Bai1
    {
        public static void Main1(string[] args)
        {
            int max = 0;
            int min = 0;
            double sum = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.Write($"Nhap so nguyen thu {i}: "); int a = Convert.ToInt32(Console.ReadLine());
                if (i == 1) max = a;
                sum += a;
                if (a > max)
                {
                    max = a;
                }
                if (a < min)
                {
                    min = a;
                }
            }
            double average = Math.Round(sum / 3,2);
            Console.WriteLine($"Lon nhat: {max}");
            Console.WriteLine($"Nho nhat: {min}");
            Console.WriteLine($"Tong: {sum}");
            Console.WriteLine($"Trung binh: {average}");
        }
    }
}
