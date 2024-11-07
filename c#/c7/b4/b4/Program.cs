class vector
{
    public int x;
    public int y;
    public int z;
    public vector(int x, int y, int z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public static vector operator ++(vector a)
    {
        a.x++;
        a.y++;
        a.z++;
        return a;
    }
    public static vector operator --(vector a)
    {
        a.x--;
        a.y--;
        a.z--;
        return a;
    }
    public static vector operator +(vector a, vector b)
    {
        int x = a.x + b.x;
        int y = a.y + b.y;
        int z = a.z + b.z;
        return new vector(x, y, z);
    }
    public static vector operator -(vector a, vector b)
    {
        int x = a.x - b.x;
        int y = a.y - b.y;
        int z = a.z - b.z;
        return new vector(x, y, z);
    }
    public static vector operator *(vector a, vector b)
    {
        int x = a.x * b.x;
        int y = a.y * b.y;
        int z = a.z * b.z;
        return new vector(x, y, z);
    }
    public static vector operator /(vector a, vector b)
    {
        int x = a.x / b.x;
        int y = a.y / b.y;
        int z = a.z / b.z;
        return new vector(x, y, z);
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        vector a = new vector(5, 7, 9);
        vector b = new vector(4,5,3);
        Console.WriteLine("vecto a bao gom phan tu: ({0};{1};{2})", a.x, a.y, a.z);
        Console.WriteLine("vecto b bao gom phan tu: ({0};{1};{2})", b.x, b.y, b.z);
        vector tong = a + b;
        Console.WriteLine("tong hai vector la: ({0};{1};{2})",tong.x,tong.y,tong.z);
        vector hieu = a - b;
        Console.WriteLine("hieu hai vector la: ({0};{1};{2})", hieu.x, hieu.y, hieu.z);
        vector nhan = a * b;
        Console.WriteLine("tich hai vector la: ({0};{1};{2})", nhan.x, nhan.y, nhan.z);
        vector chia = a / b;
        Console.WriteLine("thuong hai vector la: ({0};{1};{2})", chia.x, chia.y, chia.z);
        a++;
        b--;
        Console.WriteLine("vecto a  sau khi tang len : ({0};{1};{2})", a.x, a.y, a.z);
        Console.WriteLine("vecto b sau khi giam xuong : ({0};{1};{2})", b.x, b.y, b.z);
    }
}