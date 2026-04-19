using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETCS.Model
{
    public class VehicleType : BaseEntity
    {
        public string typeName { get; set; }
        public double tollFee { get; set; }
    }
}
