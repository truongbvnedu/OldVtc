internal class Program
{
    static void Main(string[] args)
    {
        int[,] numbers;
        numbers = new int[4, 4];
        Console.WriteLine("nhap phan tu cho mang numbers");
        for (int i = 0; i < numbers.GetLength(1); i++)
        {

            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                Console.Write("numbers[{0},{1}]: ", i, j);
                numbers[i, j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }
        Console.Clear();
        Console.Write("{");
        Console.WriteLine("\n");
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            Console.Write("{");
            for (int j = 0; j < numbers.GetLength(0); j++)
            {

                Console.Write(numbers[i, j]);
                Console.Write(" , ");
            }
            Console.Write("}");
            Console.WriteLine("\n");

        }
        Console.Write("}");
        Console.ReadKey();
        Console.Clear();
        int tong = 0;
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if (i == j)
                {
                    tong = tong + numbers[i, j];

                }
            }
        }
        Console.Write("tong nhung phan tu co hang va cot bang nhau la:{0} ",tong);
        Console.ReadKey();
        Console.Clear();
        Console.Write("so chia het cho 7 trong mang gom: ");
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0;j < numbers.GetLength(1); j++)
            {
                if (numbers[i,j] % 7 == 0)
                {
                    Console.Write(numbers[i,j]);
                    Console.Write(", ");
                }
            }
        }
        int tongs = 0;
        for(int i = 0;i < numbers.GetLength(0); i ++ )
        {
            if(i == 0 || i == numbers.GetLength(0)-1)
            {
                for(int j = 0;j  < numbers.GetLength(1); j++)
                {
                    tongs = numbers[i, j] + tongs;                   
                }
            }
        }
        for (int i = 1; i <= numbers.GetLength(1)/2; i++)
        {
                for (int j = 0; j < numbers.GetLength(0);j++)
                {
                    if(j ==0|| j == numbers.GetLength(0) - 1)
                {
                    tongs = numbers[i, j] + tongs;
                }
                     
                }
        }
        Console.Write("\ntong cac so benh vien cua mang la: {0}", tongs);
        int[] number = numbers.Cast<int>().ToArray();
        Array.Sort(number);
        Console.Write("\nmang mot chieu sau khi chuyen doi la:");
        foreach (int i in number)
        {
            Console.Write(i);
            Console.Write(" ");
        }
       
    }
}