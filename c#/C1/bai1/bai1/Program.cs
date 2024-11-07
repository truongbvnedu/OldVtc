internal    class Program
{
    static void Main(string[] age)
    {
        int a, b, c, tong, tich;
        Console.Write("Nhap a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Nhap c:");
        c = Convert.ToInt32(Console.ReadLine());
        tong = a + b + c; 
        tich= a * b  * c;
        Console.WriteLine("ket qua cua phep tong {0} + {1} + {2} = {3}", a, b, c, tong);
        Console.WriteLine("ket qua cua phep nhan {0} X {1} X {2} = {3}", a, b, c, tich);

    }
}