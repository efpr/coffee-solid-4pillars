namespace SOLID_Principles;

/// <summary>
/// In this example ICoffeeMachine_LV only knows how to make hot coffee, so when ColdCoffeeMachine is created cannot
/// fulfill the expectations. In order to solve we should create separated interfaces or different base classes to
/// represent different types of brewing
/// </summary>

#region bad example

public interface ICoffeeMachine_LV
{
    void Brew();
}

public class HotCoffeeMachine_LV: ICoffeeMachine_LV
{
    public void Brew()
    {
        Console.WriteLine("Brew");
    }
}

public class ColdCoffeeMachine_LV : ICoffeeMachine_LV
{
    public void Brew()
    {
        throw new Exception("Only knows how to make cold coffee");
    }
}

#endregion

#region good example

public interface IHotBrew_LV
{
    void BrewHotCoffee();
}

public interface IColdBrew_LV
{
    void BrewColdCoffee();
}

public class DeltaQMachine_LV : IHotBrew_LV
{
    public void BrewHotCoffee()
    {
        Console.WriteLine("Brew hot coffee");
    }
}

public class NexpressoMachine_LV : IHotBrew_LV, IColdBrew_LV
{
    public void BrewHotCoffee()
    {
        Console.WriteLine("Brew hot coffee");
    }

    public void BrewColdCoffee()
    {
        Console.WriteLine("Brew cold coffee");
    }
}

#endregion