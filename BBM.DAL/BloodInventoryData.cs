using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.DAL
{
    public class BloodInventoryData
    {
        public System.Collections.IEnumerable InventoryData()
        {
            using (var context = new BbmDBEntities())
            {
                var inventoryInstance =
                    from ins in context.BloodInventories
                    select new
                    {
                        ID=ins.BInventory_Id,
                        UserID=ins.BI_UserId,
                        Blood_Group=ins.Blood_Group,
                        Quantity=ins.BI_Quantity,
                        Bag_Code=ins.BI_Bag_Code,
                        Date=ins.BI_Date
                    };
                return inventoryInstance.ToList();
            }
        }
        public System.Collections.IEnumerable InventoryDataByBloodGroup(string bloodGroup)
        {
            using (var context = new BbmDBEntities())
            {
                var inventoryInstance =
                    from ins in context.BloodInventories where ins.Blood_Group==bloodGroup
                    select new
                    {
                        ID = ins.BInventory_Id,
                        UserID = ins.BI_UserId,
                        Blood_Group = ins.Blood_Group,
                        Quantity = ins.BI_Quantity,
                        Bag_Code = ins.BI_Bag_Code,
                        Date = ins.BI_Date
                    };
                return inventoryInstance.ToList();
            }
        }
    }
}
