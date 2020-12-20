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
    
    public partial class Watches
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Watches()
        {
            this.CartDetails = new HashSet<CartDetails>();
            this.Hot_Trend = new HashSet<Hot_Trend>();
            this.Image = new HashSet<Image>();
            this.OrderDetails = new HashSet<OrderDetails>();
            this.Watches_Categories = new HashSet<Watches_Categories>();
        }
    
        public int id { get; set; }
        public string Url_Image { get; set; }
        public Nullable<int> id_Sex { get; set; }
        public int id_Firms { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public string Information { get; set; }
        public int id_Shop { get; set; }
        public Nullable<double> Rate { get; set; }
        public Nullable<System.DateTime> Date_Create { get; set; }
        public string Create_By { get; set; }
        public Nullable<System.DateTime> Date_LastEdit { get; set; }
        public string LastEdit_By { get; set; }
        public Nullable<bool> IsLock { get; set; }
        public Nullable<bool> IsCheck { get; set; }
        public Nullable<bool> IsExist { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CartDetails> CartDetails { get; set; }
        public virtual Firms Firms { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Hot_Trend> Hot_Trend { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Image> Image { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<OrderDetails> OrderDetails { get; set; }
        public virtual Sex Sex { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Watches_Categories> Watches_Categories { get; set; }
    }
}
