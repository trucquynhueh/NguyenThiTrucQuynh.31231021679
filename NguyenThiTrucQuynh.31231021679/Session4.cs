using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class Session4
    {
        public static void Main()
        {

            Question_02();
            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }
        /// <summary>
        /// Write a C# Sharp program to display certain values of the function x = y2+ 2y + 1 (using integer numbers for y, ranging from -5 to +5).
        /// </summary>
        public static void Question_02()
        {

            do
            {
                Console.Write("Enter a number y = ");
                {

                    int y = int.Parse(Console.ReadLine());


                    if (y < -5 || y > 5)
                    {
                        Console.WriteLine("Vui long nhap so tu -5 den 5");
                        continue;

                    }
                    else
                    {
                        double x = Math.Pow(y, 2) + (2 * y) + 1;
                        Console.WriteLine($"The result = {x}");
                        break;
                    }
                }
            } while (true);
        }
    }
}

                