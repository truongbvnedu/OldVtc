public class car
{
    public string make;
    public string model;
    public string color;
    public int year;
    public void start()
    {
        Console.WriteLine("khoi dong xe");
    }
    public void stop()
    {
        Console.WriteLine("ket thuc khoi dong xe");
    }
    public void nhap()
    {
        Console.Write("nhap hang xe");
        make = Convert.ToString(Console.ReadLine());
        Console.Write("nhap dong co xe");
        model = Convert.ToString(Console.ReadLine());
        Console.Write("nhap  mau xe");
        color = Convert.ToString(Console.ReadLine());
        Console.Write("nhap nam san xuat xe");
        year = Convert.ToInt32(Console.ReadLine());
    }
    public void xuat()
    {
        Console.Write("thong tin chi tiet");
        Console.WriteLine("hang xe {0}",make);
        Console.WriteLine("dong co {0} ", model);
        Console.WriteLine("mau cua xe {0}", color);
        Console.WriteLine("nam san xuat {0}", year);
    }
} 
internal class Program
{
    static void Main(string[] args)
    {
        car xe = new car();
        xe.nhap();
        xe.xuat();
        xe.start();
        xe.stop();
        
    }
}