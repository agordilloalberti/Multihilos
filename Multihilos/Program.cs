using System.Collections;

namespace Multihilos;
internal class Program { public static void Main(string[] args)
    {
        List<HiloPPT> jugadores = new List<HiloPPT>();

        for (int i = 1; i <= 16; i++)
        {
            jugadores.Add(new HiloPPT($"jugador {i}"));
        }

        while (jugadores.Count!=1)
        {

            List<HiloPPT> duelo = new List<HiloPPT>();
            List<HiloPPT> perdedores = new List<HiloPPT>();
            foreach (HiloPPT j in jugadores)
            {
                duelo.Add(j);
                if (duelo.Count==2)
                {
                    perdedores.Add(partida(duelo[0], duelo[1]));
                    duelo.Clear();
                }
            }

            Console.WriteLine();
            foreach (HiloPPT p in perdedores)
            {
                Console.WriteLine($"Jugador \"{p.Nombre}\" eliminado");
                jugadores.Remove(p);
            }
            Console.WriteLine();
        }
        
        Console.WriteLine($"El ganador de este torneo es: {jugadores[0].Nombre}");
        
        
        
        HiloPPT partida(HiloPPT p1, HiloPPT p2)
        {
            while (p1.puntos < 2 && p2.puntos < 2)
            {
                p1.juega();
                p2.juega();
                
                p1.esperar();
                p2.esperar();
                
                if (p1.resultado == p2.resultado) continue;
                if (p1.resultado == "tijeras")
                {
                    if (p2.resultado == "piedra")
                    {
                        p2.puntos++;
                    }
                    else
                    {
                        p1.puntos++;
                    }
                }

                if (p1.resultado == "piedra")
                {
                    if (p2.resultado == "papel")
                    {
                        p2.puntos++;
                    }
                    else
                    {
                        p1.puntos++;
                    }
                }

                if (p1.resultado == "papel")
                {
                    if (p2.resultado == "tijeras")
                    {
                        p2.puntos++;
                    }
                    else
                    {
                        p1.puntos++;
                    }
                }
            }
            
            Console.WriteLine($"\"{p1.Nombre}\" {p1.puntos} puntos |---| \"{p2.Nombre}\" {p2.puntos} puntos");
            return p1.puntos>p2.puntos ? p1 : p2;
        }
    }
}