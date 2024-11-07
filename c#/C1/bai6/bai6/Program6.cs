internal class Program
{
    static void Main(string[] args)
    {
        double a, P, S, dc;
        Console.Write("hay nhap canh a cua hinh vuong:");
        a = Convert.ToDouble(Console.ReadLine());
        P = a * 4;
        S = a * a;
        dc = Math.Sqrt(a)/2;
        Console.WriteLine("chu vi hinh vuong la:{0}", P);
        Console.WriteLine("dien tich hinh vuong la: {0}", S);
        Console.WriteLine("duong cheo hinh vuong la: {0}", Math.Round(dc, 2));
    }
}