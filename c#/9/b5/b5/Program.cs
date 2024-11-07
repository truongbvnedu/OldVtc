class book
{
    public string author;
    public int pages;
    public string isbn;
    public string title;
    public int currentpgs;
    public void nhapinfo()
    {
        Console.Write("nhap ten cua cuon sach: ");
        title = Convert.ToString(Console.ReadLine());
        Console.Write("nhap tac gia cua cuon sach: ");
        author = Convert.ToString(Console.ReadLine());
        Console.Write("nhap tong so trang cua cuon sach: ");
        pages = Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap ma so quoc te cua cuon sach: ");
        isbn = Convert.ToString(Console.ReadLine());
        Console.Write("hien tai da doc den trang so: ");
        currentpgs = Convert.ToInt32(Console.ReadLine());
    }
    public void ininfo()
    {
        Console.WriteLine("{0}", title);
        Console.WriteLine("tac gia: {0}", author);
        Console.WriteLine("tong so trang: {0}", pages);
        Console.WriteLine("ma so quoc te: {0}", isbn);
        Console.WriteLine("so trang hien da doc: {0}", currentpgs);

    }
    public void next()
    {
        if (currentpgs < pages)
        {
            currentpgs++;
            ininfo();
        }
        else
        {
            Console.WriteLine("ban da doc xong cuon sach nay ");
        }
    }
    public void back()
    {
        if (currentpgs > 0)
        {
            currentpgs--;
            ininfo();
        }
        else
        {
            Console.WriteLine("ban dang o trang dau tien cua cuon sach");
        }
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        int t;
        book sach1 = new book();
        sach1.nhapinfo();
        sach1.ininfo();

        do
        {
            Console.Clear();
            Console.Write("1. next page\n2. previous page\n0. out\n ban muon lan gi: ");
            t = Convert.ToInt32(Console.ReadLine());
            switch (t)
            {
                case 1: sach1.next(); break;
                case 2: sach1.back(); break;
                default: Console.WriteLine("loi!"); break;
            }
            Console.ReadKey();
        } while (t != 0);

    }

}