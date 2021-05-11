using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LISTCRUD18032021.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string City { get; set; }
        public string Country { get; set;  }
        public List<Employee> userList { get; set; }
    }
}