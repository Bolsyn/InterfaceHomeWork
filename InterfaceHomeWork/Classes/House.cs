using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace InterfaceHomeWork.Classes
{
    public class House : IPart
    {
        private string name;
        public string GetName { get { return name; } }
        List<IPart> house;
        public House()
        {
            house = new List<IPart>();
            name = "House";
        }
        public List<IPart> GetHouse() { return house; }
        public void SetPart(IPart obj) { house.Add(obj); }
        public void Print()
        {
            int size = house.Count;
            for (int i = 0; i < size; i++)
                Console.WriteLine(house.ElementAt(i).GetName);
        }
        public int CounterPart()
        { return house.Count; }
        public string GetLastPartName()
        { return house.Last().GetName; }
    }
}
