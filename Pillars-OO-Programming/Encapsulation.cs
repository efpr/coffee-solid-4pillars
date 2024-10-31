namespace Pillars_OO_Programming;

/// <summary>
/// Is the practice of hiding the internal details and only expose what is necessary
/// </summary>

public class CoffeMachine_E
{
    private int waterLevel;
    private int coffeeLevel;

    public CoffeMachine_E()
    {
        waterLevel = 0;
        coffeeLevel = 0;
    }

    public void AddWater(int water)
    {
        waterLevel += water;
    }

    public void AddCoffee(int coffe)
    {
        coffeeLevel += coffe;
    }

    public void Brew()
    {
        if (waterLevel <= 0 || coffeeLevel <= 0)
        {
            Console.WriteLine("Water and Coffee must be greater than 0");
            return;
        }
        
        Console.WriteLine("Brewing coffee...");
        waterLevel--;
        coffeeLevel--;
    }
}