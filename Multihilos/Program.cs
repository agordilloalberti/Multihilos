using Multihilos;

// MyEvents.finalizar = () => { Console.WriteLine("Suscriptor A"); };
// MyEvents.finalizar += () => { Console.WriteLine("Suscriptor B"); };

FinishEvent finalEvent = new FinishEvent();
Wrapper<Action> finalEventv2 = new Wrapper<Action>(() => { });

HiloPerso t1 = new HiloPerso("x",finalEventv2);
HiloPerso t2 = new HiloPerso("y",finalEventv2);

// MyEvents.finalizar += () => { Console.WriteLine("Suscriptor C"); };

finalEvent.FinishAction += () => { Console.WriteLine("Suscriptor C"); };

t1.Start();
t2.Start();
