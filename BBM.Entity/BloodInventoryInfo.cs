using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.Entity
{
    public class BloodInventoryInfo
    {
        public int BInventory_Id { get; set; }
        public int BI_UserId { get; set; }
        public string Blood_Group { get; set; }
        public string BI_Quantity { get; set; }
        public string BI_Bag_Code { get; set; }
        public System.DateTime BI_Date { get; set; }
    }
}
