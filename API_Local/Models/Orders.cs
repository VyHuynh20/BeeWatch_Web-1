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
    
    public partial class Orders
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Orders()
        {
            this.OrderDetails = new HashSet<OrderDetails>();
        }
    
        public int id { get; set; }
        public int id_Shop { get; set; }
        public Nullable<int> id_Accounts { get; set; }
        public string Address_Province { get; set; }
        public string Address_District { get; set; }
        public string AddressDetail { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> Sum { get; set; }
        public Nullable<double> Ship_fee { get; set; }
        public Nullable<int> id_Discount { get; set; }
        public string Payment { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public Nullable<System.DateTime> Date_Check { get; set; }
        public string User_Check { get; set; }
        public Nullable<int> Status { get; set; }
    
        public virtual Accounts Accounts { get; set; }
        public virtual Address_District Address_District1 { get; set; }
        public virtual Address_Province Address_Province1 { get; set; }
        public virtual Discounts Discounts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Shops Shops { get; set; }
    }
}
