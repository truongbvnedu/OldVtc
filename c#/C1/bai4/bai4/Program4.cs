using System.Xml;

internal class Program
{
    static void Main(string[] ane)
    {
        double dt, dh, dl, hst, hsh, hsl, dtb;
        Console.Write("nhap diem toan:");
        dt = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap he so toan");
        hst = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem hoa:");
        dh = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap he so hoa");
        hsh = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem ly:");
        dl = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap he so ly ");
        hsl = Convert.ToDouble(Console.ReadLine());
        dtb =( (dt * hst ) + (dh * hsh ) + (dl * hsl) ) / (hst + hsh +hsl);
        Console.WriteLine("diem trung binh cua hoc sinh nay la : {0}", dtb);
    }
}