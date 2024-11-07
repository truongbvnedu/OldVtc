internal class Program
{
    static void uc(int a, int b,int c)
    {
        int ucab, ucac, ucbc,s;
         s = 0;
        ucab = 0;
        ucac = 0;
        ucbc = 0;
        while (b > 0)
        {
            ucab = a;
            a = b;
            b = ucab % a;
        }
        while (c > 0)
        {
            ucbc = b;
            b = c;
            c = ucbc % a;
        }
        while (c > 0)
        {
            ucac = a;
            a = c;
            c = ucac % a;
        }
        s = ucab + ucac + ucbc;
        Console.WriteLine("ket qua S={0}",s);
    }
    static void Main(string[] args)
    {
        int a, b, c;
        Console.Write("nhap so a: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so c: ");
        c = Convert.ToInt32(Console.ReadLine());
        uc(a, b, c);
        
    }
}