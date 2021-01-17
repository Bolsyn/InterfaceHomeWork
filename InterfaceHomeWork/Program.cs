using System;
using InterfaceHomeWork.Classes;

namespace InterfaceHomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            int CountBasement = 1;
            int CountWalls = 4;
            int CountWindow = 4;
            int CountDoor = 1;
            int CountRoof = 1;

            
            int CountPart = CountBasement + CountWalls + CountWindow + CountDoor + CountRoof;

            House house = new House();
            Team team = new Team(CountPart);
            team.Work(house);
            house.Print();

            Console.ReadKey();
        }
    }
}
