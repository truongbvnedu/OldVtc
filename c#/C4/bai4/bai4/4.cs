class ptb2
{
    public int a;
    public int b;
    public int c;
    public int dental;
    public double x1, x2;
    public void nhap()
    {
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so c: ");
        c = Convert.ToInt32(Console.ReadLine());
    }
    public void giaipt()
    {
       
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
    public void ink1()
    {
        Console.WriteLine("phuong trinh {0}x^2 + {1}x + {2} = 0 co:", a, b, c);
        giaipt();
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        ptb2 ptmoi = new ptb2();
        ptmoi.nhap();
        ptmoi.ink1();
    }
}
