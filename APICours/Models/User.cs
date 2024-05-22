using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APICours.Models
{
    public class User
    {
        public int Id { get; set; }
        public string  DepartementId{ get; set; }
        public string  Username { get; set; }
        public string  Password { get; set; }

        public string FullName { get; set; }

    }
}
