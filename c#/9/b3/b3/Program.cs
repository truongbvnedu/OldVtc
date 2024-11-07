internal class Program
{
    static void Main(string[] args)
    {
        string[] CAN, CHI;
        CAN = new string[10] { "Giap", "At", "Binh", "Dinh", "Mau", "Ky", "Canh", "Tan", "Nham", "Quy" };
        CHI = new string[12] { "Ti", "Suu", "Dan", "Mao", "Thin", "Ty", "Ngo", "Mui", "Than", "Dau", "Tuat", "Hoi" };
        int ns;
        Console.Write("hay nhap nam sinh: ");
        ns = Convert.ToInt32(Console.ReadLine());
        int cn, ch;
        cn = ns % 10;
        ch = ns % 12;
        Console.Write("\nnam sinh cua ban tuong duong voi :");
        for (int i = 0; i < CAN.Length; i++)
        {
            if (cn == i)
            {
                Console.Write(CAN[i]);
                Console.Write(" ");
            }
        }
        for (int i = 0; i < CHI.Length; i++)
        {
            if (ch == i) {
                Console.Write(CHI[i]); }
        }
    }
}