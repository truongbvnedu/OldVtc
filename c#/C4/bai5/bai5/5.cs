class hinhtru
{
    public int chieucao;
    public int bankinh;
    public double pi = 3.14;
    public void nhap()
    {
        Console.Write("hay nhap chieu cao:");
        chieucao = Convert.ToInt16(Console.ReadLine());
        Console.Write("hay nhap ban kinh:");
        bankinh = Convert.ToInt16(Console.ReadLine());
    }
    public double dientich()
    {
        return (2 * pi * chieucao*bankinh) +(2*pi*bankinh*bankinh) ;
    }
    public double thetich()
    {
        return pi * chieucao * bankinh * bankinh;
    }
    public void inkq()
    {
        Console.WriteLine("dien tich toan phan cua hinh tru nay la:{0}",Math.Round(dientich(),2));
        Console.WriteLine("the tich cua hinh tru nay la:{0}",Math.Round(thetich(),2));
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        hinhtru hinhmoi = new hinhtru();
        hinhmoi.nhap();
        hinhmoi.inkq();
    }
}
