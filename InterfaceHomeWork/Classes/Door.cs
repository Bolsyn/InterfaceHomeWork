using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Door : IPart
    {
        private string name;

        public Door(string name) { this.name = name; }

        public string GetName { get { return name; } }
    }
}
