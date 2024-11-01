using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class Session5
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04a();
            //Question_04b();
            //Question_05();
            //Question_06();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }
        /// <summary>
        /// Write a C# function to find the maximum of three numbers.
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Type random number a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Type random number b: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Type random number c: ");
            int c = int.Parse(Console.ReadLine());

            int max = Max2Num(Max2Num(a, b), c);



            static int Max2Num(int a, int b)
            {
                return a > b ? a : b;
            }
            static int Max3Num(int a, int b, int c)
            {
                return Max2Num(Max2Num(a, b), c);
            }

            Console.WriteLine($"The maximum of three numbers is: {max}");
        }

        /// <summary>
        /// Write a C# function to calculate the factorial of a number (a non-negative integer)
        /// </summary>
        public static void Question_02()
        {
            do
            {
                Console.Write("Nhap 1 so tu nhien bat ky a de tinh giai thua: ");
                int a = int.Parse(Console.ReadLine());

                if (a < 0)
                {
                    Console.WriteLine("Vui long nhap so tu nhien khong am.");
                    continue;
                }
                else
                {
                    long factorial = 1;

                    for (int i = 1; i <= a; i++)
                    {
                        factorial *= i; // Calculate factorial
                    }

                    Console.WriteLine($"Giai thua cua {a}! la: {factorial}");
                    break;
                }
               
            } while (true);
        }
        /// <summary>
        /// Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        /// </summary>
        public static void Question_03()
        {


        }
        /// <summary>
        /// Write a C# function to print: all prime numbers that less than a number (enter prompt keyboard).

        /// </summary>
        public static void Question_04a()
        {

        }
      

        /// <summary>
        ///  Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        /// </summary>
        public static void Question_05()
        {

        }
        /// <summary>
        /// Write a C# function to check whether a string is a pangram or not.
        /// </summary>
        public static void Question_06()
        {

        }
    }
}
