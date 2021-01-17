using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterfaceHomeWork.Classes
{
    public class Teamleader : IWorker
    {
        public House Construction(House house)
        {
            Console.WriteLine("В доме построено :");
            List<IPart> temp_house = house.GetHouse();
            for (int i = 0; i < house.CounterPart(); i++)
                Console.WriteLine(temp_house.ElementAt(i).GetName);
            return house;
        }
    }
}
