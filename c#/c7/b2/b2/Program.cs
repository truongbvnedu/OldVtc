public abstract class nhanvien
{
    public string hvt;
    public string address;
    public nhanvien(string hvt, string address)
    {
        this.hvt = hvt;
        this.address = address;
    }

    public void ten()
    {
        Console.WriteLine("ten cua nhan vien la: {0}",hvt);
    }
    public void diachi()
    {
        Console.WriteLine("dia chi o: {0}", address);
    }
    public abstract double tinhluong();
    public abstract void hienthi();
}
class nhanvienbanhang: nhanvien
{
    public int soluong;
    public nhanvienbanhang(string hvt, string address,int soluong) : base(hvt, address) 
    {
        this.soluong = soluong;
    }
    public override double tinhluong() 
    {

        return soluong * 100000;
    }
    public override void hienthi()
    {
        Console.WriteLine("ten cua nhan vien la: {0}", hvt);
        Console.WriteLine("dia chi o: {0}", address);
        Console.WriteLine("tien luong nhan duoc la:{0}", Math.Round(tinhluong(), 2));

    }

}
class congnhan : nhanvien
{
    int soluong;
    public congnhan(int soluong, string hvt, string address) : base(hvt, address)
    {
        this.soluong = soluong;
    }
    public override double tinhluong()
    {
        return soluong * 80000;
    }
    public override void hienthi()
    {
        Console.WriteLine("ten cua nhan vien la: {0}", hvt);
        Console.WriteLine("dia chi o: {0}", address);
        Console.WriteLine("tien luong nhan duoc la:{0}", Math.Round(tinhluong(), 2));

    }
}
internal class Program
{
    static void Main(string[] args)
    {
        nhanvienbanhang banhang = new nhanvienbanhang("nguyen van a","TP. Ho Chi Minh",1000);
        banhang.hienthi();
        congnhan cn = new congnhan(100, "le van loi", "Ha Noi");
        cn.hienthi();
    }
}