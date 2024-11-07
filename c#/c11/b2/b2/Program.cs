using System;

internal class Program
{
    static void Swap<T>(ref T a, ref T b)
    {
        T tam = a;
        a = b;
        b = tam;
    }

    static void Main(string[] args)
    {
        int x, y;
        Console.Write("Nhap so can doi:a= ");
        x = Convert.ToInt32(Console.ReadLine());
        Console.Write(" b= ");
        y = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("2 so truoc khi doi a={0} / b={1}", x, y);
        Swap(ref x, ref y);
        Console.WriteLine();
        Console.WriteLine("2 so sau khi doi a={0} / b={1}", x, y);
    }
}