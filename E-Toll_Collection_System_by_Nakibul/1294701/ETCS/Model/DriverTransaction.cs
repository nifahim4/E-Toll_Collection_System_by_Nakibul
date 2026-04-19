using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.Model
{
    public class DriverTransaction : BaseEntity
    {
        public string name { get; set; }
        public string licenseNumber { get; set; }
        public int vehicleTypeId { get; set; }
        public DateTime transactionDate { get; set; }
    }
}
