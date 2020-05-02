using BBM.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBM.DAL
{
    public class HistoryData
    {
        //all history of user by userID for UserHistory->Form
        public System.Collections.IEnumerable UserHistory(int id)
        {
            using (var context = new BbmDBEntities())
            {
                var HistoryInstance =
                    from ins in context.Histories
                    where ins.UserId == id
                    select new
                    {
                        SN = ins.HId,
                        //ID= ins.UserId,
                        Name= ins.UserName,
                        Request = ins.RequestType,
                        Blood_Group= ins.BloodGroup,
                        Quantity= ins.Quantity,
                        Bag_Code = ins.History_Bag_Code,
                        Date = ins.History_date
                    };
                return HistoryInstance.ToList();
            }
        }
        
        public System.Collections.IEnumerable ExchangeHistory()
        {
            using (var context = new BbmDBEntities())
            {
                var HistoryInstance =
                    from ins in context.Histories
                    select new
                    {
                       // SN = ins.HId,
                        ID= ins.UserId,
                        Name = ins.UserName,
                        Request = ins.RequestType,
                        Blood_Group = ins.BloodGroup,
                        Quantity = ins.Quantity,
                        Bag_Code = ins.History_Bag_Code,
                        Date = ins.History_date
                    };
                return HistoryInstance.ToList();
            }
        }
        
        public System.Collections.IEnumerable HistoryByRequest(string keyword)
        {
            using (var context = new BbmDBEntities())
            {
                var HistoryInstance =
                    from ins in context.Histories
                    where ins.RequestType==keyword
                    select new
                    {
                       // SN = ins.HId,
                        ID= ins.UserId,
                        Name = ins.UserName,
                        Request = ins.RequestType,
                        Blood_Group = ins.BloodGroup,
                        Quantity = ins.Quantity,
                        Bag_Code = ins.History_Bag_Code,
                        Date = ins.History_date
                    };
                return HistoryInstance.ToList();
            }
        }
     
        public System.Collections.IEnumerable HistoryByUserName(string userName)
        {
            using (var context = new BbmDBEntities())
            {
                var HistoryInstance =
                    from ins in context.Histories
                    where ins.UserName==userName
                    select new
                    {
                     //   SN = ins.HId,
                        ID= ins.UserId,
                        Name = ins.UserName,
                        Request = ins.RequestType,
                        Blood_Group = ins.BloodGroup,
                        Quantity = ins.Quantity,
                        Bag_Code = ins.History_Bag_Code,
                        Date = ins.History_date
                    };
                return HistoryInstance.ToList();
            }
        }
    }
}
