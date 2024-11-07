internal class Program
{
    static void Main(string[] args)
    {
        int n, lt, i;
        Console.Write("nhap so n:");
        n = Convert.ToInt32(Console.ReadLine());
        lt = 1;
        for (i = 1; i <= n; i++)
        {
            lt = lt * i;
        }
        Console.WriteLine("ket qua bang :{0}", lt);
    }
}