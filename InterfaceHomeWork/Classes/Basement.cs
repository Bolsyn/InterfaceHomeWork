using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Basement : IPart
    {
        private string name;

        public Basement(string name) { this.name = name; }

        public string GetName { get { return name; } }
    }
}
