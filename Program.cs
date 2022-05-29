using DecoratorPattern;
using FactoryPatterns;
using ObserverPattern;
using StrategyPattern;
using CommandPattern;
using AdapterPattern;
using Singleton;

class Start
{
    public static void Main()
    {
        Energy energy96V = new V96();
        Resistor _resistor48V = new Resistor48V(energy96V);
        Console.WriteLine(energy96V.GetEnergy());
        Console.WriteLine(_resistor48V.GetEnergy());
    }
}
