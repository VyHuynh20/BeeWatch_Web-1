//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Local.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_OrderDetail
    {
        public int idOrder { get; set; }
        public Nullable<int> idAccount { get; set; }
        public int idShop { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public string ShopName { get; set; }
        public string UserName { get; set; }
        public int id_Watches { get; set; }
        public string WatchName { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Rate { get; set; }
    }
}
