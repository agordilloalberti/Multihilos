namespace Multihilos;

public class FinishEvent
{
    public Action FinishAction;

    public FinishEvent()
    {
        FinishAction = () => { };
    }
}