internal class Program
{
    static void Main(string[] args)
    {
        int a, b, uc;
        Console.Write("nhap so a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b:");
        b = Convert.ToInt32(Console.ReadLine());
        while (b > 0)
        {
            uc = a;
            a = b;
            b = uc % a;
        }
        Console.WriteLine("USCLN(a,b)={0}", a);
    }
}