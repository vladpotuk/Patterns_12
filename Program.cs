using System;

class Program
{
    static void Main(string[] args)
    {
        
        IHotBeverage coffeeProxy = new CoffeeProxy("Espresso");

        
        ((CoffeeProxy)coffeeProxy).AddMilk();
        ((CoffeeProxy)coffeeProxy).AddSugar();

       
        coffeeProxy.Serve();
    }
}
