using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Vehicle
    {
        public string _color;
        public string Color { get { return _color; } set { _color = value; } }

        public Vehicle(string color) 
        {
            Color = color;
        }

        public override string ToString()
        {
            return $"{this.GetType().Name} - {Color}";
        }

    }
}
