using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quanlibansach
{
    public class User
    {
        public User() { }

        public User(String name, String email, String password, String role)
        {
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }
        public User(String id, String name, String email, String password, String role)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
            this.role = role;
        }

        public String id { get; set; }
        public String name { get; set; }
        public String email { get; set; }
        public String role { get; set; }
        public String password { get; set; }

        public String toString()
        {
            return "Id = " + id + " | Name: " + name + " | Role: " + role; 
        }
        public String toStringStore()
        {
            return String.Format("?name={0}&email={1}&password={2}&role={3}",name,email,password,role);
        }
        public String toStringUpdate()
        {
            return String.Format("?id={0}&name={1}&email={2}&password={3}&role={4}", id, name, email, password, role);
        }
        public override string ToString()
        {
            return name;
        }
    }
}
