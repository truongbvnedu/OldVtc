using System.Security.Cryptography;

internal class Proram
{
    static void Main(string[] args)
    {
        var csp = new RSACryptoServiceProvider(2048);
        var privKey = csp.ExportParameters(true);
        var pubKey = csp.ExportParameters(false);
        string pubKeyString; 
        {
            var sw = new System.IO.StringWriter();
            var xs =  new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, privKey);
            pubKeyString = sw.ToString();
        }
        {
            var sr = new System.IO.StringReader(pubKeyString);
            var xs =  new System.Xml.Serialization.XmlSerializer(typeof(RSAParameters));
            pubKey = (RSAParameters)xs.Deserialize(sr);
        }
        csp = new RSACryptoServiceProvider();
        csp.ImportParameters(pubKey);
        Console.Write("input a message: ");
        var plaintextdata = Console.ReadLine();
        var bytesplaintextdata = System.Text.Encoding.Unicode.GetBytes(plaintextdata);
        var bytescyphertext = csp.Encrypt(bytesplaintextdata, false);
        var cyphertext = Convert.ToBase64String(bytescyphertext);
        Console.WriteLine("encrypted message: " + cyphertext);
        bytescyphertext = Convert.FromBase64String(cyphertext);
        csp = new RSACryptoServiceProvider();
        csp.ImportParameters(privKey);
        bytesplaintextdata = csp.Decrypt(bytescyphertext, false);
        plaintextdata = System.Text.Encoding.Unicode.GetString(bytesplaintextdata);
        Console.WriteLine("decrypted message: " + plaintextdata);

    }
}