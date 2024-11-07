class cylinder
{
    public int r;
    public int cao;
    static int count = 0;
    public double pi = 3.14;
    static void dem()
    {
        count++;
    }
    public cylinder()
    {
        r = 3; cao = 10;
    }
    public cylinder(int bankinh)
    {
        this.r = bankinh;
        cao = 10;
    }
    public cylinder(int bankinh,int cao)
    {
        this.r = bankinh;
        this.cao = cao;
    }
    public double p() 
    {
        return 2 * pi * r * cao;
    }
    public double s()
    {
        return 2*pi * r * r + p();
    }
    public void inkq()
    {
        Console.WriteLine("chu vi cua hinh tru la : {0}", Math.Round(p(),2));
        Console.WriteLine("dien tich cua hinh tru la :{0}", Math.Round(s(), 2));
    }
    static void Main(string[] args)
    {
        cylinder cy1 = new cylinder();
        cy1.inkq();
        int a, b;
        Console.WriteLine("-----------------------");
        Console.Write("hay nhap ban kinh: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap chieu cao: ");
        b = Convert.ToInt32(Console.ReadLine());
        cylinder cy2 = new cylinder(a,b);
        cy2.inkq();
        Console.WriteLine("{0}", count);
    }
}