using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.Entity
{
    public class AddressInfo
    {
        public int AId { get; set; }
        public string Houseno { get; set; }
        public string Roadno { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Country { get; set; }
        public int Zip { get; set; }
    }
}
