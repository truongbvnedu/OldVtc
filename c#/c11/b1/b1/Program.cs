class General<t>
{
    t[] mang;
    public int dem = 0;
    public General(int n) 
    {
        mang = new t[n];
        dem = 0;
    }
    public int add(t n)
    {
        if (dem < mang.Length) 
        {
            mang[dem] = n;
        }
        return dem++;
    }
    public void show()
    {
        foreach (var bien in mang)
        {
            Console.Write(bien);
            Console.Write(" ");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        General<int> beta = new General<int>(10);
        beta.add(10);
        beta.add(1);
        beta.add(20);
        beta.add(90);
        beta.show();
    }
}