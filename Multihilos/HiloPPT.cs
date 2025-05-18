namespace Multihilos;

public class HiloPPT
{
    Random random = new();
    public string Nombre;
    Thread hilo;
    public string resultado="SN";
    public int puntos=0;

    public HiloPPT(string nombre)
    {
        this.Nombre = nombre;
    }

    public void esperar()
    {
        hilo.Join();
    }
    
    public void juega()
    {
        hilo = new Thread(tirada);
        hilo.Start();
    }

    private void tirada()
    {
        List<string> tiradas = new List<string>() { "piedra", "papel", "tijeras" };
        resultado = tiradas[random.Next(2)];
    }
}