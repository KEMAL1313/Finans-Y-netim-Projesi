using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialManagement.Model
{
    class Storage
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double MaxCapacity { get; set; }
        public double Capacity { get; set; } = 0;
        public bool IsStatus { get; set; }
        public bool IsDelete { get; set; }
    }
}
