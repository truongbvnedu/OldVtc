using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace betatry
{
    internal class Program
        {
         static void Main(string[] args)
            {
                double a, b, c;
                Console.Write("hay nhap a: ");
                a = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("hay nhap b: ");
                b = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                Console.Write("hay nhap c: ");
                c = Convert.ToDouble(Console.ReadLine());
                Console.Write("\n");
                pt2 phuongtrinh = new pt2(a, b, c);
                Console.WriteLine("phuong trinh {0}x^2 + {1}x + {2} = 0 co:", a, b, c);
                phuongtrinh.giaipt2();
            }
        }
    }

