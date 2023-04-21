using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice___Inheritance
{
    internal class Sea : Vehicle
    {
        public enum BoatType {Boat, Submarine }

        public BoatType Type { get; set;}

        public Sea(string color, BoatType type) : base(color)
        {
            Type = type;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - It is a {Type}";
        }


    }
}
