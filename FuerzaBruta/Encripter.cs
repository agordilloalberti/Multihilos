using System.Security.Cryptography;
using System.Text;

namespace CrackingPassword;

public class Encripter
{
    public string Encript(string s)
    {
        using SHA256 sha256Hash = SHA256.Create();
        var bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(s));
        var builder = new StringBuilder();
        foreach (var b in bytes)
        {
            builder.Append(b.ToString("x2"));
        }
        return builder.ToString();
    }
}