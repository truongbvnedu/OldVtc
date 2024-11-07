using System.Net.WebSockets;

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers;
        numbers = new int[10];
        Console.WriteLine("hay nhap phan tu cho mang numbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("numbers[{0}] = ",i );
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Clear();
        foreach (var m in numbers)
        {
            Console.Write(m );
            Console.Write(" ");
        }
        int min = numbers[0];
        int vtmin = 0;
        for (int i = 0;i < numbers.Length; i++)
        {
            if (min > numbers[i])
            {
                min = numbers[i];
                vtmin = i;
            }
        }
        Console.Write("\nso nho nhat trong mang la:{0} tai vi tri {1}", min, vtmin);
        bool doixung = true;
        for (int i = 0; i < numbers.Length / 2; i++)
        {
            if (numbers[i] != numbers[numbers.Length -1 - i])
            {
                doixung = false;
                break;
            }

        }
        if (doixung)
        {
            Console.WriteLine("\nham nay la phai ham doi xung");
        }
        else
        {
            Console.WriteLine("\nham nay khong phai ham doi xung");
        }
    }
}