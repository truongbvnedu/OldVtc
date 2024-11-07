using System.Runtime.Serialization;

internal class Program
{
    static int sodoixung(int ts)
    {
        int doixung = 0, vedao = 0;
        while (ts > 0)
        {
            vedao = ts % 10;
            doixung = doixung * 10 + vedao;
            ts = ts / 10;
        }
        return doixung;
    }
    static  void ktdoixung(int ts)
    {
        if (sodoixung(ts) == ts)
        {
            Console.WriteLine("so nay la mot so doi xung!");
        }
        else
        {
            Console.WriteLine("so nay khong phai la so doi xung!");
        }
    }
    static void ktsocp(int ts)
    {
        double cants;
        cants = Math.Sqrt(ts);
        if (cants * cants == ts)
        {
            Console.WriteLine("so nay la so chinh phuong");
        }
        else
        {
            Console.WriteLine("so nay khong phai la so chinh phuong");
        }

    }
    static void ktsongto(int ts)
    {
        int dem = 0;
        for (int i = 2;i< ts/2;i++)
        {
            if (ts % i ==0)
            {
                dem++;
            }
        }
        if (dem >=1)
        {
            Console.WriteLine("so nay la so nguyen to");
        }
        else
        {
            Console.WriteLine("so nay khong phai la so nguyen to");
        }
    }
    static void tongsole(int ts)
    {
        int s = 0,kt=0;
        while(ts > 0)
        {
            kt = ts % 10;
            if (kt % 2 !=0)
            {
                s = s + kt;
            }
            ts = ts / 10;
        }
        Console.WriteLine("tong cac chu so le S={0}",s);
    }
    static void tongsonto(int ts)
    {
        int s = 0, dem = 0,kt =0;
        while (ts > 0 )
        {
            kt = ts % 10;
            for (int i = 2; i < kt; i++)
            {
                if (kt % i == 0) 
                {
                    dem++;
                }
            }
            if (dem >=1)
            {
                s = s + kt;
            }
            ts /= 10;
        }
        Console.WriteLine("ket qua la S={0}", s);
    }
    static void tongsocp(int ts)
    {
        int kt, s=0;
        double cants;
        while(ts > 0)
        {
            kt = ts % 10;
            cants = Math.Sqrt(kt);
            if (cants * cants == kt)
            {
                s = s + kt;
            }
            ts /= 10;
        }
        Console.WriteLine("ket qua bang S={0}",s);
        
    }
    static void Main(string[] args)
    {
        int n, t;
        Console.Write("hay nhap so n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("1.kt so doi xung\n2.kt so chinh phuong\n3.kt so nguyen to\n4.tong so le\n5.tong cac so nguyen to\n6.tong so chinh phuong");
        Console.Write("hay chon thao tac:");
        t = Convert.ToInt32(Console.ReadLine());
        switch(t) 
        {
            case 1: ktdoixung(n); break;
            case 2:ktsocp(n); break;
            case 3:ktsongto(n); break;
            case 4:tongsole(n); break;
            case 5:tongsonto(n); break;
            case 6:tongsocp(n); break;
            default: Console.WriteLine("cu phap sai vui long nhap lai"); break;
        }
    }
}