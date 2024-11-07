class transportation
{
    public string move() { return"di chuyen tren duong"; }
    public string breaktrsp() { return "phuong tien bi hu roi"; }

}
class plane : transportation
{
    public new void move() { 
        base.move();
        Console.WriteLine("bay"); 
    }
    public new void breaktrsp() { Console.WriteLine("no may bay");}
}
internal class Program
{
    static void Main(string[] args)
    {
        plane pl = new plane();
        pl.move();
        pl.breaktrsp();
    }
}