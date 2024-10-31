namespace SOLID_Principles;

/// <summary>
/// Classes should be close to modifications and only allow to extend. In this case the DeltaQMachine needs to add
/// another type of coffee it will be needed to modify the class, this breaks the Open-close principle. With the
/// Nexpresso machine is expecting something that is a coffee, so if we need to add another type like cappuccino we only
/// need to create a class that is derived from ICoffee 
/// </summary>

#region bad example

public class DeltaQMachine_OP
{
    public void Brew(string coffeeType) 
    {
        switch (coffeeType)
        {
            case "expresso": 
                Console.WriteLine("Brewing expresso"); 
                break;
            case "latte": 
                Console.WriteLine("Brewing latte");
                break;
        }
    }
}

#endregion

#region good example

public interface ICoffee_OP
{
    void Brew();
}

public class Expresso_OP : ICoffee_OP
{
    public void Brew()
    {
        Console.WriteLine("Brewing expresso");
    }
}

public class Latte_OP : ICoffee_OP
{
    public void Brew()
    {
        Console.WriteLine("Brewing latte");
    }
}

public class NexpressoMachine_OP
{
    public void Brew(ICoffee_OP coffee)
    {
        coffee.Brew(); 
    }
}

// var machine = new NexpressoMachine_OP();
// machine.Brew(new Expresso_OP());
// machine.Brew(new Latte_OP());

#endregion