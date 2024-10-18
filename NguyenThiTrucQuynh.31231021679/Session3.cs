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
            Question_01();
            //Question_02();
            //Question_03();
           
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










    }
}
