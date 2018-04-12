using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class Permission
    {
        public String id { get; set; }
        public String name { get; set; }

        public Permission() { }
        public Permission(String name)
        {
            this.name = name;
        }
        public Permission(String id, String name)
        {
            this.id = id;
            this.name = name;
        }

        public String toStringStore()
        {
            return "?name=" + name;
        }
        public String toStringUpdate()
        {
            return "?id=" + id + "&name=" + name;
        }
        public override String ToString()
        {
            return name;
        }
    }
}
