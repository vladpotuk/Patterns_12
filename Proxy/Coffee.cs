using System;

public class Coffee : IHotBeverage
{
    private string type;
    private bool milkAdded;
    private bool sugarAdded;

    public Coffee(string type)
    {
        this.type = type;
        milkAdded = false;
        sugarAdded = false;
    }

    public void AddMilk()
    {
        milkAdded = true;
        Console.WriteLine("Milk added to the coffee.");
    }

    public void AddSugar()
    {
        sugarAdded = true;
        Console.WriteLine("Sugar added to the coffee.");
    }

    public void Serve()
    {
        Console.WriteLine($"Serving {type} coffee...");
        Console.WriteLine("Enjoy your coffee!");
    }
}

