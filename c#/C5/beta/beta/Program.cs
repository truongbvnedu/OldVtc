using System.Text;

class student
{
    string id;
    string name;
    double markt;
    static int stt = 0;
    public string Id
    {
        get { return id; }
        set { id = value; }
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public double Markt
    {
        get { return markt; }
        set { markt = value; }
    }
    public student()
    {
        id = "";
        name = "";
        markt = 0.0;
        stt++;
    }
    public student(string id, string name)
    {
        this.id = id;
        this.name = name;
        this.markt = 0;
        stt++;
    }
    public student(string id, string name, double markt)
    {
        this.id = id;
        this.name = name;
        this.markt = markt;
        stt++;
    }
    public void display()
    {
        Console.WriteLine("ID: {0}", id);
        Console.WriteLine("NAME: {0}", name);
        Console.WriteLine("MARK: {0}", markt);

    }
    public static void count()
    {
        Console.WriteLine("count: {0}", stt);
    }
    ~student()
    {
        Console.WriteLine("doi tung bi huy");
        stt--;
        Console.WriteLine("Count: {0}", stt);
    }

    class NumberUtility
    {
        public static int Sum(int a)
        {
            int s = 0, i;
            for (i = 1; i <= a; i++)
                s = s + i;
            return s;
        }
        public static int Sum(int a, int b)
        {
            int s = 0, i;
            for (i = a; i <= b; i++)
                s = s + i;
            return s;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }
        public double Add(double a, double b)
        {
            return a + b;
        }
    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        student st1 = new student();
        st1.display();
        student st2 = new student("ID123", "Tran Dai", 7.5);
        st2.display();
        student st3 = new student("ID456", "Trung Tran");
        st3.display();
        student.count();
        Console.WriteLine("{0}", NumberUtility.Sum(4));
        Console.WriteLine("{0}", NumberUtility.Sum(2, 4));
        Console.ReadKey();
    }
}
