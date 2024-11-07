// See https://aka
// .ms/new-console-template for more information
internal class Program
{
    static void Main(string[] args)
    {
        int a, b, tong;
        Console.Write("Nhap a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap b:");
        b = Convert.ToInt32(Console.ReadLine());
        tong = a + b;
        Console.WriteLine("Ket qua : {0}", tong);
        Console.WriteLine("phep tinh {0} + {1} = {2}", a, b, tong);
        Console.ReadKey();
    }
}