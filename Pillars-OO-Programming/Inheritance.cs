namespace Pillars_OO_Programming;

/// <summary>
/// Create a class that can be reusable, be extended or modified
/// </summary>


public class CoffeeMachine_I
{
    public virtual void Brew()
    {
        Console.WriteLine("Brew");
    }
}

public class NexpressoMachine_I : CoffeeMachine_I
{
    public override void Brew()
    {
        Console.WriteLine("Brew a nexpresso");
    }

    public void SteamMilk()
    {
        Console.WriteLine("Steam Milk");
    }
}