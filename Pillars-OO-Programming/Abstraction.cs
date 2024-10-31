namespace Pillars_OO_Programming;

/// <summary>
/// Hide details of the complex implementation and only expose the details necessary or relevant
/// </summary>

public class CoffeMachine_A
{

    private void GrindCoffee()
    {
        Console.WriteLine("Grinding Coffee");
    }

    private void HeatWater()
    {
        Console.WriteLine("Heating Water");
    }

    public void BrewCoffee()
    {
        HeatWater();
        GrindCoffee();
        Console.WriteLine("Brewing Coffee");
    }
}