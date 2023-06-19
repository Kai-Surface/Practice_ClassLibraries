using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Sea : Vehicle
    {
        enum Type { ship, boat, submarine, merchantShip }
        Type _type;

        private Type Type1 { get => _type; set => _type = value; }
        public string V { get; }

        public Sea(Type type)
        {
            Type1 = type;
        }

        public Sea(string color, string v) : base(color)
        {
            V = v;
        }

        public override string ToString()
        {
            return base.ToString() + $" - It is a {_type}";
        }
    }
}
