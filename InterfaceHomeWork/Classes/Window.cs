using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceHomeWork.Classes
{
    public class Window : IPart
    {
        private string name;

        public Window(string name) { this.name = name; }

        public string GetName { get { return name; } }
    }
}
