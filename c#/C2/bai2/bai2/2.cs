internal class Program
{
    static void Main(string[] args)
    {
        int a, b;
        double x;
        Console.Write("nhap so a: ");
        a= Convert.ToInt32(Console.ReadLine());
        Console.Write("nhap so b: ");
        b= Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("phuong trinh {0}x + {1} = 0 co", a, b);
            if (a == 0)
            {
                if (b == 0)
                {


                    Console.WriteLine(" vo so nghiem");

                }
                else { Console.WriteLine(" vo ngiem"); }
                }
             else
                {
                x = -b / a;
                Console.WriteLine("ket qua la x = {0}", Math.Round(x, 2));
            }
        
        
    
    void  songto()
    {

    }
}