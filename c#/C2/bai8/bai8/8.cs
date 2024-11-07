using System.Net;

internal class Program
{
    static void Main(string[] args)
    {
        int n;
        int dem = 0;
        Console.Write("nhap so n:");
        n = Convert.ToInt32(Console.ReadLine());
        for (int i = 2; i <= n; i++) 
        {
            if (n % i == 0) { dem++; }
        }
        if (dem >= 1 || n == 1)
        {
            Console.WriteLine("so n la so nguyen to");
        }
        else
        {
            Console.WriteLine("so n khong phai la so nguyen to");
        }
    }
}