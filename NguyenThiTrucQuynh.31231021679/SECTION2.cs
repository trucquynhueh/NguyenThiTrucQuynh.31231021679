using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class SECTION2
    {
        public static void Main()
        {
            //Question_01();
            //Question_02();
            //Question_03();
            //Question_04();
            //Question_05();
            //Question_06();
            //Question_07();
            //Question_08();
            //Question_09();
            //Question_10();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }


        /// <summary>
        /// Add / Sum Two Numbers
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b =");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            int product = a * b;

            Console.WriteLine($"(a) + (b) = {sum}");
            Console.WriteLine($"(a) * (b) = {product}");
        }

        /// <summary>
        /// Swap Values of Two Variables
        /// </summary>
        public static void Question_02()
        {
            Console.Write("Enter a number a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter a number b =");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine($"Swap: a = {b}, b = {a}");
        }

        /// <summary>
        /// Multiply two Floating Point Numbers
        /// </summary>
        public static void Question_03()
        {

            Console.Write("Enter a floating point numbers a =");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Enter a floating point number b =");
            float b = float.Parse(Console.ReadLine());
            float multiply = a * b;

            Console.WriteLine($"(a) * (b) = {multiply}");

        }

        /// <summary>
        /// Convert feet to meter
        /// </summary>
        public static void Question_04()
        {

            Console.Write("Enter feet a =");
            float a = float.Parse(Console.ReadLine());
            double meter = a / 0.3048;
            Console.WriteLine($"The length in meter is = {meter}");


        }

        /// <summary>
        /// Convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_05()
        {
            Console.Write("Enter a number in Celsius =");
            float Celsius = float.Parse(Console.ReadLine());
            double Fahrenheit = Celsius * 33.8;
            Console.WriteLine($"The Fahrenheit number is = {Fahrenheit}");


            Console.Write("Enter a number in Fahrenheit1 =");
            float Fahrenheit1 = float.Parse(Console.ReadLine());
            double Celsius1 = Fahrenheit1 * 33.8;
            Console.WriteLine($"The Celsius number is = {Celsius1}");

        }
        /// <summary>
        /// find the Size of data types
        /// </summary>
        public static void Question_06()
        {
            Console.Write("Enter a file path x: ");
            string filePath = Console.ReadLine();
            int x = sizeof(double);
            FileInfo fileInfo = new FileInfo(filePath);
            Console.WriteLine($"File size: {fileInfo.Length} byte(s)");
            Console.WriteLine($"Size of a double: {x} byte(s) ");


        }
        /// <summary>
        /// Print ASCII Value (tip: read character, print number of this char)
        /// </summary>
        public static void Question_07()
        {
            Console.Write("Enter a character: ");
            char character = Console.ReadKey().KeyChar;

            int asciiValue = (int)character; 

            Console.WriteLine($"The ASCII value is = {asciiValue}");

        }
        /// <summary>
        /// Calculate Area of Circle
        /// </summary>
        public static void Question_08()
        {
            Console.Write("Enter the radius of the circle a: ");
            double a = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(a, 2);

            Console.WriteLine($"The area of the circle is = {area}");


        }


        /// <summary>
        /// Calculate Area of Square
        /// </summary>
        public static void Question_09()
        {
            Console.Write("Enter the length of the corner a: ");
            double a = double.Parse(Console.ReadLine());
            double area = a * a;


            Console.WriteLine($"The area of the square is = {area}");

        }
        /// <summary>
        /// Convert days to years, weeks and days
        /// </summary>
        public static void Question_10()
            {///375 = 1 year 1 week 3 days

                Console.Write("Enter the date: ");
                int days = int.Parse(Console.ReadLine());
                int years = days / 365;
                int day_w = days - years * 365;
                int weeks = day_w / 7;
                int d = day_w % 7;

                Console.WriteLine($"The days to years, weeks and days is = {years} year(s), {weeks} week(s), and {d} day(s).");

            }

        }
}
