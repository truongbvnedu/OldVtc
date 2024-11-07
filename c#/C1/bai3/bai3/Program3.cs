internal class Program
{
    static void Main(string[] ane)
    {
        int r;
        float pi = 3.14f;
        float P, S;
        Console.Write("nhap ban kinh hinh tron:");
        r = Convert.ToInt32(Console.ReadLine());
        P = 2 * pi * r;
        S = pi * r * r;
        Console.WriteLine("chu vi hinh tron la {0}", Math.Round(P,2));
        Console.WriteLine("dien tich cua hinh tron la {0}", Math.Round(S, 2));
    }
}