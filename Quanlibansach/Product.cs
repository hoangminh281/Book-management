using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class Product
    {
        public Product() { }
        public Product(String name, String cate_id, String price, String intro, String description, String image, String status)
        {
            this.name = name;
            this.cate_id = int.Parse(cate_id);
            this.price = double.Parse(price);
            this.intro = intro;
            this.description = description;
            this.image = image;
            this.status = int.Parse(status);
        }

        public Product(String id, String name, String cate_id, String price, String intro, String description, String image, String status)
        {
            this.id = int.Parse(id);
            this.name = name;
            this.cate_id = int.Parse(cate_id);
            this.price = double.Parse(price);
            this.intro = intro;
            this.description = description;
            this.image = image;
            this.status = int.Parse(status);
        }

        public int id { get; set; }
        public String name { get; set; }
        public int cate_id { get; set; }
        public double price { get; set; }
        public String intro { get; set; }
        public String description { get; set; }
        public String image { get; set; }
        public int view { get; set; }
        public int status { get; set; }

        public String toStringStore()
        {
            return "?name=" + name + "&cate_id=" + cate_id + "&price=" + price + "&intro=" + intro + "&description=" + description + "&image=" + image + "&status=" + status;
        }
        public String toStringUpdate()
        {
            return "?id=" + id + "&name=" + name + "&cate_id=" + cate_id + "&price=" + price + "&intro=" + intro + "&description=" + description + "&image=" + image + "&status=" + status;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
