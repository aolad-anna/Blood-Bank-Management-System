//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BBM.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class History
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
