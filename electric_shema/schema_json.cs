using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electric_shema
{
    class schema_json
    {
        public box[,] kletka { get; set; }
    }
    class box
    {
        public string Name { get; set; }
        public bool Vertical { get; set; }
        public object Properties { get; set; }
        public box()
        {
            Vertical = false;
        }
    }
    class Resistor
    {
        public double R { get; set; }
        public string Text { get; set; }
    }
    class Battery
    {
        public double U { get; set; }
        public string Text { get; set; }
    }
    class Ampermetr
    {
        public double I { get; set; }
    }
}
