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
        public int status { get; set; }

        public Rent() { }

        public Rent(String pro_id, String user_id)
        {
            this.pro_id = pro_id;
            this.user_id = user_id;
        }

        public Rent(String id, int status, String pro_id)
        {
            this.id = id;
            this.status = status;
            this.pro_id = pro_id;
        }

        public Rent(String id, String pro_id, String user_id, int status) {
            this.id = id;
            this.pro_id = pro_id;
            this.user_id = user_id;
            this.status = status;
        }

        public String toStringStore()
        {
            return "?user_id=" + user_id + "&pro_id=" + pro_id;
        }

        public String toStringUpdate()
        {
            return "?id=" + id + "&status=" + status + "&pro_id=" + pro_id;
        }
    }
}
