namespace SOLID_Principles;

/// <summary>
/// As the name suggest a class/object can only have a responsibility. In the example DealtQMachine can make coffee
/// and tea, this break the principle it only should be possible to make the coffee or the tea.
/// </summary>

#region bad example
public class DealtQMachine_SR
{
    public void MakeCoffee()
    {
        Console.WriteLine("Coffee made");
    }

    public void MakeTea()
    {
        Console.WriteLine("Tea made");
    }
}
#endregion

#region good example
public class NexpressoMachine_SR
{
    public void MakeCoffee()
    {
        Console.WriteLine("Coffee made");
    }
}

public class KettleMachine_SR
{
    public void MakeTea()
    {
        Console.WriteLine("Tea made");
    }
}
#endregion