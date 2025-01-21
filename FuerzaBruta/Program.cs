using CrackingPassword;

string[] contraseñas = {"~TIRED~","phpbb","zzzzzzzz1","zzzzzzdearbook","zzzz2727","zzz871101","zzy50138874","zzuyj0818",
    "zznode1234","zzj6559041","zzg19780911","zz7896321"};

Random random = new Random();
Encripter encripter = new Encripter();
string password = contraseñas[random.Next(contraseñas.Length - 1)];
string passworde = encripter.Encript(password);

Console.WriteLine(password+"  "+passworde);

foreach (var c in contraseñas)
{
    if (encripter.Encript(c)== passworde)
    {
        Console.WriteLine("Lancontre\n"+c);
        break;
    }
}