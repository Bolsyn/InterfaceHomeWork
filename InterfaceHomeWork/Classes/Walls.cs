using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Walls : IPart
    {
        private string name;

        public Walls(string name) { this.name = name; }

        public string GetName { get { return name; } }
    }
}
