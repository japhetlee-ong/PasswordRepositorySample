//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBL_LOGIN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TBL_LOGIN()
        {
            this.TBL_USER_DETAILS = new HashSet<TBL_USER_DETAILS>();
            this.TBL_USER_PASSWORDS = new HashSet<TBL_USER_PASSWORDS>();
        }
    
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public Nullable<System.DateTime> DATE_CREATED { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_USER_DETAILS> TBL_USER_DETAILS { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_USER_PASSWORDS> TBL_USER_PASSWORDS { get; set; }
    }
}
