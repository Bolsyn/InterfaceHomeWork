using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Roof : IPart
    {
        private string name;

        public Roof(string name) { this.name = name; }

        public string GetName { get { return name; } }
    }
}
