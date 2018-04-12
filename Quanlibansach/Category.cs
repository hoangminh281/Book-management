using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class Category
    {
        public int id { get; set; }
        public String name { get; set; }
        public int parent_id { get; set; }
        public String description { get; set; }
  
        public Category() { }

        public Category(int id, String name, int parent_id, String description)
        {
            this.id = id;
            this.name = name;
            this.parent_id = parent_id;
            this.description = description;
        }

        public Category(String name, int parent_id, String description)
        {
            this.name = name;
            this.parent_id = parent_id;
            this.description = description;
        }

        public override string ToString()
        {
            return this.name;
        }
        public String toStringStore()
        {
            return "?name=" + name + "&parent_id=" + parent_id + "&description=" + description;
        }
        public String toStringUpdate()
        {
            return "?id=" + id + "&name=" + name + "&parent_id=" + parent_id + "&description=" + description;
        }
    }
}
