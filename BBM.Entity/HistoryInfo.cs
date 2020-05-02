using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.Entity
{
    public class HistoryInfo
    {
        public int HId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string RequestType { get; set; }
        public string BloodGroup { get; set; }
        public int Quantity { get; set; }
        public string History_Bag_Code { get; set; }
        public System.DateTime History_date { get; set; }
    }
}
