//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IgrEbillsApi.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class mda
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public mda()
        {
            this.remittances = new HashSet<remittance>();
        }
    
        public string MDA_ID { get; set; }
        public string IGR_ID { get; set; }
        public string MDA_Category { get; set; }
        public string MDA_DetailedCategory { get; set; }
        public string MDA_Name { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<System.DateTime> DateUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<remittance> remittances { get; set; }
    }
}
