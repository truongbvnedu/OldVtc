class hinhchunhat
{
    public int dai;
    public int rong;
    public  void nhap()
    {
        Console.Write("hay nhap chieu dai");
        dai = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap chieu rong");
        rong = Convert.ToInt32(Console.ReadLine());
    }
    public int chuvi()
    {
        return (dai + rong) * 2;
    }
    public int dientich()
    {
        return dai * rong;
    }
    public void inkq()
    {
        Console.WriteLine("chu vi hinh chu nhat la:{0}",chuvi());
        Console.WriteLine("dien tich hinh chu nhat la:{0}",dientich());
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        hinhchunhat hinhcn = new hinhchunhat();
        hinhcn.nhap();
        hinhcn.inkq();
    }
}