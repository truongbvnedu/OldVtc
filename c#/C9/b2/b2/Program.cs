internal class Program
{
    static void Main(string[] args)
    {
        int[,] numbers;
        numbers = new int[4,3];
        Console.WriteLine("nhap phan tu cho mang numbers");
        for (int i = 0; i< numbers.GetLength(0); i++)
        {
            
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                Console.Write("numbers[{0},{1}]: ",i,j);
                numbers[i,j] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n");
        }
        Console.Clear();
        Console.Write("{");
        Console.WriteLine("\n");
        for (int i =0; i< numbers.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j =0; j< numbers.GetLength(1); j++)
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
        Console.Write("nhung phan tu co hang va cot bang nhau gom: ");
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                if( i == j)
                {
                    Console.Write(numbers[i,j]);
                    Console.Write(' ');
                    
                }
            }
        }
        Console.ReadKey();
        Console.Clear();
        int min = numbers[0, 0];
        for (int i = 0; i < numbers.GetLength(1); i++)
        {
            for (int j = 0; j < numbers.GetLength(0); j++)
            {
                if (  min > numbers[i,j] )
                {
                    min = numbers[i,j];
                    break;
                }
            }
            Console.WriteLine("so nho nhat tren cot {0} la :{1}",i,min);
        }
    }
}