//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API_Server.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_Account
    {
        public int id_Account_Type { get; set; }
        public string AccountTypeName { get; set; }
        public string Username { get; set; }
        public string Fullname { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Sex { get; set; }
        public string Url_Image_Avatar { get; set; }
        public Nullable<bool> IsLock { get; set; }
        public Nullable<double> Point { get; set; }
        public Nullable<System.DateTime> Time_LastAccess { get; set; }
        public string ProvinceName { get; set; }
        public string id_Province { get; set; }
        public string DistrictName { get; set; }
        public string id_District { get; set; }
        public string AddressDetail { get; set; }
    }
}
