using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for Encryption_Data
/// </summary>
public class Encryption_Data
{
    public Encryption_Data()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    static byte[] bytes = ASCIIEncoding.ASCII.GetBytes("shailesh");
    public static string Encrypt(string originalString,byte[] RGBKey, byte[] RGBKey2)
    {
        if (String.IsNullOrEmpty(originalString))
        {
            throw new ArgumentNullException
                   ("The string which needs to be encrypted can not be null.");
        }
        DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
        MemoryStream memoryStream = new MemoryStream();
        CryptoStream cryptoStream = new CryptoStream(memoryStream,
            cryptoProvider.CreateEncryptor(RGBKey, RGBKey), CryptoStreamMode.Write);
        StreamWriter writer = new StreamWriter(cryptoStream);
        writer.Write(originalString);
        writer.Flush();
        cryptoStream.FlushFinalBlock();
        writer.Flush();
        return Convert.ToBase64String(memoryStream.GetBuffer(), 0, (int)memoryStream.Length);
    }
    public static string Decrypt(string cryptedString, byte[] RGBKey, byte[] RGBKey2)
    {
        if (String.IsNullOrEmpty(cryptedString))
        {
            throw new ArgumentNullException
               ("The string which needs to be decrypted can not be null.");
        }
        DESCryptoServiceProvider cryptoProvider = new DESCryptoServiceProvider();
        MemoryStream memoryStream = new MemoryStream
                (Convert.FromBase64String(cryptedString));
        CryptoStream cryptoStream = new CryptoStream(memoryStream,
            cryptoProvider.CreateDecryptor(RGBKey, RGBKey2), CryptoStreamMode.Read);
        StreamReader reader = new StreamReader(cryptoStream);
        return reader.ReadToEnd();
    }
}