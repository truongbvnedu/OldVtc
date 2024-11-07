using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class Program
{

    public static string EncryptText(string Data, byte[] Key, byte[] IV)
    {
        return Convert.ToBase64String(EncryptTextToMemory(Data, Key, IV));
    }
    public static byte[] EncryptTextToMemory(string Data, byte[] Key, byte[] IV)
    {
        try
        {
            MemoryStream mStream = new MemoryStream();
            CryptoStream cStream = new CryptoStream(mStream,
                           new DESCryptoServiceProvider().CreateEncryptor(Key, IV),
                           CryptoStreamMode.Write);
            byte[] toEncrypt = Encoding.UTF8.GetBytes(Data);
            cStream.Write(toEncrypt, 0, toEncrypt.Length);
            cStream.FlushFinalBlock();
            byte[] ret = mStream.ToArray();
            cStream.Close();
            mStream.Close();
            return ret;
        }
        catch (CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            return null;
        }
    }

public static string DecryptText(string sData, byte[] Key, byte[] IV)
    {
        byte[] Data = Convert.FromBase64String(sData);
        return DecryptTextFromMemory(Data, Key, IV);
    }
    public static string DecryptTextFromMemory(byte[] Data, byte[] Key, byte[] IV)
    {
        try
        {
            MemoryStream msDecrypt = new MemoryStream(Data);
            CryptoStream csDecrypt = new CryptoStream(msDecrypt,
                            new DESCryptoServiceProvider().CreateDecryptor(Key, IV),
                            CryptoStreamMode.Read);
            byte[] fromEncrypt = new byte[Data.Length];
            csDecrypt.Read(fromEncrypt, 0, fromEncrypt.Length);
            return Encoding.UTF8.GetString(fromEncrypt);
        }
        catch (CryptographicException e)
        {
            Console.WriteLine("A Cryptographic error occurred: {0}", e.Message);
            return null;
        }
    }
    
static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            DESCryptoServiceProvider DESalg = new DESCryptoServiceProvider();
            Console.Write("input a message: ");
            string sData = Console.ReadLine();
            string encrypted = EncryptText(sData, DESalg.Key, DESalg.IV);
            Console.WriteLine("encrypted message: " + encrypted);
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("decrypted message: " + DecryptText(encrypted, DESalg.Key, DESalg.IV));
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
    
