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
    
    public partial class Phone
    {
        public int id_Account { get; set; }
        public string Phone1 { get; set; }
        public int id { get; set; }
    
        public virtual Accounts Accounts { get; set; }
    }
}
