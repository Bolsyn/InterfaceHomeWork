using System;

namespace InterfaceHomeWork.Classes
{
    public class Worker : IWorker
    {
        public House Construction(House house)
        {
            try
            {
                if (house.CounterPart() == 0)
                    house.SetPart(new Basement(CheckName(Parting.Basement)));
                else if ((house.CounterPart() < 5) | (house.GetLastPartName() == CheckName(Parting.Basement)))
                    house.SetPart(new Walls(CheckName(Parting.Walls)));
                else if (house.CounterPart() == 5)
                    house.SetPart(new Door(CheckName(Parting.Door)));
                else if (house.GetLastPartName() == CheckName(Parting.Door))
                    house.SetPart(new Roof(CheckName(Parting.Roof)));
                else
                    house.SetPart(new Window(CheckName(Parting.Window)));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return house;
        }
        private string CheckName(Parting part)
        {
            string name = null;
            switch (part)
            {
                case Parting.Basement:
                    name = "Фундамент";
                    break;
                case Parting.Walls:
                    name = "Стена";
                    break;
                case Parting.Door:
                    name = "Дверь";
                    break;
                case Parting.Roof:
                    name = "Крыша";
                    break;
                case Parting.Window:
                    name = "Окно";
                    break;
            }
            return name;
        }
    }
}
