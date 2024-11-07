// See https://aka.ms/new-console-template for more information
internal class Program
{
    static void Main(string[] age)
    {
        double a, b, thuong;
        Console.Write("nhap so A:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap so B:");
        b = Convert.ToDouble (Console.ReadLine());
        thuong = a / b;
        Console.WriteLine("ket qua cua phep chia {0} / {1} = {2}", a, b, Math.Round(thuong,2));

    }
}