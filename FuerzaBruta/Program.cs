using System.Collections;
using CrackingPassword;

const string path = @"..\..\..\2151220-passwords.txt";

var contraseñas = File.ReadAllLines(path).ToList();

var random = new Random();
var encripter = new Encripter();

var password = contraseñas[random.Next(contraseñas.Count-1)];

var passworde = encripter.Encript(password);

Console.WriteLine(password+"  "+passworde);

foreach (var c in contraseñas)
{
    if (encripter.Encript(c)== passworde)
    {
        Console.WriteLine("Lancontre\n"+c);
        break;
    }
}