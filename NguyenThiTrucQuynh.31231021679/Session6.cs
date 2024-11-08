using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class Session6
    {

        public static void Main()
        {
            Console.Write("Nhap so phan tu mang n: ");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Chosongaunhien(a);
            Inra(a);
            Sum(a);
          
        }

        static void Chosongaunhien(int[] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(100);
            }
        }
        static void Inra(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]);
                if (i < a.Length - 1)
                {
                    Console.Write(", ");
                }
                // If it's the last element, print a period
                else
                {
                    Console.Write(".");
                }
            }
            Console.WriteLine();
        }

        static void Sum(int[] a)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
                sum += a[i];
            Console.WriteLine($"Tong cua cac so tren la: {sum}");
            double average = (double)sum / a.Length;
            Console.WriteLine($"Trung binh cua cac so tren la: {average}");

        }
    }
}
