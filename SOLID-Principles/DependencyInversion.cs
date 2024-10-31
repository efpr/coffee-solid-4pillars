namespace SOLID_Principles;

/// <summary>ce
/// DeltaQMachine_DI should not directly implement the ElectricWaterTank_DI, but lets says now that instead of an
/// electric tank we have a coal tank we need to create another class that implements the coal tank. So in order to fix
/// this we need to abstract the implementation of the water tank.
/// </summary>

#region bad example

public class ElectricWaterTank_DI
{
    public void HeatWater()
    {
        Console.WriteLine("Heating water");
    }
}

public class DeltaQMachine_DI
{
    private readonly ElectricWaterTank_DI _electricWaterTankDi = new ElectricWaterTank_DI();

    public void Brew()
    {
        _electricWaterTankDi.HeatWater();
        Console.WriteLine("Brew coffee");
    }
}

#endregion

#region good example

public interface IWaterTank_DI
{
    void HeatWater();
}

public class CoalWaterTank_DI : IWaterTank_DI
{
    public void HeatWater()
    {
        Console.WriteLine("Heating water");
    }
}

public class NexpressoMachine_DI
{
    private readonly IWaterTank_DI _waterTank;

    public NexpressoMachine_DI(IWaterTank_DI waterTank)
    {
        _waterTank = waterTank;
    }

    public void Brew()
    {
        _waterTank.HeatWater();
        Console.WriteLine("Brew coffee");
    }
}

#endregion