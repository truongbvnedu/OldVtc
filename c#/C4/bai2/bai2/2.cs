class person
{
    public string hoten;
    public double cangnang;
    public string gioitinh;
    public int tuoi;
    public double chieucao;
    public void nhap()
    {
        Console.Write("nhap ho va ten:");
        hoten = Convert.ToString(Console.ReadLine());
        Console.Write("nhap so cang nang(kg):");
        cangnang = Convert.ToDouble(Console.ReadLine()); 
        Console.Write("nhap nam sinh:");
        tuoi = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap chieu cao(cm):");
        chieucao = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap gioi tinh (nam/nu):");
        gioitinh = Convert.ToString(Console.ReadLine());
    }
    public int tinhtuoi()
    {
        return 2024 - tuoi;
    }
    public void inkq()
    {
        Console.WriteLine("ho va ten :{0}", hoten);
        Console.WriteLine("cao :{0} cm", chieucao);
        Console.WriteLine("cang nang:{0} kg",cangnang);
        Console.WriteLine("{0} tuoi", tinhtuoi());
        Console.WriteLine("gioi tinh:{0}", gioitinh);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        person ps= new person();
        ps.nhap();
        ps.tinhtuoi();
        ps.inkq();
    }
}