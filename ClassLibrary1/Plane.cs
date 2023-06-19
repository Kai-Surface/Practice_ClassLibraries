using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Plane : Air
    {
        int _numberOfJets;

        public Plane(int numberOfJets)
        {
            NumberOfJets = numberOfJets;
        }

        public Plane(string color, int v) : base(color)
        {
            V = v;
        }

        public int NumberOfJets { get => _numberOfJets; set => _numberOfJets = value; }
        public int V { get; }

        public override string ToString()
        {
            return base.ToString() + $" - Number of Jets {_numberOfJets}";
        }
    }
}
