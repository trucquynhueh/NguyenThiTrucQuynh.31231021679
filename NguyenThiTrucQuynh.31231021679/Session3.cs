using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class Session3
    {
        public static void Main()
        {

           //Question_01();
            Question_02();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();

        }


        /// <summary>
        /// Convert Celsius to Fahrenheit and vice versa
        /// </summary>
        public static void Question_01()
        {
            Console.Write("Enter a number in Celsius = ");
            float Celsius = float.Parse(Console.ReadLine());
            float Kelvin = Celsius + 273;
            float Fahrenheit = Celsius * 18 / 10 + 32;
            Console.WriteLine($"The Kelvin is = {Kelvin}");
            Console.WriteLine($"The Fahrenheit number is = {Fahrenheit}");

        }
        /// <summary>
        /// calculate the surface and volume of a sphere,
        /// </summary>
        public static void Question_02()
        {

            Console.Write("Enter a radius: ");
            double radius = double.Parse(Console.ReadLine());
            double surface = 4 * Math.PI * radius * radius;
            double volume = 4 / 3 * Math.PI * radius * radius * radius;
            
            Console.WriteLine($"The surface is = {surface}");
            Console.WriteLine($"The volume is= {volume}");
        }

        /// <summary>
        /// calculates the result of adding, subtracting,multiplying and dividing two numbers entered by the user.
        /// </summary>
        public static void Question_03()
        {

            Console.Write("Enter number a: ");
            Console.Write("Enter number b: ");
            float a = float.Parse(Console.ReadLine()); 
            float b = float.Parse(Console.ReadLine()); 
            float adding = a + b;
            

        }







    }
}
