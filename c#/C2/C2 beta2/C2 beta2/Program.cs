internal class Program
{
    static void Main(string[] args)
    {
        int n, tong, i;
        Console.Write("nhap so n:");
        n = Convert.ToInt32(Console.ReadLine());
        tong = 0;
        for (i=0; i <= n; i++)
        {
            if ( i % 2==0 )
            {
                tong = tong + i; 
            }
        }
        Console.WriteLine("ket qua la: {0}", tong);
    }
}