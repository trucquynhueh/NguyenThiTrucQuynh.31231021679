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

             //Question_02();
             //Question_03();
             //Question_05();
            
             //Ex_01();
             Ex_02();

            
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

/// <summary>
/// Take distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour(km/h) and miles per hour(miles/h)
/// </summary>
public static void Question_03()
{
    //Get distance input
    Console.Write("Enter distance in kilometers: ");
    double distance = Convert.ToDouble(Console.ReadLine());

    // Get time input
    Console.Write("Enter time - hours: ");
    int hours = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter time - minutes: ");
    int minutes = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter time - seconds: ");
    int seconds = Convert.ToInt32(Console.ReadLine());

    // Calculate time 
    double time_hours = hours + (minutes / 60) + (seconds / 3600);

    // Calculate speeds
    double kmperhour = distance / time_hours;
    double mileperhour = kmperhour * 0.621371;  // 1 km = 0.621371 miles


    Console.WriteLine($"Speed in kilometers per hour(km/h): {kmperhour} km/h");
    Console.WriteLine($"Speed in miles per hour: {mileperhour} miles/h");

}


/// <summary>
///  takes a character as input and checks if it is a vowel, a digit, or any other symbol.
/// </summary>
public static void Question_05()

{

    Console.Write("Enter a character: ");
    char inputchar = Console.ReadKey().KeyChar;
    inputchar = char.ToUpper(inputchar);
    Console.WriteLine();

    //Dieu kien
    if (inputchar == 'A' || inputchar == 'E' || inputchar == 'I' || inputchar == 'O' || inputchar == 'U')
    {
        Console.WriteLine("The character is a vowel.");
    }

    else if (char.IsDigit(inputchar))
    {
        Console.WriteLine("The character is a digit.");
    }
    else
    {
        Console.WriteLine("The character is other symbol.");
    }
}
            public static void Ex_01()
        {

            Console.Write("Enter the length of the side a: ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the side b: ");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the length of the side c: ");
            double c = Convert.ToDouble(Console.ReadLine());

            // Check if sides can form a triangle
            if (a + b > c && a + c > b && b + c > a)
            {
                if (a == b && b == c)
                    Console.WriteLine("Equilateral triangle");
                else if (a == b || b == c || a == c)
                    Console.WriteLine("Isosceles triangle");
                else
                    Console.WriteLine("Scalene triangle");
            }
            else
            {
                Console.WriteLine("The sides do not form a triangle");
            }
        }

    }


    /// <summary>
    ///  read 10 numbers and find their average and sum.
    /// </summary>
    public static void Ex_02();
        {
     double sum = 0;

        // Read 10 numbers from the user
        for (int i = 1; i <= 10; i++)
        {
            Console.Write("Enter number " + i + ": ");
            double number = Convert.ToDouble(Console.ReadLine());
    sum += number; // Add each number to the sum
        }

double average = sum / 10; // Calculate the average


Console.WriteLine("$Sum:{sum}");
            Console.WriteLine("$Average: {average}");
   
        }

public static void Ex_03() { 
    
    
    }



}

                
