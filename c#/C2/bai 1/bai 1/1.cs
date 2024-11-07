internal class Program
{
    static void Main(string[] args)
    {
        int a, b, c, max, min;
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so c: ");
        c = Convert.ToInt32(Console.ReadLine());
        max = a;
        min = a;
        if (max < b)
        {
            max = b;
        }
        if (max < c) 
        {
             max = c;
        }
        if (min > b) 
        {
             min = b;
        }
        if (min > c)
        {
            min = c;
        }
        Console.WriteLine("so lon nhat trong 3 so :{0}", max);
        Console.WriteLine("so nho nhat trong 3 so :{0}", min);
    }
}