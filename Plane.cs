using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Plane : Air
    {
        int  _NumOfJets;

        public int NumOfJets { get { return _NumOfJets; } set { _NumOfJets = value; } }
        public Plane(string color, int numberOfJets) : base() 
        {
            Color = color;
            NumOfJets = numberOfJets;
        
        }
        public override string ToString()
        {
            return $"{base.ToString()} - Number of Jets {NumOfJets}";
        }


    }
}
