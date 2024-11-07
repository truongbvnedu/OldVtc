internal class Program {
    static void fb(int ts)
    {
        int[] FB;
        FB = new int[ts];
        FB[0] = 1;
        FB[1] = 1;
        for (int i = 2;i < ts; i++)
        {
            FB[i] = FB[i - 1] + FB[i - 2];
        }
        Console.Write("day so Fibonacy la:");
        for (int i = 0;i < ts ; i++)
        {
            Console.Write(FB[i] + " ");
        }
    }

    static void Main(string[] args)
    {
        int n;
        Console.Write("hay nhap so n de tao thanh day so Fibonacy:");
        n = Convert.ToInt32(Console.ReadLine());
        fb(n);

    }
}