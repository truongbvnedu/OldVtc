class crectang 
{
    private int dai;
    private int rong;
    public int Dai
    {
        get { return dai; }
        set { dai = value; }
    }
    public int Rong
    {
        get { return rong; }
        set { rong = value; }
    }
    public int chuvi()
    {
        
        return (dai + rong ) * 2;
    }
    public int dientich()
    {
        
        return dai * rong;
    }
    public void inkq()
    {
        Console.WriteLine("chu vi cua hinh nay la: {0}", chuvi());
        Console.WriteLine("dien tich cua hinh nay la: {0}", dientich());
            }
}
internal class Program
{
    static void Main(string[] args)
    {
        crectang cre = new crectang();
        cre.inkq();
    }
}
