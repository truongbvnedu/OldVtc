internal class Program
{
    static void Main(string[] age)
    {
        int cd, cr, S, P;
        Console.Write("nhap chieu dai:");
        cd = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap chieu rong:");
        cr = Convert.ToInt32(Console.ReadLine());
        S = cd * cr;
        P = (cr + cd) * 2;
        Console.WriteLine("chu vi hinh chu nhat la p = {0}", P);
        Console.WriteLine("dien tich hinh chu nhat la S = {0}", S);
    }
}