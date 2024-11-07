internal class Program
{
    static void songuyento(int ts)
    {
        int s = 0;
        for (int i = 1,dem = 0; i <= ts; i++)
        {
            for (int j = 2; j < i; j++)
            {
                if (i % j == 0)
                {
                    dem++;
                }
            }
            if (dem <1)
            {
                s = s + i;
            }
        }
        Console.WriteLine("ket qua s={0}",s);

    }
    static void Main(string[] args)
    {
        int n;
        Console.Write("hay nhap so n: ");
        n = Convert.ToInt32(Console.ReadLine());
        songuyento(n);   
    }
}