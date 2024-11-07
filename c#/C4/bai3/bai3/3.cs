class tamgiac
{
    public int a;
    public int b;
    public int c;
    public void nhap()
    {
        Console.Write("hay nhap so a:");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap so b:");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap so c:");
        c = Convert.ToInt32(Console.ReadLine());
    }
    public bool kiemtra()
    {
        if (a+b >c || a+c>b || b+c> a)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public int chuvi()
    {
        return a+b+c;
    }
    public void inkq()
    {
        if (kiemtra())
        {
            Console.WriteLine("chu vi cua tam giac la:{0}", chuvi());
        }
        else
        {
            Console.WriteLine("ba canh nay khong tao nen 1 tam giac:");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        tamgiac tg = new tamgiac();
        tg.nhap();
        tg.inkq();
    }
}