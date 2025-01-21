/*
String end = "";
Boolean ended = false;
Action finalizar;
finalizar = () => { Console.WriteLine("Alguien ha terminado"); };

Thread t1 = new Thread(writeY);
Thread t2 = new Thread(writeX);

t1.Start();
t2.Start();

while (end.Length==0)
{
}
Console.WriteLine();
ended = true;
Console.WriteLine($"Ha ganado {end}");

void writeY()
{
    writeText("Y");
}

void writeX()
{
    writeText("X");
}

void writeText(String t)
{
    for (int i = 0; i < 1000 && end.Length==0; i++)
    {
        Console.Write(t);
    }

    // if (end.Length==0) end = t;
    // while (!ended){}

    finalizar.Invoke();
    Console.WriteLine($"Ha terminado: {t}.");
}
*/