internal class Program
{   
    static void pt1()
    {
        int a, b;
        double x;
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("phuong trinh {0}x + {1} = 0 co", a, b);
        if (a == 0)
        {
            if (b == 0)
            {


                Console.WriteLine(" vo so nghiem");

            }
            else { Console.WriteLine(" vo ngiem"); }
        }
        else
        {
            x = -b / a;
            Console.WriteLine("ket qua la x = {0}", Math.Round(x, 2));
        }
    }
    static void pt2()
    {
        int a, b, c;
        double x1, x2, dental;
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so c: ");
        c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("phuong trinh {0}x^2 + {1}x + {2} = 0 co:", a, b, c);
        if (a == 0)
        {
            if (b == 0)
            {
                if (c == 0)
                {


                    Console.WriteLine(" vo so nghiem");

                }
                else { Console.WriteLine(" vo ngiem"); }
            }
            else
            {
                x1 = -c / b;
                Console.WriteLine("ket qua la x= {0}", Math.Round(x1, 2));
            }

        }
        else
        {
            dental = b * b - (4 * a * c);
            if (dental < 0) { Console.WriteLine(" vo nghiem"); }
            else if (dental == 0)
            {
                x1 = -b / 2 * a;
                Console.WriteLine("co nghiem kep x1=x2={0}", Math.Round(x1, 2));
            }
            else if (dental > 0)
            {
                x1 = (-b + Math.Sqrt(dental)) / 2 * a;
                x2 = (-b - Math.Sqrt(dental)) / 2 * a;
                Console.WriteLine("x1={0}", Math.Round(x1, 2));
                Console.WriteLine("x2={0}", Math.Round(x2, 2));

            }
        }
    
}
    static void hoanvi()
    {
        int a, b,t;
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        t = a;
        a = b;
        b = t;
        Console.WriteLine("so a la:{0}", a);
        Console.WriteLine("so b la:{0}", b);
    }
    static void Main(string[] args)
    {
        int t;
        Console.Write("1.giai phuong trinh bat 1\n2.giai phuong trinh bat 2\n3.hoan vi hai so");
        t = Convert.ToInt32(Console.ReadLine());
        switch (t)
        {
            case 1:pt1(); break;
            case 2:pt2(); break;
            case 3: hoanvi(); break;
            default: Console.WriteLine("sai cu phap vui long nhap lai");break;
        }
    }
}