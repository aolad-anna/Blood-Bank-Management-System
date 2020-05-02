using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.DAL
{
    public class BloodDataDal
    {
        public System.Collections.IEnumerable Blood()
        {
            using (var context = new BbmDBEntities())
            {
                var bloodStat =from ins in context.BloodDatas
                    select new
                    {
                        SN=ins.BId,
                        BloodGroup=ins.Title,
                        Available=ins.AvailableQuantity,
                        Capacity=ins.TotalCapacity
                    };
                return bloodStat.ToList();
            }
        }
    }
}
