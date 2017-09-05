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
        public string om { get; set; }
        public string power { get; set; }
        public string volt { get; set; }
    }
}
