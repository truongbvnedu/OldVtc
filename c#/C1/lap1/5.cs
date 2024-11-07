internal class Program
{
    static void Main(string[] args)
    {
        int n,t;
        double s;
        s = 0;
        Console.Write("hay nhap n:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("tinh:");
        Console.WriteLine("1.S= 1 + 2 +...+ n\n2.S= 1^2 + 2^2 + ... + n^2\n3.S= 1+ 1/2 + ... + 1/n\n4.S= 1 * 2 * ... * n");
        Console.WriteLine("hay nhap thao tac:");
        t = Convert.ToInt32(Console.ReadLine());
        switch (t) 
        {
            case 1:
                for (int i = 1; i < n; i++)
                {
                    s = s + i;
                }
                Console.WriteLine("ket qua S={0}", s); break;
            case 2:
                for (int i = 1;i < n; i++)
                {
                    s = s + (i*i);
                }
                Console.WriteLine("ket qua S={0}", s); break;
            case 3:
                for (int i = 1; i < n; i++)
                {
                    s = s + 1/i;
                }
                Console.WriteLine("ket qua S={0}", s); break;
            case 4:
                s = 1;
                for (int i = 1; i < n; i++)
                {
                    s = s * i;
                }
                Console.WriteLine("ket qua S={0}", s); break;
            default: Console.WriteLine("sai cu phap vui long khoi dong lai ct");
                break;

        }
    }
}