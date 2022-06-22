using Labb3_Vidareutveckla;
using System;
using System.Collections.Generic;

namespace VarmDrinkStation
{

    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine();
            IWarmDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}