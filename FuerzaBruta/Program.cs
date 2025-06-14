using System.Collections;
using CrackingPassword;

/**
 * Explicacion sobre el funcionamiento
 * Se ha probado0 con 4, 6, 8 10 hilos, el resultado mas veloz ha sido con 8 hilos.
 */

const string path = @"..\..\..\2151220-passwords.txt";

var contraseñas = File.ReadAllLines(path).ToList();

var random = new Random();
var encripter = new Encripter();
float Nhilos = 8;
List<HiloBruteForce> hilos = new List<HiloBruteForce>();

var password = contraseñas[random.Next(contraseñas.Count-1)];

var passwordEncripted = encripter.Encript(password);

Console.WriteLine(password+"  "+passwordEncripted);

int cantidadContraseñas =int.Parse(Math.Floor(contraseñas.Count()/Nhilos).ToString());

int inicio = 0;
int final = cantidadContraseñas;

for (int i = 0; i < Nhilos; i++)
{
    HiloBruteForce hilo = new HiloBruteForce();
    for (int j = inicio; j < final; j++)
    {
        hilo.contraseñas.Add(contraseñas[j]);
    }
    hilos.Add(hilo);
    inicio += cantidadContraseñas;
    final += cantidadContraseñas;
}

//TODO: Make sure that, in case there is a rest, they are added to other threads
// if (contraseñas.Count()-cantidadContraseñas*Nhilos!=0)
// {
//     contraseñas.
// }


foreach (var hilo in hilos)
{
    hilo.bruteForce(passwordEncripted, encripter);
}
