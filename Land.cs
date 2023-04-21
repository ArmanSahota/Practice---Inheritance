using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Land : Vehicle
    {
        int _Wheels;

        public int Wheels { get { return _Wheels; } set { _Wheels = value; } }
        public Land(string color, int wheels) : base(color)
        {
            Wheels = wheels;
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Number of Wheels {Wheels}";
        }


    }
}
