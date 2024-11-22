using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NguyenThiTrucQuynh._31231021679
{
    internal class Session8
    {
        public static void Main(string[] args)
        {
            string s1 = "con cho quynh nhu!";
            string s2 = "con cho bao nghi";
            //to input a string and print it.
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(len(s1));


            print(s1);
            Console.WriteLine();
            printReverse(s1);
            Console.WriteLine($"Tong cac tu cua chuoi la: {CountWords(s1)}");


            compare(s1 , s2);
            Console.WriteLine(compare(s1, s2));



            //to separate individual characters from a string.
            static void print(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine(s[i]);
                }
            }

            //to find the length of a string without using a library function.
            static int len(string s)
            {
                int l = 0;
                foreach (char c in s)
                    l++;
                return l;
            }

            //to print individual characters of the string in reverse order.
            static void printReverse(string s)
            {
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    Console.WriteLine(s[i]);
                }
            }

            //to count the total number of words in a string.
            static int CountWords(string s)
            {
                int wordCount = 0;
                bool inWord = false;
                foreach (char c in s)
                {
                    if (Char.IsWhiteSpace(c))
                    {
                        if (inWord)
                        {
                            wordCount++;
                            inWord = false;
                        }
                    }
                    else
                    {
                        inWord = true;
                    }
                }
                if (inWord)
                    wordCount++;

                return wordCount;
            }

       
            static int compare(string s1, string s2)
            {
                int min = s1.Length > s2.Length ? s1.Length : s2.Length;
                int i = 0;  
                while (i < min)
                {
                    if ((s1[i] > s2[i])) return 1;
                    else if ((s1[i] < s2[i])) return -1;
                    i++;
                }
                    if (s1.Length > s2.Length) return 1;
                    else if (s1.Length < s2.Length) return -1;
                    return 0;
            }
            
           

        }
    }
}
    