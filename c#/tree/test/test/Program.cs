using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        int n, tong, i;
        Console.Write("nhap so n:");
        n = Convert.ToInt32(Console.ReadLine());
        tong = 0;
        for (i = 0; i < n; i++)
        {
            tong = tong + i;
        }
        Console.WriteLine("ket qua bang :{0}", tong);
    }
}