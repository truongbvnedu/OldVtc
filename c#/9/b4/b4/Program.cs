class emloyee
{
    public int Id;
    public string Name;
    public int yearofbirth;
    public double salarylevel;
    public double basicsalary;
    public void nhap()
    {
        Console.Write("nhap id nhan vien: ");
        Id = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap ten nhan vien: ");
        Name = Convert.ToString(Console.ReadLine());
        Console.Write("nam sinh nhan vien: ");
        yearofbirth = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap bat luong nhan vien: ");
        salarylevel = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap luong co ban cua nhan vien: ");
        basicsalary = Convert.ToDouble(Console.ReadLine());
    }
    public double getincome()
    {
        return salarylevel * basicsalary;
    }
    public void innhanvien()
    {
        Console.WriteLine("Id cua nhan vien la: {0}", Id);
        Console.WriteLine("ho va ten cua nhan vien la: {0}", Name);
        Console.WriteLine("luong nhan vien nhan duoc la:{0}", getincome());
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        emloyee nv1 = new emloyee();
        nv1.nhap();
        nv1.getincome();
        Console.Clear();
        nv1.innhanvien();
    }
}