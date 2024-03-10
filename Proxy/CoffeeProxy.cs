using System;

public class CoffeeProxy : IHotBeverage
{
    private Coffee coffee;

    public CoffeeProxy(string type)
    {
        coffee = new Coffee(type);
    }

    public void AddMilk()
    {
        coffee.AddMilk();
    }

    public void AddSugar()
    {
        coffee.AddSugar();
    }

    public void Serve()
    {
        coffee.Serve();
    }
}
