using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspPerformanceComparison.Data
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public int Height { get; set; }
        public string Occupation { get; set; }
        public string Education { get; set; }
        public string Degree { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
    }
}
