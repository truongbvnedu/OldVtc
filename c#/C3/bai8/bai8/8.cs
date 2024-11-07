internal class Program
{
    static void nhap(int ts)
    {
        int[] mang;
        mang = new int[ts];
        for (int i = 0; i <= ts; i++) 
        {
            Console.Write("hay nhap phan mang[{0}]: ", i);
            Convert.ToInt32(mang[i]);
        }
        for (int i = 0;i <= ts; i++)
        {
            Console.WriteLine(mang[i] );
        }
    }

    static void Main(string[] args)
    {
        int n;
        Console.Write("hay nhap so phan tu cho mang: ");
        n = Convert.ToInt32(Console.ReadLine());
        nhap(n);
    }
}