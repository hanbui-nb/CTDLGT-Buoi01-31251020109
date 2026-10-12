using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CTDLGT_Buoi01_31251020109
{
    internal class Bai2
    {
        public static void Main(string[] args)
        {
            Console.Write($"So phan tu cua mang: "); int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Nhap mang: "); string mang = Console.ReadLine();
            string[] chuoi = mang.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            int[] arr = Array.ConvertAll(chuoi, int.Parse);
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            int max1 = arr[0];
            int max2 = arr[1];
            if (arr[0] == arr[1])
            {
                Console.WriteLine("NO");
            }
            else Console.WriteLine($"{max1} {max2}") ;
        }
    }
}
