internal class Program
{
    static void sochan(int ts1,int ts2)
    {
        int s = 0;
        for (int i = ts1; i <= ts2; i++)
        {
            if (i % 2 ==0)
            {
                s = s + i;
            }
        }
        Console.WriteLine("tong cac so chan tu M->N la: {0}",s);
    }
    static void sole(int ts1,int ts2)
    {
        int s = 0;
        for(int i = ts1; i <= ts2; i++)
        {
            if (i % 2 != 0)
            {
                s = s + i;
            }
        }
        Console.WriteLine("tong cac so le tu M->N la: {0}", s);
    }
    static void Main(string[] args)
    {
        int m, n;
        Console.Write("nhap so N(M<N): ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so M(M<N): ");
        m = Convert.ToInt32(Console.ReadLine());
        if (m<n)
        {
            sochan(m, n);
            sole(m, n);

        }
        else { Console.WriteLine("co loi xay ra hay nhap so M<N "); }
    } 
}