﻿using System;
using System.Collections.Generic;
using System.Drawing;
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
        public box()
        {
            Rotate = 0;
        }
        public string Name { get; set; }
        public int Rotate { get; set; }
        public double R { get; set; }
        public double U { get; set; }
        public double I { get; set; }
    }
}
