namespace SOLID_Principles;

/// <summary>
/// DeltaQMachine_IS shouldn't be force to implement methods to clean or add milk that will not be use. To fixe that we
/// should separate the interface. 
/// </summary>

#region bad example

public interface ICoffeeMachine_IS
{
    void Brew();
    void Clean();
    void AddMilk();
}

public class DeltaQMachine_IS : ICoffeeMachine_IS
{
    public void Brew()
    {
        Console.WriteLine("Brew");
    }

    public void Clean()
    {
        Console.WriteLine("Clean");
    }

    public void AddMilk()
    {
        Console.WriteLine("Add Milk");
    }
}

#endregion

#region good example

public interface IBrewingMachine_IS
{
    void Brew();
}

public interface ICleaningMachine_IS
{
    void Clean();
}

public interface IMilkingMachine_IS
{
    void AddMilk();
}

public class NexpressonMachine_IS : IBrewingMachine_IS, IMilkingMachine_IS
{
    public void Brew()
    {
        Console.WriteLine("Brew");
    }

    public void AddMilk()
    {
        Console.WriteLine("Milk");
    }
}

#endregion