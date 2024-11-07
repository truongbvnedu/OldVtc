class sinhvien
{
    public double diemtoan;
    public double diemly;
    public double diemhoa;
    public string hovaten;
    public string gioitinh;
    public int ngaysinh;
    public int thangsing;
    public int namsinh;
    public void nhap()
    {
        Console.Write("nhap ho va ten hoc sinh: ");
        hovaten = Convert.ToString(Console.ReadLine());
        Console.Write("nhap gioi tinh hoc sinh (nam/nu): ");
        gioitinh = Convert.ToString(Console.ReadLine());
        Console.Write("nhap ngay sinh: ");
        ngaysinh = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap thang sinh: ");
        thangsing = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap nam sinh: ");
        namsinh = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap diem toan: ");
        diemtoan = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem ly: ");
        diemly = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem hoa: ");
        diemhoa = Convert.ToDouble(Console.ReadLine());
    }
    public double dtb() 
    {
        return (diemtoan * 2 + diemly + diemhoa) / 4;
    }
    public void inkq()
    {
        Console.WriteLine("ho va ten sinh vien la:{0}",hovaten);
        Console.WriteLine("ngay sinh: {0}/{1}/{2}",ngaysinh,thangsing,namsinh);
        Console.WriteLine("diem trung binh:{0}",Math.Round(dtb(),2));
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        sinhvien sv1 = new sinhvien();
        sv1.nhap();
        sv1.dtb();
        System.Console.Clear();
        sv1.inkq();
    }
}