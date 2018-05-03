using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class StatusRent
    {
        public int id { get; set; }
        public String name { get; set; }

        public StatusRent() { }
        public StatusRent(int id, String name)
        {
            this.id = id;
            this.name = name;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
