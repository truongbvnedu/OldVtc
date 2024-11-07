internal class Program
{
    static void Main(string[] args)
    {
        int a, b, c;
        Console.Write("nhap canh a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap canh b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap canh c: ");
        c = Convert.ToInt32(Console.ReadLine());
        if (a +b >c || a+ c > b || c+ b > a)
        {
            if (a == b && a ==c)
            {
                Console.WriteLine("tam gia nay la tam giac deu");
            }
            else if (a == b || a==c || b ==c)
            {
                Console.WriteLine("tam giac nay la tam giac can");
            }
            else if (a*a == b*b + c*c || b*b == a*a + c*c || c*c == a*a + b*b)
            {
                Console.WriteLine("tam giac nay la tam giac vuong");
            }
        }
        else
        {
            Console.WriteLine("ba canh nay khong tao nen tam giac");
        }
    }
}