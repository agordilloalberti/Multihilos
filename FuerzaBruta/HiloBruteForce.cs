namespace CrackingPassword;

public class HiloBruteForce
{
    Thread Hilo;
    public List<String> contraseñas = new List<string>();
    
    public void esperar()
    {
        Hilo.Join();
    }

    public String bruteForce(String password, Encripter encripter)
    {
        
    }
}