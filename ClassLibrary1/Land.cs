using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Land : Vehicle
    {
        int _wheels;

        public Land(int wheels, string color) : base(wheels, color)
        {
            this.Wheels = _wheels;
        }

        public Land(string color, int v) : base(color)
        {
            V = v;
        }

        public int Wheels { get => _wheels; set => _wheels = value; }
        public int V { get; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Wheels {_wheels} ";
        }
    }
}
