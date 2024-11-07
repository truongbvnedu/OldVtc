using System.Security.Cryptography.X509Certificates;

class hinhtron
{
    public double bankinh;
    public hinhtron(double bankinh = 4)
    {
        this.bankinh = bankinh;
    }
    public hinhtron(int bankinh)
    {
        this.bankinh = bankinh;
    }
    public double dientich()
    {
        return bankinh*bankinh*Math.PI;
    }
    public double chuvi()
    {
        return 2 * bankinh * Math.PI;
    }
    public static hinhtron operator ++(hinhtron Bankinh)
    {
        Bankinh.bankinh++;
        return Bankinh;
    }
    public static hinhtron operator --(hinhtron Bankinh)
    {
        Bankinh.bankinh--;
        return Bankinh;
    }
    public static double operator -(hinhtron dt1, hinhtron dt2)
    {
       return dt1.dientich() - dt2.dientich();

    }
    public static double operator +(hinhtron dt1, hinhtron dt2)
    {
        return dt1.dientich() + dt2.dientich();
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        hinhtron ht = new hinhtron();
        Console.WriteLine("chu vi cua hinh tron 1 la: {0}", Math.Round(ht.chuvi(), 2));
        Console.WriteLine("dien tich cua hinh tron 1 la: {0}", Math.Round(ht.dientich(), 2));
        hinhtron ht1 = new hinhtron(10);
        Console.WriteLine("chu vi cua hinh tron 2 la: {0}", Math.Round(ht1.chuvi(), 2));
        Console.WriteLine("dien tich cua hinh tron 2 la: {0}", Math.Round(ht1.dientich(), 2));
        double tong = ht + ht1;
        double hieu = ht - ht1;
        Console.WriteLine("tong dien tich hai hinh tron la: {0}", tong);
        Console.WriteLine("hieu dien tich hai hinh tron la: {0}", hieu);
        ht++;
        Console.WriteLine("ban kinh cua hinh tron 1: {0}", ht.bankinh);
        ht1++;
        Console.WriteLine("ban kinh cua hinh tron 2: {0}", ht1.bankinh);
        

    }
}