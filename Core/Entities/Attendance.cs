using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Attendance
    {
        public string id { get; set; }
        public DateTime date { get; set; }
        public bool present { get; set; }
        public string employeeId { get; set; }
        public Employee employee { get; set; }
    }
}
