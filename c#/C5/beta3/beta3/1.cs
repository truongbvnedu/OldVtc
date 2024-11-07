class phanso
{
    public int tuso;
    public int mauso;
    public phanso() 
    {
        tuso = 3; mauso = 10;
    }
    public phanso(int tu)
    {
        this.tuso = tu;
        mauso = 10;
    }
    public phanso(int tu, int mau)
    {
        this.tuso = tu;
        this.mauso = mau;
    }
    public int thuong()
    {
        return mauso / tuso;
    }
    public int sodu() 
    {
        return mauso % tuso;
    }
    public void inkq()
    {
        Console.WriteLine("ket qua cua ({0}/{1}) la :{2}", mauso, tuso, thuong());
        Console.WriteLine("du ra {0}", sodu());
    }
    static void Main(string[] args)
    {
        phanso ps = new phanso();
        ps.inkq();
        int n, b;
        Console.WriteLine("--------------------------");
        Console.Write("hay nhap mau so: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("hay nhap tu so: ");
        b = Convert.ToInt32(Console.ReadLine());
        phanso ps2 = new phanso(b,n);
        ps2.inkq();

    }
}