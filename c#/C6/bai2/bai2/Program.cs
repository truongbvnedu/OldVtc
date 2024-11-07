using System.Xml.Linq;

class student
{
    public string name;
    public int year;
    public student(string name,int year) 
    {
        this.name = name;
        this.year = year;
    }
    public virtual double average()
    {
        return 0;
    }
    public void show()
    {
        
        Console.WriteLine("sinh vien: {0}", name);
        Console.WriteLine("nam sinh: {0}", year);

    }
}
class studentcollege : student
{
   
    protected double sc1;
    protected double sc2;
    protected double sc3;
    public studentcollege(string name, int year, double sc1, double sc2, double sc3) : base(name, year)
    {
        this.sc1 = sc1;
        this.sc2 = sc2;
        this.sc3 = sc3;

    }
public override double average()
    {
        return (sc1 + sc2 + sc3)/3;
    }
    public new void show()
    {
        base.show();
        Console.WriteLine("score 1 :{0}", sc1);
        Console.WriteLine("score 2 :{0}", sc2);
        Console.WriteLine("score 3 :{0}", sc3);
    }
}
class studenuny : studentcollege  
{
    protected double sc4;
    public studenuny(string name, int year, double sc1, double sc2, double sc3, double sc4) : base(name, year, sc1, sc2, sc3)
    {
        this.sc4 = sc4;
    }


    public override double average()
    {
        return (sc1 + sc2 + sc3 + sc4) / 4;
    }
    public new void show()
    {
        base.show();
        Console.WriteLine("score 4 :{0}", sc4);
    }
}

internal class Program()
{
    static void crstudent()
    {
        string name;
        int year;
        Console.Write("nhap ten sinh vien: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("nhap nam sinh: ");
        year = Convert.ToInt32(Console.ReadLine());
        student std = new student(name, year);
        Console.Clear();
        std.show();
    }
    static void crstudentcl()
    {
        string name;
        int year;
        double sc1, sc2, sc3;
        Console.Write("nhap ten sinh vien cao dang: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("nhap nam sinh: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap diem he so 1: ");
        sc1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem he so 2: ");
        sc2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem he so 3: ");
        sc3 = Convert.ToDouble(Console.ReadLine());
        studentcollege stdcl = new studentcollege(name, year, sc1, sc2, sc3);
        Console.Clear();
        stdcl.show();
    }
    static void crstudentu()
    {
        string name;
        int year;
        double sc1, sc2, sc3, sc4;
        Console.Write("nhap ten sinh vien dai hoc: ");
        name = Convert.ToString(Console.ReadLine());
        Console.Write("nhap nam sinh: ");
        year = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap diem he so 1: ");
        sc1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem he so 2: ");
        sc2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem he so 3: ");
        sc3 = Convert.ToDouble(Console.ReadLine());
        Console.Write("nhap diem he so 4: ");
        sc4 = Convert.ToDouble(Console.ReadLine());
        studenuny stdu = new studenuny(name, year, sc1, sc2, sc3, sc4);
        Console.Clear();
        stdu.show();
    }
    static void Main(string[] args)
    {
        int t;
        do
        {
            Console.Clear();
            Console.Write("1.tao sinh vien\n2.tao sinh vien cao dang\n3.tao sinh vien dai hoc\n0.out\n thao tac: ");
            t = Convert.ToInt32(Console.ReadLine());
            switch(t)
            {
                case 1: crstudent(); Console.ReadKey(); break;
                case 2: crstudentcl(); Console.ReadKey(); break;
                case 3: crstudentu(); Console.ReadKey(); break;
                default:break;
            }
        } while (t != 0);
    }   
}