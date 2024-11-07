internal class Program
{
    static bool songto(int kt)
    {
        if (kt < 2 && kt >= 0) return true;
        else if(kt <0) return false;
        else
        {
            for (int i = 2; i <= kt / 2; i++)
            {
                if (kt % i == 0)
                {
                    return false;
                    break;
                }
            }
        }
        return true;

    }
    static void Main(string[] args)
    {
        int[] numbers;
        numbers = new int[10];
        Console.WriteLine("hay nhap phan tu cho mang numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}] = ", i);
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        foreach (var m in numbers)
        {
            Console.Write(m);
            Console.Write(" ");
        }
        int min = numbers[0];
        int vtmin = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
                vtmin = i;
            }
        }
        Console.Write("\nso nho nhat trong mang la:{0} tai vi tri {1}", min, vtmin);
        Console.Write('\n');
        Console.WriteLine("\nmang sau khi dao nguoc la:");
        Array.Reverse(numbers);
        foreach (var m in numbers)
        {
            Console.Write(m);
            Console.Write(" ");
        }
        Array.Sort(numbers);
        Console.WriteLine("\nmang sau khi sap xep la la:");
        foreach (var m in numbers)
        {
            Console.Write(m);
            Console.Write(" ");
        }
        Console.Write("\ncac so nguyen to trong mang gon:");
        foreach(var m in numbers)
        {
            if (songto(m))
            {
                Console.Write(m);
                Console.Write(" ");
            }
        }
        int tong = 0;
        int ts = 0;
        foreach (var m in numbers)
        {
            if (m > 0)
            {
                tong = tong + m;
                ts++;
            }
        }
        tong = tong / ts;
        Console.WriteLine("\ntong trung binh cong cua cac so duong la:{0}", tong);
        int a = 0;
        int b = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] > 0)
            {
                a++;
            }
            else
            {
                if (a > b)
                {
                    b = a;
                    a = 0;
                }
                a = 0;
            }
        }
        if (a < b) { a = b; }
        Console.Write("so luong cac so duong lien tiep trong mang la:{0}", a);
        bool kt = true;
        for (int i = 0; i <= numbers.Length - 2; i++)
        {
            if (numbers[i] > 0 && numbers[i+1] > 0   ) 
            { kt = false; }
            else if (numbers[i] < 0 && numbers[i+1] < 0)
            {
                kt = false;
            }
            else
            {
                kt = true;
            }
        }
        if (kt)
        {
            Console.Write("\nmang co chua cac phan tu am duong dan xen");
        }
        else { Console.Write("\nmang khong co chua cac phan tu am duong dan xen"); }
    }
    
}