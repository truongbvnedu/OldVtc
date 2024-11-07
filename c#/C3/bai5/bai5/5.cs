internal class Program
{
    static int luythua(int ts)
    {
        int s=1;
        for (int i = 1; i < ts; i++) {
            s = s * i;
                }
        return s;
    }
    static int tonfb(int ts)
    {
        int s = 0;
        int a = 1;
        int b = 1;
        int fib = 0;
        for (int i = 3; i <= ts; i++)
        {
            fib = a + b;
            s = s + fib;
            a = b;
            b = fib;
        }
        return s;

    }
    static void Main(string[] args)
    {
        int n,m;
        int s = 0;
        Console.Write("hay nhap so N:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap so M:");
        m = Convert.ToInt32(Console.ReadLine());
        s = luythua(m) + tonfb(n);
        Console.WriteLine("ket qua cua ct s={0}",s);
    }
}