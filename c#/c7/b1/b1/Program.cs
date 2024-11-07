class account
{
    public double balance;

    public account(double initalize)
    {
        this.balance = initalize;
    }
    public virtual void deposit()
    {
        double money = 0;
        Console.Write("nhap so tien can gui (d): ");
        money = Convert.ToDouble(Console.ReadLine());
        balance = balance + money;
        Console.WriteLine("so du :{0} ", balance);
    }
    public virtual void draw()
    {
        double money = 0;
        Console.Write("nhap so tien can rut: ");
        money = Convert.ToDouble(Console.ReadLine());
        if (balance > money)
        {
            balance = balance - money;
        }
        else
        {
            Console.WriteLine("so tien trong tai khoan khong du");
        }
        Console.WriteLine("so du :{0}", balance);
    }
    public virtual void getbalance()
    {
        Console.WriteLine("so du: {0}", balance);
    }
}
class savingac : account
{
    public double rate;
    public double saving;
    public double moneysv;
    public savingac(double rate, double initalize, double saving) : base(initalize)
    {
        this.rate = rate;
        this.saving = saving;
    }
    public double getinterest()
    {
        return saving * rate;

    }
    public void inkq()
    {
        Console.WriteLine("so tien da duoc gui ve tai khoan:{0}", getinterest());
        Console.WriteLine("so du :{0}", balance + getinterest());
    }
    public void guitk()
    {
        Console.Write("nhap so tien gui tiet kiem: ");
        moneysv = Convert.ToDouble(Console.ReadLine());
        saving = saving + moneysv;
        Console.WriteLine("so tiet kiem: {0}", saving);

    }
}
class checkaccount : account
{
    public int feetransfer;
    public checkaccount(double initalize, int feetransfer) : base(initalize)
    {
        this.feetransfer = feetransfer;
    }
    public override void deposit()
    {
        double money = 0;
        Console.Write("nhap so tien can gui (d): ");
        money = Convert.ToDouble(Console.ReadLine());
        balance = balance + money;
        Console.WriteLine("so du :{0} ", balance);
    }
    public override void draw()
    {
        double money = 0;
        Console.Write("nhap so tien can rut: ");
        money = Convert.ToDouble(Console.ReadLine());
        if (balance > money)
        {
            balance = balance - money;

        }
        else
        {
            Console.WriteLine("so tien trong tai khoan khong du");
        }
        Console.WriteLine("so du :{0}", balance);
        Console.WriteLine("phi giao dich: {0}", feetransfer);
        balance = balance - feetransfer;
        Console.WriteLine("so du con lai: {0}", balance);
    }
}

internal class Program
{
    static bool createac()
    {
        int t;
        Console.Write("ban muon mo tai khoan:1 (co)|| 2(khong): ");
        t = Convert.ToInt32(Console.ReadLine());
        account tk1 = new account(0);
        if (t == 1)
        {

            tk1.getbalance();
            return true;
        }
        else if (t == 2)
        {

            return false;
        }
        else
        {

            return false;
        }

    }
    static void Main(string[] args)
    {

        account tk1 = new account(0);
        savingac tksv1 = new savingac(0.4, tk1.balance, 0);
        if (createac())
        {
            int t;

            do
            {
                Console.Write("1.gui tien\n2.rut tien\n3.truy van tai khoan\n4.gui tiet kiem\n5.rut tien lai\n0.out chuong trinh\nhay chon thao tac:");
                t = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (t)
                {

                    case 1: tk1.deposit(); break;
                    case 2: tk1.draw(); break;
                    case 3: tk1.getbalance(); break;
                    case 4: tksv1.guitk(); break;

                    case 5:
                        tksv1.getinterest();
                        tksv1.inkq(); break;
                    default: break;

                }

            } while (t != 0);
            Console.WriteLine("cam con quy khanh da su dung dich vu");
        }
        else
        {
            Console.WriteLine("cam con quy khanh da su dung dich vu");
        }
    }
}