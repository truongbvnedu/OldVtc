using System.Security.Cryptography;
using System.Text;

class Program
{
    public static class GlobalKey
    {
        public const String STRING_PERMUTATION = "sinhnx.dev";
        public const Int32 BYTE_PERMUTATION_1 = 0x19;
        public const Int32 BYTE_PERMUTATION_2 = 0x59;
        public const Int32 BYTE_PERMUTATION_3 = 0x17;
        public const Int32 BYTE_PERMUTATION_4 = 0x41;
    }
    public static void Main(String[] args)
    {
   
        Console.Write("input a message: ");
        string msg = Console.ReadLine();

        string strEncrypted = (Encrypt(msg));
        Console.WriteLine("encrypted message: " + strEncrypted);

        string strDecrypted = (Decrypt(strEncrypted));
        Console.WriteLine("decrypted message: " + strDecrypted);
    }
    public static string Encrypt(string strData)
    {
        return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));
    }
    public static string Decrypt(string strData)
    {
        return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(strData)));
    }
    public static byte[] Encrypt(byte[] strData)
    {
        PasswordDeriveBytes passbytes =
        new PasswordDeriveBytes(GlobalKey.STRING_PERMUTATION,
        new byte[] { 
            GlobalKey.BYTE_PERMUTATION_1,
            GlobalKey.BYTE_PERMUTATION_2,
            GlobalKey.BYTE_PERMUTATION_3,
            GlobalKey.BYTE_PERMUTATION_4
        });

        MemoryStream memstream = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = passbytes.GetBytes(aes.KeySize / 8);
        aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

        CryptoStream cryptostream = new CryptoStream(memstream,
        aes.CreateEncryptor(), CryptoStreamMode.Write);
        cryptostream.Write(strData, 0, strData.Length);
        cryptostream.Close();
        return memstream.ToArray();
    }
    public static byte[] Decrypt(byte[] strData)
    {
        PasswordDeriveBytes passbytes =
        new PasswordDeriveBytes(GlobalKey.STRING_PERMUTATION,
        new byte[] { 
            GlobalKey.BYTE_PERMUTATION_1,
            GlobalKey.BYTE_PERMUTATION_2,
            GlobalKey.BYTE_PERMUTATION_3,
            GlobalKey.BYTE_PERMUTATION_4
        });

        MemoryStream memstream = new MemoryStream();
        Aes aes = new AesManaged();
        aes.Key = passbytes.GetBytes(aes.KeySize / 8);
        aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

        CryptoStream cryptostream = new CryptoStream(memstream,
        aes.CreateDecryptor(), CryptoStreamMode.Write);
        cryptostream.Write(strData, 0, strData.Length);
        cryptostream.Close();
        return memstream.ToArray();
    }
}