namespace Multihilos;

public class HiloPerso
{
    Thread hilo;
    private string text;
    private FinishEvent finalizar;
    
    public HiloPerso(string text, Wrapper<Action> finalizar)
    {
        this.text = text;
        this.finalizar = finalizar.Value;
        finalizar.FinishAction += () => { Console.WriteLine($"Hilo {text}"); };
        hilo = new Thread(_process);
    }

    public void Start()
    {
        hilo.Start();
    }

    void _process()
    {
        for (int i = 0; i < 1000; i++) Console.Write (text);
        finalizar.FinishAction.Invoke();
        Console.WriteLine($"Ha terminado: {text}");
    }
}