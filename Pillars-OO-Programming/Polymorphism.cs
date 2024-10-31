namespace Pillars_OO_Programming;

/// <summary>
/// Allows the object do different things base on the object they are acting up
/// </summary>

public class CoffeeMachine_P
{
    public virtual void Brew()
    {
        Console.WriteLine("Brew");
    }
}

public class NexpressoMachine_P : CoffeeMachine_P
{
    public override void Brew()
    {
        Console.WriteLine("Brew expresso");
    }
}

public class DeltaQMachine_P : CoffeeMachine_P
{
    public override void Brew()
    {
        Console.WriteLine("Brew deltaQ");
    }
}

public class CoffeeShop_P
{
    public void MakeCoffee(CoffeeMachine_P coffeeMachine)
    {
        coffeeMachine.Brew();
    }
}

// var shop = new CoffeeShop_P();
// shop.MakeCoffee(new NexpressoMachine_P());
// shop.MakeCoffee(new DeltaQMachine_P());