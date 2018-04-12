using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class Rent
    {
        public String id { get; set; }
        public String pro_id { get; set; }
        public String user_id { get; set; }
        public String status { get; set; }

        public Rent() { }
        public Rent(String pro_id, String user_id)
        {
            this.pro_id = pro_id;
            this.user_id = user_id;
        }
        public Rent(String id, String pro_id, String user_id, String status) {
            this.id = id;
            this.pro_id = pro_id;
            this.user_id = user_id;
            this.status = status;
        }
        public String toStringStore()
        {
            return "?user_id=" + user_id + "&pro_id=" + pro_id;
        }
    }
}
