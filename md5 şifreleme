
//MD5 ŞİFRELEME
using System.Security.Cryptography;
public static string MD5(string _metin)
    {
        MD5CryptoServiceProvider pwd = new MD5CryptoServiceProvider();
        return encryption(_metin, pwd);
    }

private static string encryption(string _metin, HashAlgorithm _algoritma)
    {
        byte[] byteDegeri = System.Text.Encoding.UTF8.GetBytes(_metin);
        byte[] sifreliByte = _algoritma.ComputeHash(byteDegeri);
        return Convert.ToBase64String(sifreliByte);
    }
