internal class Program
{
    static void th1(int ts)
    {
        int s = 0;
        for (int i = 0; i <= ts; i++)
        {
            s = s + i;
        }
        Console.WriteLine("ket qua S={0}",s);
    }
    static void th2(int ts)
    {
        int s = 0;
        for(int i = 0;i <= ts; i++) { 
            s = s + (i*i);
        }
        Console.WriteLine("ket qua S={0}", s);
    }
    static void th3(int ts)
    {
        int s = 0;
        for( int i = 0;i <= ts;i++)
        {
            s = s + (1/i);
        }
        Console.WriteLine("ket qua S={0}", s);
    }
    static void th4(int ts)
    {
        int s = 1;
        for ( int i = 1;i <= ts; i++)
        {
            s = s * i;
        }
        Console.WriteLine("ket qua S={0}", s);
    }
    static void th5(int ts)
    {
       
        int s = 0;
        for (int i  = 1; i <= ts; i++)
        {
            int si = 1;
            for (int j = 1; j <= i; j++)
            {
                si = si * j;
            } 
           s = s + si;
        }
        Console.WriteLine("ket qua S={0}", s);
    }
    static void Main(string[] args)
    {
        int n,t;
        Console.Write("hay nhap mot so n:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("1.S = 1 + 2 + … + n\n2.S = 1^2 + 2^2 + … + n^2\n3.S = 1 + 1/2 + … + 1/n\n4.S = 1 * 2 * … * n\n5.S = 1! + 2! + … + n!");
        Console.Write("hay chon thao tac");
        t = Convert.ToInt32(Console.ReadLine());
        switch (t)
        {
            case 1: th1(n); break;
            case 2: th2(n); break;
            case 3: th3(n); break;
            case 4: th4(n); break;
            case 5: th5(n); break;
                default: Console.WriteLine("khong dung cu phap vui long nhap lai"); break;

        }
    }
}