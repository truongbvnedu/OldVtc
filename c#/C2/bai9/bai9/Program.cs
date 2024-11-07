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
    static void ktdoixung(int ts)
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
        for (int i = 2; i < ts / 2; i++)
        {
            if (ts % i == 0)
            {
                dem++;
            }

        }
        if (dem >= 1)
        {
            Console.WriteLine("so nay la so nguyen to");
        }
        else
        {
            Console.WriteLine("so nay khong phai la so nguyen to");
        }
    }
    static void maxmin(int ts)
    {
        int i;
        int max = 0;
        int min = 0;

        while (ts != 0)
        {
            i = ts % 10;
            if (max < i)
            {
                max = i;
            }
            if (min > i)
            {
                min = i;
            }
            ts = ts / 10;
        }
        Console.WriteLine("chu so lon nhat la : {0}", max);
        Console.WriteLine("chu so nho nhat la: {0}", min);
    }
    static void tanggiam(int ts)
    {
        int xo = 0;
        int[] xx = new int[100]; 
        while (ts != 0)
        {
            int o = ts % 10;
            xx[xo] = o;
            xo++;
            ts /= 10;
        }
        for (int i = 0; i < xo - 1; i++)
        {
            for (int j = i + 1; j < xo; j++)
            {
                if (xx[i] < xx[j])
                {
                    int tam = xx[i];
                    xx[i] = xx[j];
                    xx[j] = tam;
                }
            }
        }
        Console.Write("xap xep giam dan la:");
        for (int i = 0; i < xo; i++)
        {
            Console.Write(" {0} ", xx[i]);
        }
        Console.WriteLine("xap xep tang dan la:");
        for (int i = xo; i > 0; i--)
        {
            Console.Write(" {0} ", xx[i]);
        }
    }
    static void Main(string[] args)
    {
        int n,t;
        Console.Write("hay nhap so n: ");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("1.kiem tra so doi xung\n2.kiem tra so chinh phuong\n3.kiem tra so nguyen to\n4.tim max va min\n5.kiem tra tang dan giam dan");
        Console.Write("\n hay chon thao tac:");
        t = Convert.ToInt32(Console.ReadLine());
        switch (t)
        {
            case 1: ktdoixung(n); break;
            case 2: ktsocp(n); break;
            case 3: ktsongto(n); break;
            case 4: maxmin(n); break;
            case 5: tanggiam(n); break;
           default: Console.WriteLine("loi he thong!"); break;
        }
    }
}