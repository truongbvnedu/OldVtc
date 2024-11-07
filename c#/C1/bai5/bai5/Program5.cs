
internal class Program
{
    static void Main(string[] args)
    {
        double a, b, c, P, S, p;
        Console.Write("hay nhap canh a:");
        a = Convert.ToDouble(Console.ReadLine());
        Console.Write("hay nhap canh b:");
        b = Convert.ToDouble(Console.ReadLine());
        Console.Write("hay nhap canh c:");
        c = Convert.ToDouble(Console.ReadLine());
        if (a + b >c || a +c >b|| c + b >a )
        {
            P = a + b + c;
            p = P / 2;
            S = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("chu vi cua tam giac la:{0}", P);
            Console.WriteLine("dien tich cua tam giac la: {0}", Math.Round(S, 2));
        }
        else
        {
            Console.WriteLine("ba canh nay khong tao nen tam gia vui long nhap lai");
        }
    }
}