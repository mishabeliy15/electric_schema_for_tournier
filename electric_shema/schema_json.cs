using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace electric_shema
{
    class schema_json
    {
        public struct task
        {
            public string Text;
            public bool Laba;
            public double I;
            public double U;
            public double R;
            public bool add_elements;

        }
        public box[,] kletka { get; set; }
        public Point battery {get;set;}
        public bool power { get; set; }
        public double I { get; set; }
        public double U { get; set; }
        public double R { get; set; }
        public task Task;

        public schema_json()
        {
            this.Task.Laba = false;
            this.Task.add_elements = false;
            power = false;
        }
    }
    class box
    {
        public box()
        {
            Rotate = 0;
            on_of = false;
        }
        public string Name { get; set; }
        public int Rotate { get; set; }
        public double R { get; set; }
        public double U { get; set; }
        public double I { get; set; }
        public bool on_of { get; set; }
    }
}
