using System.Collections;

class Book
{
    public int id;
    public string tittle;
    public string author;
    public string publisher;
    public int year;
    public decimal price;
   public Book(int id, string tittle, string author, string publisher, int year, decimal price)
    {
        this.id = id;
        this.tittle = tittle;
        this.author = author;
        this.publisher = publisher;
        this.year = year;
        this.price = price;
    }
}
internal class Program
{
    static void Main(string[] args)
    {

        List<Book> sach = new List<Book>();
        sach.Add(new Book(1, "doraemon", "Fujiko F. Fujio", "Matsushiba", 1973, 50000));
        sach.Add(new Book(2, "dat rung phuong nam", "Doan Gioi", "nhi dong", 2021, 91000));
        sach.Add(new Book(3, "conan", "Aoyama Gosho", "Shogakukan", 1994, 50000));
        sach.Add(new Book(4, "Crayon Shin-chan", "Usui Yoshito", "Futabasha", 2001, 50000));
        sach.Add(new Book(5, "kinh van hoa", "Nguyen Nhat Anh", "nhi dong", 1995, 80000));
        sach.Add(new Book(6, "thien su nha benh", "Saekisan", "SB Creative", 2019, 70000));
        sach.Add(new Book(7, "nha gia kim", "Paulo Coelho", "Editora Rocco Ltda", 1988, 100000));
        sach.Add(new Book(8, "muoi", "Ton Tan", "thanh nien", 1995, 150000));

        foreach (var book in sach)
        {
            Console.WriteLine("id:{0}-name:{1}-anthor:{2}-publisher:{3}-year:{4}-price:{5}", book.id, book.tittle, book.author, book.publisher, book.year, book.price);
        }
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("sau khi xap sep gia tang dan la");
        sach.Sort((sach1, sach2) => sach1.price.CompareTo(sach2.price));

        foreach (var book in sach)
        {
            Console.WriteLine("id:{0}-name:{1}-anthor:{2}-publisher:{3}-year:{4}-price:{5}", book.id, book.tittle, book.author, book.publisher, book.year, book.price);
        }
        Console.ReadKey();
        Console.Clear();
        Console.Write("nhap title sach de tim: ");
        string ser;
        ser = Console.ReadLine();
        Book timkiem = sach.Find(Book => Book.tittle == ser);
        if (timkiem != null)
        {
            Console.WriteLine("sach ban can tim la:");
            Console.WriteLine("id:{0}-name:{1}-anthor:{2}", timkiem.id, timkiem.tittle, timkiem.author);
        }

        else { Console.WriteLine("title ban kim ko co trong danh sach");
        }
        Book namsp = sach.Find(Book => Book.year == 2014);
        if (namsp != null)
        {
            Console.WriteLine("sach co nam xuat ban 2014 la:");
            Console.WriteLine("id={0}/name={1}", namsp.id, namsp.tittle);
        }
        else {Console.WriteLine("khong co sach xuat ban vao nam 2014"); }
        sach.RemoveAll(Book => Book.publisher == "nhi dong");
        Console.ReadKey();
        Console.Clear();
        Console.Write("sau khi xoa nha xuat ban nhi dong: ");

        foreach (var book in sach)
        {
            Console.WriteLine("id:{0}-name:{1}-anthor:{2}-publisher:{3}-year:{4}-price:{5}", book.id, book.tittle, book.author, book.publisher, book.year, book.price);
        }

    }
}

