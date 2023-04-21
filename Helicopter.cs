using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Helicopter : Air
    {
        int _NumofProps;
        public int NumofProps { get { return _NumofProps; } set { _NumofProps = value; } }

        public Helicopter(string color, int numofpropellers) : base() 
        {
            Color = color;
            NumofProps = numofpropellers;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Number of Propellers {NumofProps}";
        }
    }
}
