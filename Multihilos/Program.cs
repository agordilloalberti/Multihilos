public class main()
{
    public static void Main(string[] args)
    {
        Thread player1 = new Thread();
        player1.Start();
        Thread player2 = new Thread();
        player2.Start();
    }

    private static String playRPS()
    {
        var random = new Random();
        var r = random.Next(1,4);
        return r switch
        {
            1 => "Piedra",
            2 => "Papel",
            _ => "Tijera"
        };
    }
}