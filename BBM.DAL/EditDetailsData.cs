using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BBM.Entity;
namespace BBM.DAL
{
    public class EditDetailsData
    {
        //public static UserInfo userDetails = new UserInfo();
        //public static UserInfo addressDetails = new UserInfo();

        public UserInfo InitializeUserInfo(UserInfo userDetails)
        {
            using (var context = new BbmDBEntities())
            {
                var userToEdit = context.Users.SingleOrDefault(x => x.UId == userDetails.UId);
                {
                    userDetails.UId = userToEdit.UId;
                    userDetails.AddressId = userToEdit.AddressId;
                    userDetails.UserRole = userToEdit.UserRole;
                    userDetails.Name = userToEdit.Name;
                    userDetails.Email = userToEdit.Email;
                    userDetails.Password = userToEdit.Password;
                    userDetails.Phone = userToEdit.Phone;
                    userDetails.BloodId = userToEdit.BloodId;
                    userDetails.BloodGroup = userToEdit.BloodData.Title;
                    userDetails.Age = userToEdit.Age;
                }
            }
            return userDetails;
        }
        public AddressInfo InitializeUserAddress(AddressInfo addressDetails)
        {
            using (var context = new BbmDBEntities())
            {
                var addressToEdit = context.Addresses.SingleOrDefault(x => x.AId == addressDetails.AId);
                addressDetails.AId = addressToEdit.AId;
                addressDetails.Houseno = addressToEdit.Houseno;
                addressDetails.Roadno = addressToEdit.Roadno;
                addressDetails.SubDistrict = addressToEdit.SubDistrict;
                addressDetails.District = addressToEdit.District;
                addressDetails.Zip = addressToEdit.Zip;
                addressDetails.Country = addressToEdit.Country;
            }
            return addressDetails;
        }

        public int editUserAddress(AddressInfo addressDetails)
        {
            int addressID = 0;
            using (var context = new BbmDBEntities())
            {
                var editAddress = from addressToEdit in context.Addresses
                                      where addressToEdit.AId == addressDetails.AId
                                      select addressToEdit;
                foreach(var item in editAddress)
                {
                    item.Houseno = addressDetails.Houseno;
                    item.Roadno = addressDetails.Roadno;
                    item.SubDistrict = addressDetails.SubDistrict;
                    item.District = addressDetails.District;
                    item.Country = addressDetails.Country;
                    item.Zip = addressDetails.Zip;
                    addressID = item.AId;
                }
                context.SaveChanges();
            }
            return addressID;
        }

        public int editUserInfo(UserInfo userDetails)
        {
            int userID = 0;
            using (var context = new BbmDBEntities())
            {
                var userToEdit = from ser in context.Users
                                 where ser.UId == userDetails.UId 
                                 && ser.Name == userDetails.Name 
                                 && ser.UserRole == userDetails.UserRole
                                 select ser;
                {
                   foreach(var item in userToEdit)
                    {
                        item.AddressId = userDetails.AddressId;
                        item.Age = userDetails.Age;
                        item.BloodId = userDetails.BloodId;
                        item.Name = userDetails.Name;
                        item.Email = userDetails.Email;
                        item.Phone = userDetails.Phone;
                        item.Password = userDetails.Password;
                        item.UserRole = userDetails.UserRole;
                        item.Date = DateTime.Now;
                        userID = item.UId;
                    }
                    context.SaveChanges();
                }
            }
            return userID;
        }
    }
}
