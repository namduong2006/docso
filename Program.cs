using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace sochu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            ushort s;
            int t, c,c12, dv;
            Console.WriteLine("Mời nhập số nguyên dương (0-999) cần đọc : ");
            s = ushort.Parse(Console.ReadLine());
            t = s / 100;
            c12 = (s % 100) / 10;
            c = (s % 100);
            dv = s % 10;
           switch (t)
            {
                    case 0:
                    Console.Write(""); ;
                    break;
                    case 1:
                    Console.Write("one hundred and ");
                    break;
                    case 2:
                    Console.Write("two hundred and ");
                    break;
                    case 3:
                    Console.Write("three hundred and ");
                    break;
                    case 4:
                    Console.Write("four hundred and ");
                    break;
                    case 5:
                    Console.Write("five hundred and ");
                    break;
                    case 6:
                    Console.Write("six hundred and ");
                    break;
                    case 7:
                    Console.Write("seven hundred and ");
                    break;
                    case 8:
                    Console.Write("eight hundred and ");
                    break;
                    case 9:
                    Console.Write("nine hundred and ");
                    break;
                    
            }
            

            if (c >= 0 && c < 20)
            {
                switch (c)
                {
                    case 0:
                        Console.Write("zero");
                        break;
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                    case 10:
                        Console.Write("ten");
                        break;
                    case 11:
                        Console.Write("eleven");
                        break;
                    case 12:
                        Console.Write("twelve");
                        break;
                    case 13:
                        Console.Write("thirteen");
                        break;
                    case 14:
                        Console.Write("fourteen");
                        break;
                    case 15:
                        Console.Write("fifteen");
                        break;
                    case 16:
                        Console.Write("sixteen");
                        break;
                    case 17:
                        Console.Write("seventeen");
                        break;
                    case 18:
                        Console.Write("eighteen");
                        break;
                    case 19:
                        Console.Write("nineteen");
                        break;
                }

            }
            if (20<=c&&c <100)
            {
                switch (c12)
                {
                    case 2:
                        Console.Write("twenty ");
                        break;
                    case 3:
                        Console.Write("thirty ");
                        break;
                    case 4:
                        Console.Write("forty ");
                        break;
                    case 5:
                        Console.Write("fifty ");
                        break;
                    case 6:
                        Console.Write("sixty ");
                        break;
                    case 7:
                        Console.Write("seventy ");
                        break;
                    case 8:
                        Console.Write("eighty ");
                        break;
                    case 9:
                        Console.Write("ninety ");
                        break;
                }
                switch (dv)
                {
                    case 0:
                        Console.Write("zero");
                        break;
                    case 1:
                        Console.Write("one");
                        break;
                    case 2:
                        Console.Write("two");
                        break;
                    case 3:
                        Console.Write("three");
                        break;
                    case 4:
                        Console.Write("four");
                        break;
                    case 5:
                        Console.Write("five");
                        break;
                    case 6:
                        Console.Write("six");
                        break;
                    case 7:
                        Console.Write("seven");
                        break;
                    case 8:
                        Console.Write("eight");
                        break;
                    case 9:
                        Console.Write("nine");
                        break;
                }
            } 
            Console.ReadLine();
        }
    }
}
