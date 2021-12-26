using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Context context = new Context();

        if(DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 10)
        {
            context.AddStrategy(new Stairs());
        }
        else if(GetProphylacticWorksPresence())
        {
            context.AddStrategy(new Stairs());
            context.AddStrategy(new Elevator());
            context.AddStrategy(new Escalator());
        }
        else
        {
            int elevatorState = GetEquipmentState("elevator");
            int escalatorState = GetEquipmentState("escalator");
            if(elevatorState > escalatorState)
            {
                context.AddStrategy(new Stairs());
                context.AddStrategy(new Elevator());
            }
            else
            {
                context.AddStrategy(new Stairs());
                context.AddStrategy(new Escalator());
            }
        }

        context.ExecuteStrategies();
    }

    static bool GetProphylacticWorksPresence()
    {
        bool prophylacticWorks;
        while(true)
        {
            Console.WriteLine("Is there a prophylactic work today? Y/N");
            ConsoleKeyInfo key = Console.ReadKey();
            if(key.Key == ConsoleKey.Y)
            {
                prophylacticWorks = true;
                break;
            }
            if(key.Key == ConsoleKey.N)
            {
                prophylacticWorks = false;
                break;
            }
            Console.WriteLine("Press either Y or N");
        }
        Console.WriteLine();
        return prophylacticWorks;
    }

    static int GetEquipmentState(string equipment)
    {
        Console.WriteLine($"What state is {equipment} in?");
        string stateStr = Console.ReadLine();
        int state;
        if(int.TryParse(stateStr, out state) && state >= 0)
        {
            return state;
        }
        Console.WriteLine($"Enter integer positive value.");
        return GetEquipmentState(equipment);
    }
}

abstract class Strategy
{
    public abstract void TransferBetweenFloors();
}

class Stairs : Strategy
{
    public override void TransferBetweenFloors()
    {
        Console.WriteLine("Customers transfer between floors by stairs.");
    }
}

class Elevator : Strategy
{
    public override void TransferBetweenFloors()
    {
        Console.WriteLine("Customers transfer between floors by elevator.");
    }
}

class Escalator : Strategy
{
    public override void TransferBetweenFloors()
    {
        Console.WriteLine("Customers transfer between floors by escalator.");
    }
}

class Context
{
    private List<Strategy> strategies;

    public Context()
    {
        this.strategies = new List<Strategy>();
    }

    public bool AddStrategy(Strategy strategy)
    {
        foreach(Strategy str in this.strategies)
        {
            if(str == strategy)
            {
                return false;
            }
        }
        this.strategies.Add(strategy);
        return true;
    }

    public bool RemoveStrategy(Strategy strategy)
    {
        return this.strategies.Remove(strategy);
    }

    public void ExecuteStrategies()
    {
        foreach(Strategy strategy in this.strategies)
        {
            strategy.TransferBetweenFloors();
        }
    }
}
