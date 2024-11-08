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
        public static void Main9()
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
        public static void Question2()
        {
            static float calculatingFactorial(int n)
            {
                int demSo = 1;
                for (int i = 1; i <= n; i++)
                {
                    demSo *= i;
                }
                return demSo;
            }
            Console.Write("Enter n: ");
            int n = int.Parse(Console.ReadLine());
            float factorial = calculatingFactorial(n);
            Console.WriteLine("the factorial of number {0}: {1}", n, factorial);

        }

        public static void Question3()
        {
            static int checkingPrimeNumber(int n)
            {
                int demUoc = 0;
                for (int i = 1; i <= n; i++)
                {
                    if (n % i == 0)
                        demUoc++;
                }
                return demUoc;
            }
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int demUoc = checkingPrimeNumber(n);
            if (demUoc == 2)
                Console.WriteLine($"{n} is a prime number");
            else
                Console.WriteLine($"{n} is not a prime number");

        }
        public static void Question4_1()
        {
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Prime numbers less than {n}:");
            for (int i = 2; i < n; i++)
            {
                if (IsPrime(i) == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static int IsPrime(int number)
        {
            int value;
            int demUoc = 0;
            for (int j = 1; j <= number; j++)
            {
                if (number % j == 0)
                    demUoc++;
            }
            if (demUoc == 2)
            {
                value = 1;
            }
            else value = 0;
            return value;
        }

        static void Question4_2()
        {
            static void NPrimeNumber(int N)
            {
                int c = 0;
                for (int i = 2; c < N; i++)
                {
                    if (IsPrime(i) == 1)
                    {
                        Console.Write(i + " ");
                        c++;
                    }
                }
            }
            Console.Write("Enter a number: ");
            int N = int.Parse(Console.ReadLine());
            NPrimeNumber(N);
        }

        static void Question5()
        {
            static int checkingPerfectNumber(int n)
            {
                int value = 0;
                int tong = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        tong += i;
                    }
                }
                if (tong == n)
                    value = 1;
                else value = 0;
                return value;
            }
            static void printingPerfectNumber()
            {
                for (int i = 1; i < 1000; i++)
                {
                    if (checkingPerfectNumber(i) == 1)
                    {
                        Console.Write(i + " ");
                    }
                }
            }
            Console.Write("Enter a number: ");
            int n = int.Parse(Console.ReadLine());
            int value = checkingPerfectNumber(n);
            if (value == 1)
            {
                Console.WriteLine($"{n} is a perfect number");
            }
            else
                Console.WriteLine($"{n} is not a perfect number");
            Console.WriteLine("all perfect number that less than 1000: ");
            printingPerfectNumber();
            Console.WriteLine();
        }
      
        static void Question6()
        {
            static bool checkPangram(string str)
            {
                bool[] alphabet = new bool[26];
                int index = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    if ('A' <= str[i] && str[i] <= 'Z')
                        index = str[i] - 'A';
                    else if ('a' <= str[i] && str[i] <= 'z')
                        index = str[i] - 'a';
                    else
                        continue;
                    alphabet[index] = true;
                }
                for (int i = 0; i <= 25; i++)
                {
                    if (alphabet[i] == false)
                        return false;
                }
                return true;
            }
            Console.Write("Enter a sentence: ");
            string str = Console.ReadLine();
            if (checkPangram(str) == true)
                Console.WriteLine("{0} is a pangram", str);
            else
                Console.WriteLine("{0} is not a pangram", str);
        }
    }
}
