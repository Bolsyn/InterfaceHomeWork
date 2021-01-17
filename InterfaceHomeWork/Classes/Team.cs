using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Team
    {
        private IWorker teamLeader;
        private Worker[] workers;
        public Team(int count)
        {
            teamLeader = new Teamleader();
            workers = new Worker[count];
            for (int i = 0; i < count; i++)
                workers[i] = new Worker();
        }

        private int Choice()
        {
            int choice = 0;
            while ((choice < 1) | (choice > 2))
            {
                Console.WriteLine("Ваши действия? \n 1) Построить следующий объект \n " +
                        "2) Вызвать бригадира и получить отчёт о строительстве");
                try
                {
                    choice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            return choice;
        }

        public House Work(House house)
        {
            for (int i = 0; i < workers.Length; i++)
            {
                int choice = Choice();
                if (choice == 1)
                {
                    house = workers[i].Construction(house);
                }
                else if (choice == 2)
                {
                    teamLeader.Construction(house);
                    i--;
                }
            }
            Console.WriteLine("House Complete!");
            return house;
        }
    }
}
