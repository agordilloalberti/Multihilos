namespace CrackingPassword;

public class HiloBruteForce
{
    public static bool finished;
    Thread Hilo;
    public List<String> contraseñas = new();
    private String password;
    private Encripter encripter;
    
    public void esperar()
    {
        Hilo.Join();
    }

    public void bruteForce(String password, Encripter encripter)
    {
        this.password = password;
        this.encripter = encripter;
        Hilo = new Thread(search);
        Hilo.Start();
        esperar();
    }

    private void search()
    {
    
        foreach (var pass in contraseñas)
        {
            if (encripter.Encript(pass) == password)
            {
                encontrada(pass);
            }else if (finished)
            {
                return;
            }
        }
    }

    public void encontrada(String s)
    {
        finished = true;
        Console.WriteLine($"Found it: {s}");
    }
    
}