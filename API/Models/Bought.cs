//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace API.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bought
    {
        public int id { get; set; }
        public Nullable<int> id_Accounts { get; set; }
        public Nullable<double> Price { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<int> Rate { get; set; }
        public Nullable<System.DateTime> Datetime { get; set; }
        public Nullable<int> id_Bills { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual Bills Bills { get; set; }
        public virtual Watches Watches { get; set; }
    }
}