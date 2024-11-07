using System.Text;

internal class Program
{
    static void Main(string[] args)
    {
        Console.Write("input a message: ");
        string pass = Console.ReadLine();
        string md5string = CreateMD5(pass);
        Console.WriteLine("password encrypted: {0}", md5string);
    }
    public static string CreateMD5(string input)
    {
        using (var provider = System.Security.Cryptography.MD5.Create())
        {
            StringBuilder builder = new StringBuilder();
            foreach (byte b in provider.ComputeHash(Encoding.UTF8.GetBytes(input)))
                builder.Append(b.ToString("x2").ToLower());
            return builder.ToString();
        }
    }
}