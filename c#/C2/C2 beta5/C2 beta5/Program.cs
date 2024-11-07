internal class Program
{
    static void Main(string[] args)
    {
        int t, n;
        Console.Write("nhap so nam: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so thang: ");
        t = Convert.ToInt32(Console.ReadLine());
        switch (t) 
        {
            case 4:
            case 6:
            case 9:
            case 11: Console.WriteLine("thang do co 30 ngay");
                break;
            case 2:
                if (n % 4 ==0)
                {
                    Console.WriteLine("thang do co 29 ngay");
                }
                else { Console.WriteLine("thang do co 28 ngay");
                }
                break;
            default: Console.WriteLine("thang do co 31 ngay"); break;
        }
    }
}